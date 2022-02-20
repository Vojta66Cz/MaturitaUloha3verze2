namespace MaturitaUloha3verze2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.but = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.controlx = new System.Windows.Forms.TextBox();
            this.controly = new System.Windows.Forms.TextBox();
            this.frekvence1 = new System.Windows.Forms.TrackBar();
            this.frekvence2 = new System.Windows.Forms.TrackBar();
            this.amplituda1 = new System.Windows.Forms.TrackBar();
            this.amplituda2 = new System.Windows.Forms.TrackBar();
            this.fazpos1 = new System.Windows.Forms.TrackBar();
            this.fazpos2 = new System.Windows.Forms.TrackBar();
            this.frekbox1 = new System.Windows.Forms.TextBox();
            this.frekbox2 = new System.Windows.Forms.TextBox();
            this.ampbox1 = new System.Windows.Forms.TextBox();
            this.fazbox2 = new System.Windows.Forms.TextBox();
            this.fazbox1 = new System.Windows.Forms.TextBox();
            this.ampbox2 = new System.Windows.Forms.TextBox();
            this.Vypnout = new System.Windows.Forms.Button();
            this.ukazatel1 = new System.Windows.Forms.TextBox();
            this.ukazatel2 = new System.Windows.Forms.TextBox();
            this.ukazatel3 = new System.Windows.Forms.TextBox();
            this.ukazatel4 = new System.Windows.Forms.TextBox();
            this.ukazatel6 = new System.Windows.Forms.TextBox();
            this.ukazatel5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.frekvence1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frekvence2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplituda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplituda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazpos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazpos2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(318, 272);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(90, 40);
            this.but.TabIndex = 1;
            this.but.Text = "Vykresli";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Souřadnice X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(897, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Souřadnice Y";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // controlx
            // 
            this.controlx.Location = new System.Drawing.Point(534, 172);
            this.controlx.Multiline = true;
            this.controlx.Name = "controlx";
            this.controlx.ReadOnly = true;
            this.controlx.Size = new System.Drawing.Size(90, 140);
            this.controlx.TabIndex = 4;
            this.controlx.TextChanged += new System.EventHandler(this.controlx_TextChanged);
            // 
            // controly
            // 
            this.controly.Location = new System.Drawing.Point(801, 172);
            this.controly.Multiline = true;
            this.controly.Name = "controly";
            this.controly.ReadOnly = true;
            this.controly.Size = new System.Drawing.Size(90, 140);
            this.controly.TabIndex = 5;
            this.controly.TextChanged += new System.EventHandler(this.controly_TextChanged);
            // 
            // frekvence1
            // 
            this.frekvence1.Location = new System.Drawing.Point(12, 379);
            this.frekvence1.Maximum = 18;
            this.frekvence1.Minimum = 1;
            this.frekvence1.Name = "frekvence1";
            this.frekvence1.Size = new System.Drawing.Size(250, 45);
            this.frekvence1.TabIndex = 6;
            this.frekvence1.Value = 1;
            this.frekvence1.Scroll += new System.EventHandler(this.frekvence1_Scroll);
            // 
            // frekvence2
            // 
            this.frekvence2.Location = new System.Drawing.Point(12, 451);
            this.frekvence2.Maximum = 18;
            this.frekvence2.Minimum = 1;
            this.frekvence2.Name = "frekvence2";
            this.frekvence2.Size = new System.Drawing.Size(250, 45);
            this.frekvence2.TabIndex = 7;
            this.frekvence2.Value = 1;
            this.frekvence2.Scroll += new System.EventHandler(this.frekvence2_Scroll);
            // 
            // amplituda1
            // 
            this.amplituda1.LargeChange = 10;
            this.amplituda1.Location = new System.Drawing.Point(353, 379);
            this.amplituda1.Maximum = 150;
            this.amplituda1.Minimum = 1;
            this.amplituda1.Name = "amplituda1";
            this.amplituda1.Size = new System.Drawing.Size(250, 45);
            this.amplituda1.TabIndex = 8;
            this.amplituda1.TickFrequency = 10;
            this.amplituda1.Value = 1;
            this.amplituda1.Scroll += new System.EventHandler(this.amplituda1_Scroll);
            // 
            // amplituda2
            // 
            this.amplituda2.LargeChange = 10;
            this.amplituda2.Location = new System.Drawing.Point(353, 451);
            this.amplituda2.Maximum = 150;
            this.amplituda2.Minimum = 1;
            this.amplituda2.Name = "amplituda2";
            this.amplituda2.Size = new System.Drawing.Size(250, 45);
            this.amplituda2.TabIndex = 9;
            this.amplituda2.TickFrequency = 10;
            this.amplituda2.Value = 1;
            this.amplituda2.Scroll += new System.EventHandler(this.amplituda2_Scroll);
            // 
            // fazpos1
            // 
            this.fazpos1.LargeChange = 20;
            this.fazpos1.Location = new System.Drawing.Point(688, 379);
            this.fazpos1.Maximum = 360;
            this.fazpos1.Name = "fazpos1";
            this.fazpos1.Size = new System.Drawing.Size(250, 45);
            this.fazpos1.TabIndex = 10;
            this.fazpos1.TickFrequency = 10;
            this.fazpos1.Scroll += new System.EventHandler(this.fazpos1_Scroll);
            // 
            // fazpos2
            // 
            this.fazpos2.LargeChange = 20;
            this.fazpos2.Location = new System.Drawing.Point(688, 451);
            this.fazpos2.Maximum = 360;
            this.fazpos2.Name = "fazpos2";
            this.fazpos2.Size = new System.Drawing.Size(250, 45);
            this.fazpos2.TabIndex = 11;
            this.fazpos2.TickFrequency = 10;
            this.fazpos2.Scroll += new System.EventHandler(this.fazpos2_Scroll);
            // 
            // frekbox1
            // 
            this.frekbox1.Location = new System.Drawing.Point(268, 379);
            this.frekbox1.Multiline = true;
            this.frekbox1.Name = "frekbox1";
            this.frekbox1.ReadOnly = true;
            this.frekbox1.Size = new System.Drawing.Size(50, 50);
            this.frekbox1.TabIndex = 12;
            this.frekbox1.TextChanged += new System.EventHandler(this.frekbox1_TextChanged);
            // 
            // frekbox2
            // 
            this.frekbox2.Location = new System.Drawing.Point(268, 446);
            this.frekbox2.Multiline = true;
            this.frekbox2.Name = "frekbox2";
            this.frekbox2.ReadOnly = true;
            this.frekbox2.Size = new System.Drawing.Size(50, 50);
            this.frekbox2.TabIndex = 13;
            this.frekbox2.TextChanged += new System.EventHandler(this.frekbox2_TextChanged);
            // 
            // ampbox1
            // 
            this.ampbox1.Location = new System.Drawing.Point(609, 379);
            this.ampbox1.Multiline = true;
            this.ampbox1.Name = "ampbox1";
            this.ampbox1.ReadOnly = true;
            this.ampbox1.Size = new System.Drawing.Size(50, 50);
            this.ampbox1.TabIndex = 14;
            this.ampbox1.TextChanged += new System.EventHandler(this.ampbox1_TextChanged);
            // 
            // fazbox2
            // 
            this.fazbox2.Location = new System.Drawing.Point(944, 446);
            this.fazbox2.Multiline = true;
            this.fazbox2.Name = "fazbox2";
            this.fazbox2.ReadOnly = true;
            this.fazbox2.Size = new System.Drawing.Size(50, 50);
            this.fazbox2.TabIndex = 15;
            this.fazbox2.TextChanged += new System.EventHandler(this.fazbox2_TextChanged);
            // 
            // fazbox1
            // 
            this.fazbox1.Location = new System.Drawing.Point(944, 379);
            this.fazbox1.Multiline = true;
            this.fazbox1.Name = "fazbox1";
            this.fazbox1.ReadOnly = true;
            this.fazbox1.Size = new System.Drawing.Size(50, 50);
            this.fazbox1.TabIndex = 16;
            this.fazbox1.TextChanged += new System.EventHandler(this.fazbox1_TextChanged);
            // 
            // ampbox2
            // 
            this.ampbox2.Location = new System.Drawing.Point(609, 446);
            this.ampbox2.Multiline = true;
            this.ampbox2.Name = "ampbox2";
            this.ampbox2.ReadOnly = true;
            this.ampbox2.Size = new System.Drawing.Size(50, 50);
            this.ampbox2.TabIndex = 17;
            this.ampbox2.TextChanged += new System.EventHandler(this.ampbox2_TextChanged);
            // 
            // Vypnout
            // 
            this.Vypnout.Location = new System.Drawing.Point(961, 21);
            this.Vypnout.Name = "Vypnout";
            this.Vypnout.Size = new System.Drawing.Size(60, 60);
            this.Vypnout.TabIndex = 18;
            this.Vypnout.Text = "X";
            this.Vypnout.UseVisualStyleBackColor = true;
            this.Vypnout.Click += new System.EventHandler(this.Vypnout_Click);
            // 
            // ukazatel1
            // 
            this.ukazatel1.Location = new System.Drawing.Point(12, 354);
            this.ukazatel1.Multiline = true;
            this.ukazatel1.Name = "ukazatel1";
            this.ukazatel1.ReadOnly = true;
            this.ukazatel1.Size = new System.Drawing.Size(90, 20);
            this.ukazatel1.TabIndex = 19;
            this.ukazatel1.Text = "Frekvence 1";
            this.ukazatel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ukazatel1.TextChanged += new System.EventHandler(this.ukazatel1_TextChanged);
            // 
            // ukazatel2
            // 
            this.ukazatel2.Location = new System.Drawing.Point(12, 430);
            this.ukazatel2.Multiline = true;
            this.ukazatel2.Name = "ukazatel2";
            this.ukazatel2.ReadOnly = true;
            this.ukazatel2.Size = new System.Drawing.Size(90, 20);
            this.ukazatel2.TabIndex = 20;
            this.ukazatel2.Text = "Frekvence 2";
            this.ukazatel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ukazatel2.TextChanged += new System.EventHandler(this.ukazatel2_TextChanged);
            // 
            // ukazatel3
            // 
            this.ukazatel3.Location = new System.Drawing.Point(353, 354);
            this.ukazatel3.Multiline = true;
            this.ukazatel3.Name = "ukazatel3";
            this.ukazatel3.ReadOnly = true;
            this.ukazatel3.Size = new System.Drawing.Size(90, 20);
            this.ukazatel3.TabIndex = 21;
            this.ukazatel3.Text = "Amplituda 1";
            this.ukazatel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ukazatel3.TextChanged += new System.EventHandler(this.ukazatel3_TextChanged);
            // 
            // ukazatel4
            // 
            this.ukazatel4.Location = new System.Drawing.Point(353, 426);
            this.ukazatel4.Multiline = true;
            this.ukazatel4.Name = "ukazatel4";
            this.ukazatel4.ReadOnly = true;
            this.ukazatel4.Size = new System.Drawing.Size(90, 20);
            this.ukazatel4.TabIndex = 22;
            this.ukazatel4.Text = "Amplituda 2";
            this.ukazatel4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ukazatel4.TextChanged += new System.EventHandler(this.ukazatel4_TextChanged);
            // 
            // ukazatel6
            // 
            this.ukazatel6.Location = new System.Drawing.Point(688, 426);
            this.ukazatel6.Multiline = true;
            this.ukazatel6.Name = "ukazatel6";
            this.ukazatel6.ReadOnly = true;
            this.ukazatel6.Size = new System.Drawing.Size(90, 20);
            this.ukazatel6.TabIndex = 23;
            this.ukazatel6.Text = "F. Posun 2";
            this.ukazatel6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ukazatel6.TextChanged += new System.EventHandler(this.ukazatel6_TextChanged);
            // 
            // ukazatel5
            // 
            this.ukazatel5.Location = new System.Drawing.Point(688, 354);
            this.ukazatel5.Multiline = true;
            this.ukazatel5.Name = "ukazatel5";
            this.ukazatel5.ReadOnly = true;
            this.ukazatel5.Size = new System.Drawing.Size(90, 20);
            this.ukazatel5.TabIndex = 24;
            this.ukazatel5.Text = "F. Posun 1";
            this.ukazatel5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ukazatel5.TextChanged += new System.EventHandler(this.ukazatel5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 534);
            this.Controls.Add(this.ukazatel5);
            this.Controls.Add(this.ukazatel6);
            this.Controls.Add(this.ukazatel4);
            this.Controls.Add(this.ukazatel3);
            this.Controls.Add(this.ukazatel2);
            this.Controls.Add(this.ukazatel1);
            this.Controls.Add(this.Vypnout);
            this.Controls.Add(this.ampbox2);
            this.Controls.Add(this.fazbox1);
            this.Controls.Add(this.fazbox2);
            this.Controls.Add(this.ampbox1);
            this.Controls.Add(this.frekbox2);
            this.Controls.Add(this.frekbox1);
            this.Controls.Add(this.fazpos2);
            this.Controls.Add(this.fazpos1);
            this.Controls.Add(this.amplituda2);
            this.Controls.Add(this.amplituda1);
            this.Controls.Add(this.frekvence2);
            this.Controls.Add(this.frekvence1);
            this.Controls.Add(this.controly);
            this.Controls.Add(this.controlx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frekvence1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frekvence2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplituda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplituda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazpos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazpos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button but;
        private Button button1;
        private Button button2;
        private TextBox controlx;
        private TextBox controly;
        private TrackBar frekvence1;
        private TrackBar frekvence2;
        private TrackBar amplituda1;
        private TrackBar amplituda2;
        private TrackBar fazpos1;
        private TrackBar fazpos2;
        private TextBox frekbox1;
        private TextBox frekbox2;
        private TextBox ampbox1;
        private TextBox fazbox2;
        private TextBox fazbox1;
        private TextBox ampbox2;
        private Button Vypnout;
        private TextBox ukazatel1;
        private TextBox ukazatel2;
        private TextBox ukazatel3;
        private TextBox ukazatel4;
        private TextBox ukazatel6;
        private TextBox ukazatel5;
    }
}