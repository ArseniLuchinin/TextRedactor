using System.Text;
using System.Windows.Forms;

namespace Kyrat4Xenia
{
    partial class TextRedactorForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            импороватьtxtФайлToolStripMenuItem = new ToolStripMenuItem();
            экспортироватьВtxtФайлToolStripMenuItem = new ToolStripMenuItem();
            инструментыToolStripMenuItem = new ToolStripMenuItem();
            изменитьРазмерToolStripMenuItem = new ToolStripMenuItem();
            задатьШрифтToolStripMenuItem = new ToolStripTextBox();
            toolStripMenuItem2 = new ToolStripSeparator();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            изменитьШрифтToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripTextBox();
            timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
            arialToolStripMenuItem = new ToolStripMenuItem();
            импортирватьШрифтToolStripMenuItem = new ToolStripMenuItem();
            кодировкаToolStripMenuItem = new ToolStripMenuItem();
            стандартнаКодировкаToolStripMenuItem = new ToolStripMenuItem();
            aSCIIToolStripMenuItem = new ToolStripMenuItem();
            uTF32ToolStripMenuItem = new ToolStripMenuItem();
            отменаToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            rToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            //textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(797, 421);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, инструментыToolStripMenuItem, отменаToolStripMenuItem, rToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { импороватьtxtФайлToolStripMenuItem, экспортироватьВtxtФайлToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // импороватьtxtФайлToolStripMenuItem
            // 
            импороватьtxtФайлToolStripMenuItem.Name = "импороватьtxtФайлToolStripMenuItem";
            импороватьtxtФайлToolStripMenuItem.Size = new Size(280, 26);
            импороватьtxtФайлToolStripMenuItem.Text = "Импоровать .txt файл";
            импороватьtxtФайлToolStripMenuItem.Click += импороватьtxtФайлToolStripMenuItem_Click;
            // 
            // экспортироватьВtxtФайлToolStripMenuItem
            // 
            экспортироватьВtxtФайлToolStripMenuItem.Name = "экспортироватьВtxtФайлToolStripMenuItem";
            экспортироватьВtxtФайлToolStripMenuItem.Size = new Size(280, 26);
            экспортироватьВtxtФайлToolStripMenuItem.Text = "Экспортировать в .txt файл";
            экспортироватьВtxtФайлToolStripMenuItem.Click += экспортироватьВtxtФайлToolStripMenuItem_Click;
            // 
            // инструментыToolStripMenuItem
            // 
            инструментыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { изменитьРазмерToolStripMenuItem, изменитьШрифтToolStripMenuItem, импортирватьШрифтToolStripMenuItem, кодировкаToolStripMenuItem });
            инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            инструментыToolStripMenuItem.Size = new Size(117, 24);
            инструментыToolStripMenuItem.Text = "Инструменты";
            инструментыToolStripMenuItem.DropDownClosed += closeFontStyleSelector;
            // 
            // изменитьРазмерToolStripMenuItem
            // 
            изменитьРазмерToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { задатьШрифтToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10 });
            изменитьРазмерToolStripMenuItem.Name = "изменитьРазмерToolStripMenuItem";
            изменитьРазмерToolStripMenuItem.Size = new Size(245, 26);
            изменитьРазмерToolStripMenuItem.Text = "Изменить размер";
            изменитьРазмерToolStripMenuItem.DropDownClosed += fontSelectorClose;
            // 
            // задатьШрифтToolStripMenuItem
            // 
            задатьШрифтToolStripMenuItem.AccessibleName = "";
            задатьШрифтToolStripMenuItem.ForeColor = SystemColors.InactiveCaptionText;
            задатьШрифтToolStripMenuItem.Name = "задатьШрифтToolStripMenuItem";
            задатьШрифтToolStripMenuItem.Size = new Size(224, 27);
            задатьШрифтToolStripMenuItem.TextChanged += setHandMadeFontSize;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(295, 6);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(298, 26);
            toolStripMenuItem3.Text = "1";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(298, 26);
            toolStripMenuItem4.Text = "2";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(298, 26);
            toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(298, 26);
            toolStripMenuItem6.Text = "8";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(298, 26);
            toolStripMenuItem7.Text = "16";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(298, 26);
            toolStripMenuItem8.Text = "24";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(298, 26);
            toolStripMenuItem9.Text = "32";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(298, 26);
            toolStripMenuItem10.Text = "54";
            // 
            // изменитьШрифтToolStripMenuItem
            // 
            изменитьШрифтToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem11, timesNewRomanToolStripMenuItem, arialToolStripMenuItem });
            изменитьШрифтToolStripMenuItem.Name = "изменитьШрифтToolStripMenuItem";
            изменитьШрифтToolStripMenuItem.Size = new Size(245, 26);
            изменитьШрифтToolStripMenuItem.Text = "Изменить шрифт";
            изменитьШрифтToolStripMenuItem.DropDownClosed += closeFontStyleSelector;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(224, 27);
            toolStripMenuItem11.KeyPress += CheckEnterKeyPress;
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(298, 26);
            timesNewRomanToolStripMenuItem.Text = "Times new roman";
            // 
            // arialToolStripMenuItem
            // 
            arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            arialToolStripMenuItem.Size = new Size(298, 26);
            arialToolStripMenuItem.Text = "Arial";
            // 
            // импортирватьШрифтToolStripMenuItem
            // 
            импортирватьШрифтToolStripMenuItem.Name = "импортирватьШрифтToolStripMenuItem";
            импортирватьШрифтToolStripMenuItem.Size = new Size(245, 26);
            импортирватьШрифтToolStripMenuItem.Text = "Импортирвать шрифт";
            импортирватьШрифтToolStripMenuItem.Click += импортроватьШрифтToolStripMenuItem_Click;
            // 
            // кодировкаToolStripMenuItem
            // 
            кодировкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { стандартнаКодировкаToolStripMenuItem, aSCIIToolStripMenuItem, uTF32ToolStripMenuItem });
            кодировкаToolStripMenuItem.Name = "кодировкаToolStripMenuItem";
            кодировкаToolStripMenuItem.Size = new Size(245, 26);
            кодировкаToolStripMenuItem.Text = "Кодировка";
            // 
            // стандартнаКодировкаToolStripMenuItem
            // 
            стандартнаКодировкаToolStripMenuItem.Name = "стандартнаКодировкаToolStripMenuItem";
            стандартнаКодировкаToolStripMenuItem.Size = new Size(200, 26);
            стандартнаКодировкаToolStripMenuItem.Text = "Unicode (UTF-8)";
            стандартнаКодировкаToolStripMenuItem.Click += стандартнаКодировкаToolStripMenuItem_Click;
            // 
            // aSCIIToolStripMenuItem
            // 
            aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
            aSCIIToolStripMenuItem.Size = new Size(200, 26);
            aSCIIToolStripMenuItem.Text = "ASCII";
            aSCIIToolStripMenuItem.Click += aSCIIToolStripMenuItem_Click;
            // 
            // uTF32ToolStripMenuItem
            // 
            uTF32ToolStripMenuItem.Name = "uTF32ToolStripMenuItem";
            uTF32ToolStripMenuItem.Size = new Size(200, 26);
            uTF32ToolStripMenuItem.Text = "UTF-32";
            uTF32ToolStripMenuItem.Click += uTF32ToolStripMenuItem_Click;
            // 
            // отменаToolStripMenuItem
            // 
            отменаToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            отменаToolStripMenuItem.Image = Properties.Resources.undo;
            отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            отменаToolStripMenuItem.Size = new Size(34, 24);
            отменаToolStripMenuItem.Text = "Отмена";
            отменаToolStripMenuItem.Click += отменаToolStripMenuItem_Click;
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rToolStripMenuItem.Image = Properties.Resources.redo;
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(34, 24);
            rToolStripMenuItem.Text = "r";
            rToolStripMenuItem.Click += rToolStripMenuItem_Click;
            // 
            // TextRedactorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TextRedactorForm";
            Text = "(Кодировка)";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem импороватьtxtФайлToolStripMenuItem;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private ToolStripMenuItem изменитьРазмерToolStripMenuItem;
        private ToolStripMenuItem изменитьШрифтToolStripMenuItem;
        private ToolStripMenuItem экспортироватьВtxtФайлToolStripMenuItem;
        private ToolStripTextBox задатьШрифтToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripTextBox toolStripMenuItem11;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private ToolStripMenuItem arialToolStripMenuItem;

        //

        //

        private FontDialog fontDialog1;
        private ToolStripMenuItem импортирватьШрифтToolStripMenuItem;



        private ToolStripMenuItem кодировкаToolStripMenuItem;
        private ToolStripMenuItem aSCIIToolStripMenuItem;
        private ToolStripMenuItem стандартнаКодировкаToolStripMenuItem;
        private ToolStripMenuItem uTF32ToolStripMenuItem;
        private ToolStripMenuItem отменаToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
    }
}