using System.Diagnostics;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrat4Xenia
{
    public partial class TextRedactorForm : Form
    {
        private const int LEFT_PADDING_TEXT_BOX = 20;
        private const int TOP_MADDING_TEXT_BOX = 50;
        public TextRedactorForm()
        {
            InitializeComponent();
        }
        IntegratedMenuStripFileSelector currentFile;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Size = new Size(
                this.Size.Width - textBox1.Location.X - LEFT_PADDING_TEXT_BOX,
                this.Size.Height - textBox1.Location.Y - TOP_MADDING_TEXT_BOX
                );
            for (int i = 2; i < èçìåíèòüÐàçìåðToolStripMenuItem.DropDownItems.Count; i++)
                èçìåíèòüÐàçìåðToolStripMenuItem.DropDownItems[i].Click += updateFontSize;

            lastFontSize = çàäàòüØðèôòToolStripMenuItem.Text = textBox1.Font.Size.ToString();

            for (int i = 1; i < èçìåíèòüØðèôòToolStripMenuItem.DropDownItems.Count; i++)
                èçìåíèòüØðèôòToolStripMenuItem.DropDownItems[i].Click += fontStyleUpdate;


            lastFontName = toolStripMenuItem11.Text = textBox1.Font.Name;


            ñòàíäàðòíàÊîäèðîâêàToolStripMenuItem.Text = Encoding.Default.EncodingName;
            Text = Encoding.Default.EncodingName;
            currentFile = new IntegratedMenuStripFileSelector(menuStrip1);
            currentFile.getText += FileSelecorClick;
            currentFile.StandartFile();
        }
        private void ýêñïîðòèðîâàòüÂtxtÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = currentFile.ExportCurrentText();
            }
            catch (NonCurrentExpression ex)
            {
                textBox1.Text = currentFile.ExportCurrentText(textBox1.Text);
            }
        }
        private void èìïîðîâàòütxtÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = currentFile.ImportTextFromDialog();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            currentFile.CurrentText = textBox1.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentFile.SaveAllText();
        }

        private void FileSelecorClick(object sender, EventArgs e)
        {
            textBox1.Text = currentFile.CurrentText;
        }

        private void ñòàíäàðòíàÊîäèðîâêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFile.encoding = Encoding.Default;
            Text = currentFile.encoding.EncodingName;
        }

        private void aSCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFile.encoding = Encoding.ASCII;
            Text = currentFile.encoding.EncodingName;
        }

        private void uTF32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFile.encoding = Encoding.UTF32;
            Text = currentFile.encoding.EncodingName;
        }

        private void îòìåíàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = currentFile.Undo;
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String RedoStr = currentFile.Redo;
            if(RedoStr != null ) 
            {
                textBox1.Text = RedoStr;
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
    }
}