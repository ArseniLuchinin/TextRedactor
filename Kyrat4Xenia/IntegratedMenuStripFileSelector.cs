using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrat4Xenia
{   
    class NonCurrentExpression : Exception
    {

    }

    public class IntegratedMenuStripFileSelector
    {
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        public delegate void OutCliscEvent(object? sender, EventArgs e);
        public OutCliscEvent getText;

        
        public IntegratedMenuStripFileSelector(MenuStrip m) 
        {   
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.Title = "Открыть текстовый файл";

            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000 * 60 * 3;
            timer1.Tick += timer1_Tick;

            OpendFiles = new OpendInMenuFileList(m.Items);
            StandartMenuItemColor = m.Items[0].BackColor;

            timer1.Start();
        }
        public void StandartFile()
        {
            NewFile("", Environment.CurrentDirectory + @"\Standart_file.txt");
        }


        public Encoding encoding = Encoding.Default;

        OpendInMenuFileList OpendFiles;
        OpendInMenuFile _currnet;
        private Color StandartMenuItemColor;
        OpendInMenuFile Currnet
        {
            get => _currnet;
            set
            {
                if (_currnet == null)
                    _currnet = value;
                else if (value == null)
                {
                    StandartFile();
                    return;
                }
                _currnet.BackColor = StandartMenuItemColor;
                value.BackColor = Color.Gray;
                _currnet = value;
            }
        }

        public String CurrentText
        {
            get => Currnet.file.TextInBox;
            set 
            {
                Currnet.file.TextInBox = value;
                String str = value;
                Currnet.file.Undo = str.Substring(0, str.Length);
            }
        }
        public String ExportCurrentText(String text)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, text, encoding);
            return "";
        }


        public String ExportCurrentText()
        {
            String ReturnedText = "";
            if (Currnet == null)
                throw new NonCurrentExpression();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileSave(saveFileDialog1.FileName);
                
                OpendFiles.Remove(Currnet);
                int i = OpendFiles.Count - 1;
                    
                if (i >= 0)
                {
                    Currnet = OpendFiles[i] as OpendInMenuFile;
                    ReturnedText = Currnet.file.TextInBox;
                }
                else
                    StandartFile();
            }
            return ReturnedText;
        }
        
        public String ImportTextFromDialog()
        {
            String ReturnedText = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    String fileName = openFileDialog1.FileName;
                    String textInFile = File.ReadAllText(fileName, encoding);
                    NewFile(textInFile, fileName);
                    ReturnedText = textInFile;

                }
                catch (SecurityException ex)
                {
                    String mes = "Не удалось открыть файл";
                    MessageBox.Show(
                        mes,
                        mes,
                        MessageBoxButtons.OK
                        );
                }
            }
            return ReturnedText;
        }
        private void NewFile(String text, String PathToFile)
        {
            OpendInMenuFile item = new OpendInMenuFile(new OpendFile(PathToFile, text));
            String fileName = PathToFile.Split(@"\").Last();
            item.Text = fileName;
            item.Click += FileClisck;
            OpendFiles.Add(item);
            Currnet = item;
        }
        private void FileClisck(object sender, EventArgs e)
        {
            Currnet = sender as OpendInMenuFile;
            getText(this, e);
        }
        private void FileSave(String PathToFile)
        {
            File.WriteAllText(PathToFile, Currnet.file.TextInBox, encoding);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FileSave(Currnet.file.path);
        }

        public void SaveAllText()
        {
            foreach (OpendInMenuFile item in OpendFiles)
            {
                FileSave(item.file.path);
            }
        }
        public String Undo
        {
            get{
                return Currnet.file.Undo;
            }
        }

        public String Redo
        {
            get => Currnet.file.Redo;
        }
    }
}
