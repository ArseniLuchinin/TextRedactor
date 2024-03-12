using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrat4Xenia
{
    public partial class TextRedactorForm : Form
    {
        String lastFontName;
        private void setFont(String fontName)
        {
            float siz = textBox1.Font.Size;
            textBox1.SelectionFont = new Font(fontName, siz);
            lastFontName = fontName;
        }
        private void fontStyleUpdate(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            setFont(item.Text);
        }

        private void closeFontStyleSelector(object sender, EventArgs e)
        {
            toolStripMenuItem11.Text = lastFontName;
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;

            ToolStripTextBox box = sender as ToolStripTextBox;
            if (e.KeyChar == (char)Keys.Enter)
            {
                setFont(box.Text);
            }   
        }

        private void импортроватьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.SelectionFont = fontDialog1.Font;
            }
        }
    }
}
