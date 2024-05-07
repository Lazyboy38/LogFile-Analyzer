using System.CodeDom;
using System.Diagnostics;

namespace LogFile_Analyzer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btChooseLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog logFileDialog = new OpenFileDialog()
            {
                Title = "Browse logfiles",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Text Files Only (*.txt)|*.txt"
            };

            if (logFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = logFileDialog.FileName;
            }
        }

        public string chosenErrorText = "ERROR";

        private void btProcess_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button pressed");
            string logPath = tbFilePath.Text;
            string processedAfter;
            string tireList = "";
            string[] errorCases = [];
            string[] uniqueArticles = [];
            string[] lines = File.ReadAllLines(logPath);
            foreach (string line in lines)
            {
                if (line.Contains("Model could not"))
                {
                    Debug.WriteLine("Found model matching error");
                    processedAfter = getBetween(line, "] Model[", "_Ser");
                    errorCases = errorCases.Append<string>(processedAfter).ToArray();
                }

            }
            Debug.WriteLine("Loop finished!");

            uniqueArticles = errorCases.Distinct().ToArray();
            Array.Sort(uniqueArticles);
            foreach (string article in uniqueArticles)
            {
                Debug.WriteLine(article);
                tireList = tireList + article + Environment.NewLine;
            }
            tbFailedTires.Text = tireList;
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strEnd) && strSource.Contains(strStart))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart) + strStart.Length;
                End = strSource.IndexOf(strEnd);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }
        private void comboError_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbOther.Enabled = false;
            lbOther.Enabled = false;

            if (comboError.SelectedIndex == 0) 
            {
                chosenErrorText = "Model could not";
            }
            else if (comboError.SelectedIndex == 1)
            {
                chosenErrorText = "Postvalidation Error";
            }
            else if(comboError.SelectedIndex == 2)
            {
                chosenErrorText = "DOT could not be found";
            }
            else if (comboError.SelectedIndex == 3)
            {
                chosenErrorText = "ERROR";
            }
            else 
            {
                tbOther.Enabled = true;
                lbOther.Enabled = true;
                chosenErrorText = tbOther.Text; 
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            comboError.SelectedIndex = 3;
            tbOther.Enabled = false;
            lbOther.Enabled = false;
        }
    }
}
