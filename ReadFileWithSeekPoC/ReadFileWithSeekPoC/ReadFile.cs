using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFileWithSeekPoC
{
    /// <summary>
    /// Read file with seek, so it doesn't read all of the files.
    /// 
    /// github: bowozer
    /// </summary>
    public partial class ReadFile : Form
    {
        const string FILE_PATH = @"..\..\..\FileToRead.txt";
        // in seconds
        private const int READ_FILE_TIMER = 10;

        private long _lastPosition = 0;
        private DateTime _lastReadTime = DateTime.MinValue;
        private delegate void RefreshTimestampTextDelegate();
        private delegate void AppendTextDelegate(string text);

        public ReadFile()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            ReadTheFile();
        }

        private void ReadFile_Load(object sender, EventArgs e)
        {
            // Task that run forever
            var task = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    ReadTheFile();
                    Thread.Sleep(READ_FILE_TIMER * 1000);
                }
            });
        }

        private void ReadTheFile()
        {
            using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileStream.Seek(_lastPosition, SeekOrigin.Begin);

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    AppendTextThreadSafe(line);
                }

                _lastPosition = fileStream.Position;
            }

            _lastReadTime = DateTime.Now;
            RefreshTimestampThreadSafe();
        }

        private void RefreshTimestampThreadSafe()
        {
            if (UpdatedTimestampLbl.InvokeRequired)
            {
                UpdatedTimestampLbl.Invoke(new RefreshTimestampTextDelegate(RefreshTimestampText));
            }
            else
            {
                RefreshTimestampText();
            }
        }

        private void AppendTextThreadSafe(string line)
        {
            if (FileContent.InvokeRequired)
            {
                FileContent.Invoke(new AppendTextDelegate(FileContent.AppendText), line);
                FileContent.Invoke(new AppendTextDelegate(FileContent.AppendText), Environment.NewLine);
            }
            else
            {
                FileContent.AppendText(line);
                FileContent.AppendText(Environment.NewLine);
            }
        }

        private void RefreshTimestampText()
        {
            UpdatedTimestampLbl.Text = $"Updated at {_lastReadTime:u}";
        }
    }
}
