namespace tx_template_styles
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            textControl1 = new TXTextControl.TextControl();
            ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
            ribbonFormattingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
            rulerBar2 = new TXTextControl.RulerBar();
            statusBar1 = new TXTextControl.StatusBar();
            rulerBar1 = new TXTextControl.RulerBar();
            panel1 = new Panel();
            label1 = new Label();
            textControl2 = new TXTextControl.TextControl();
            ribbon2 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
            ribbonFormattingTab2 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
            rulerBar4 = new TXTextControl.RulerBar();
            statusBar2 = new TXTextControl.StatusBar();
            rulerBar3 = new TXTextControl.RulerBar();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ribbon1.SuspendLayout();
            panel1.SuspendLayout();
            ribbon2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textControl1);
            splitContainer1.Panel1.Controls.Add(rulerBar1);
            splitContainer1.Panel1.Controls.Add(rulerBar2);
            splitContainer1.Panel1.Controls.Add(statusBar1);
            splitContainer1.Panel1.Controls.Add(ribbon1);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textControl2);
            splitContainer1.Panel2.Controls.Add(rulerBar3);
            splitContainer1.Panel2.Controls.Add(rulerBar4);
            splitContainer1.Panel2.Controls.Add(statusBar2);
            splitContainer1.Panel2.Controls.Add(ribbon2);
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1016, 621);
            splitContainer1.SplitterDistance = 521;
            splitContainer1.TabIndex = 0;
            // 
            // textControl1
            // 
            textControl1.DisplayColors.DarkShadowColor = Color.FromArgb(217, 217, 217);
            textControl1.DisplayColors.LightShadowColor = Color.FromArgb(217, 217, 217);
            textControl1.Dock = DockStyle.Fill;
            textControl1.Font = new Font("Arial", 10F);
            textControl1.FormattingPrinter = "Standard";
            textControl1.Location = new Point(25, 189);
            textControl1.Name = "textControl1";
            textControl1.Ribbon = ribbon1;
            textControl1.RulerBar = rulerBar2;
            textControl1.Size = new Size(496, 410);
            textControl1.StatusBar = statusBar1;
            textControl1.TabIndex = 1;
            textControl1.UserNames = null;
            textControl1.VerticalRulerBar = rulerBar1;
            // 
            // ribbon1
            // 
            ribbon1.Controls.Add(ribbonFormattingTab1);
            ribbon1.Dock = DockStyle.Top;
            ribbon1.Font = new Font("Segoe UI", 9F);
            ribbon1.HasApplicationMenu = false;
            ribbon1.HotTrack = true;
            ribbon1.Location = new Point(0, 46);
            ribbon1.Name = "ribbon1";
            ribbon1.SelectedIndex = 0;
            ribbon1.Size = new Size(521, 118);
            ribbon1.TabIndex = 2;
            ribbon1.Text = "ribbon1";
            // 
            // ribbonFormattingTab1
            // 
            ribbonFormattingTab1.Location = new Point(4, 24);
            ribbonFormattingTab1.Name = "ribbonFormattingTab1";
            ribbonFormattingTab1.Size = new Size(513, 90);
            ribbonFormattingTab1.TabIndex = 1;
            // 
            // rulerBar2
            // 
            rulerBar2.Dock = DockStyle.Top;
            rulerBar2.Location = new Point(0, 164);
            rulerBar2.Name = "rulerBar2";
            rulerBar2.Size = new Size(521, 25);
            rulerBar2.TabIndex = 5;
            rulerBar2.Text = "rulerBar2";
            // 
            // statusBar1
            // 
            statusBar1.BackColor = SystemColors.Control;
            statusBar1.Dock = DockStyle.Bottom;
            statusBar1.Font = new Font("Segoe UI", 9F);
            statusBar1.Location = new Point(0, 599);
            statusBar1.Name = "statusBar1";
            statusBar1.Size = new Size(521, 22);
            statusBar1.TabIndex = 3;
            // 
            // rulerBar1
            // 
            rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
            rulerBar1.Dock = DockStyle.Left;
            rulerBar1.Location = new Point(0, 189);
            rulerBar1.Name = "rulerBar1";
            rulerBar1.Size = new Size(25, 410);
            rulerBar1.TabIndex = 4;
            rulerBar1.Text = "rulerBar1";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Document (DOCX)";
            // 
            // textControl2
            // 
            textControl2.DisplayColors.DarkShadowColor = Color.FromArgb(217, 217, 217);
            textControl2.DisplayColors.LightShadowColor = Color.FromArgb(217, 217, 217);
            textControl2.Dock = DockStyle.Fill;
            textControl2.Font = new Font("Arial", 10F);
            textControl2.FormattingPrinter = "Standard";
            textControl2.Location = new Point(25, 189);
            textControl2.Name = "textControl2";
            textControl2.Ribbon = ribbon2;
            textControl2.RulerBar = rulerBar4;
            textControl2.Size = new Size(466, 410);
            textControl2.StatusBar = statusBar2;
            textControl2.TabIndex = 1;
            textControl2.UserNames = null;
            textControl2.VerticalRulerBar = rulerBar3;
            // 
            // ribbon2
            // 
            ribbon2.Controls.Add(ribbonFormattingTab2);
            ribbon2.Dock = DockStyle.Top;
            ribbon2.Font = new Font("Segoe UI", 9F);
            ribbon2.HasApplicationMenu = false;
            ribbon2.HotTrack = true;
            ribbon2.Location = new Point(0, 46);
            ribbon2.Name = "ribbon2";
            ribbon2.SelectedIndex = 0;
            ribbon2.Size = new Size(491, 118);
            ribbon2.TabIndex = 2;
            ribbon2.Text = "ribbon2";
            // 
            // ribbonFormattingTab2
            // 
            ribbonFormattingTab2.Location = new Point(4, 24);
            ribbonFormattingTab2.Name = "ribbonFormattingTab2";
            ribbonFormattingTab2.Size = new Size(483, 90);
            ribbonFormattingTab2.TabIndex = 1;
            // 
            // rulerBar4
            // 
            rulerBar4.Dock = DockStyle.Top;
            rulerBar4.Location = new Point(0, 164);
            rulerBar4.Name = "rulerBar4";
            rulerBar4.Size = new Size(491, 25);
            rulerBar4.TabIndex = 6;
            rulerBar4.Text = "rulerBar4";
            // 
            // statusBar2
            // 
            statusBar2.BackColor = SystemColors.Control;
            statusBar2.Dock = DockStyle.Bottom;
            statusBar2.Font = new Font("Segoe UI", 9F);
            statusBar2.Location = new Point(0, 599);
            statusBar2.Name = "statusBar2";
            statusBar2.Size = new Size(491, 22);
            statusBar2.TabIndex = 4;
            // 
            // rulerBar3
            // 
            rulerBar3.Alignment = TXTextControl.RulerBarAlignment.Left;
            rulerBar3.Dock = DockStyle.Left;
            rulerBar3.Location = new Point(0, 189);
            rulerBar3.Name = "rulerBar3";
            rulerBar3.Size = new Size(25, 410);
            rulerBar3.TabIndex = 5;
            rulerBar3.Text = "rulerBar3";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 46);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(10, 9);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 1;
            label2.Text = "Template (DOTX)";
            // 
            // button1
            // 
            button1.Location = new Point(194, 10);
            button1.Name = "button1";
            button1.Size = new Size(119, 25);
            button1.TabIndex = 1;
            button1.Text = "Apply Template";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 621);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Working with Stylesheet Template ";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ribbon1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ribbon2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TXTextControl.TextControl textControl1;
        private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar1;
        private Panel panel1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab ribbonFormattingTab1;
        private TXTextControl.TextControl textControl2;
        private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon2;
        private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab ribbonFormattingTab2;
        private TXTextControl.RulerBar rulerBar4;
        private TXTextControl.StatusBar statusBar2;
        private TXTextControl.RulerBar rulerBar3;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
