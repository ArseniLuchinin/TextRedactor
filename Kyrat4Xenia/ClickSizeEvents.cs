using MultiTask;
using System.Drawing;

namespace Kyrat4Xenia
{
    public partial class TextRedactorForm : Form
    {
        private String lastFontSize;
        private void setFontSize(String str)
        {
            int textSize = Convert.ToInt32(str);
            textBox1.SelectionFont = new Font(textBox1.Font.Name, textSize);
            lastFontSize = str;
        }
        private void updateFontSize(object sender, EventArgs e)
        {
            ToolStripMenuItem eventCaller = sender as ToolStripMenuItem;
            setFontSize(eventCaller.Text);
            задатьШрифтToolStripMenuItem.Text = eventCaller.Text;
        }
        private void setHandMadeFontSize(object sender, EventArgs e)
        {
            if( WinFormInstruments.enterInt(задатьШрифтToolStripMenuItem.Text))
            {
                try
                {
                    setFontSize(задатьШрифтToolStripMenuItem.Text);
                }
                catch(OverflowException Ex) 
                {
                    gobackToOneWord();
                    setFontSize(задатьШрифтToolStripMenuItem.Text);
                }
            }
            else
            {
                gobackToOneWord();
            }
        }
        
        private void gobackToOneWord()
        {
            int indexLastWord = задатьШрифтToolStripMenuItem.Text.Length;
            indexLastWord = indexLastWord != 0
                ? indexLastWord - 1
                : 0;
            задатьШрифтToolStripMenuItem.Text = задатьШрифтToolStripMenuItem.Text.Remove(indexLastWord);
            задатьШрифтToolStripMenuItem.SelectionStart = задатьШрифтToolStripMenuItem.Text.Length;
        }
        private void fontSelectorClose(object sender, EventArgs e)
        {
            задатьШрифтToolStripMenuItem.Text = lastFontSize;
        }
    }
}
