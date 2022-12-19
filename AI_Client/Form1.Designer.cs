namespace AI_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.연산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsharpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.평균필터사용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가우시안필터사용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.threashHoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(56, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 263);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일열기ToolStripMenuItem,
            this.연산ToolStripMenuItem,
            this.histoToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.edgeToolStripMenuItem,
            this.threashHoldToolStripMenuItem,
            this.morphologyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일열기ToolStripMenuItem
            // 
            this.파일열기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.파일열기ToolStripMenuItem.Name = "파일열기ToolStripMenuItem";
            this.파일열기ToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.파일열기ToolStripMenuItem.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.fileToolStripMenuItem.Text = "Open";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // 연산ToolStripMenuItem
            // 
            this.연산ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.subToolStripMenuItem,
            this.mulToolStripMenuItem,
            this.divToolStripMenuItem});
            this.연산ToolStripMenuItem.Name = "연산ToolStripMenuItem";
            this.연산ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.연산ToolStripMenuItem.Text = "연산";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // subToolStripMenuItem
            // 
            this.subToolStripMenuItem.Name = "subToolStripMenuItem";
            this.subToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.subToolStripMenuItem.Text = "Sub";
            this.subToolStripMenuItem.Click += new System.EventHandler(this.subToolStripMenuItem_Click);
            // 
            // mulToolStripMenuItem
            // 
            this.mulToolStripMenuItem.Name = "mulToolStripMenuItem";
            this.mulToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.mulToolStripMenuItem.Text = "Mul";
            this.mulToolStripMenuItem.Click += new System.EventHandler(this.mulToolStripMenuItem_Click);
            // 
            // divToolStripMenuItem
            // 
            this.divToolStripMenuItem.Name = "divToolStripMenuItem";
            this.divToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.divToolStripMenuItem.Text = "Div";
            this.divToolStripMenuItem.Click += new System.EventHandler(this.divToolStripMenuItem_Click);
            // 
            // histoToolStripMenuItem
            // 
            this.histoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equalToolStripMenuItem,
            this.viewHistToolStripMenuItem});
            this.histoToolStripMenuItem.Name = "histoToolStripMenuItem";
            this.histoToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.histoToolStripMenuItem.Text = "Histo";
            // 
            // equalToolStripMenuItem
            // 
            this.equalToolStripMenuItem.Name = "equalToolStripMenuItem";
            this.equalToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.equalToolStripMenuItem.Text = "Equal";
            this.equalToolStripMenuItem.Click += new System.EventHandler(this.equalToolStripMenuItem_Click);
            // 
            // viewHistToolStripMenuItem
            // 
            this.viewHistToolStripMenuItem.Name = "viewHistToolStripMenuItem";
            this.viewHistToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.viewHistToolStripMenuItem.Text = "View_Hist";
            this.viewHistToolStripMenuItem.Click += new System.EventHandler(this.viewHistToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianToolStripMenuItem,
            this.meddToolStripMenuItem,
            this.unsharpToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gaussianToolStripMenuItem.Text = "Gaussian";
            this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);
            // 
            // meddToolStripMenuItem
            // 
            this.meddToolStripMenuItem.Name = "meddToolStripMenuItem";
            this.meddToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.meddToolStripMenuItem.Text = "Median";
            this.meddToolStripMenuItem.Click += new System.EventHandler(this.meddToolStripMenuItem_Click);
            // 
            // unsharpToolStripMenuItem
            // 
            this.unsharpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.평균필터사용ToolStripMenuItem,
            this.가우시안필터사용ToolStripMenuItem});
            this.unsharpToolStripMenuItem.Name = "unsharpToolStripMenuItem";
            this.unsharpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.unsharpToolStripMenuItem.Text = "Unsharp";
            // 
            // 평균필터사용ToolStripMenuItem
            // 
            this.평균필터사용ToolStripMenuItem.Name = "평균필터사용ToolStripMenuItem";
            this.평균필터사용ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.평균필터사용ToolStripMenuItem.Text = "평균필터";
            this.평균필터사용ToolStripMenuItem.Click += new System.EventHandler(this.평균필터사용ToolStripMenuItem_Click);
            // 
            // 가우시안필터사용ToolStripMenuItem
            // 
            this.가우시안필터사용ToolStripMenuItem.Name = "가우시안필터사용ToolStripMenuItem";
            this.가우시안필터사용ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.가우시안필터사용ToolStripMenuItem.Text = "가우시안필터";
            this.가우시안필터사용ToolStripMenuItem.Click += new System.EventHandler(this.가우시안필터사용ToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem,
            this.cannyToolStripMenuItem});
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.edgeToolStripMenuItem.Text = "Edge";
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(403, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(467, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 385);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(539, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 359);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "속성";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(72, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 32);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(19, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 32);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "갱신";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "YCrCb",
            "Gray",
            "RGB"});
            this.comboBox1.Location = new System.Drawing.Point(19, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // threashHoldToolStripMenuItem
            // 
            this.threashHoldToolStripMenuItem.Name = "threashHoldToolStripMenuItem";
            this.threashHoldToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.threashHoldToolStripMenuItem.Text = "Threshold";
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일열기ToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Button button1;
        private Button button2;
        public PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button5;
        private Button button4;
        private ToolStripMenuItem 연산ToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem subToolStripMenuItem;
        private ToolStripMenuItem histoToolStripMenuItem;
        private ToolStripMenuItem equalToolStripMenuItem;
        private ToolStripMenuItem mulToolStripMenuItem;
        private ToolStripMenuItem divToolStripMenuItem;
        private ToolStripMenuItem viewHistToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem gaussianToolStripMenuItem;
        private ToolStripMenuItem meddToolStripMenuItem;
        private ToolStripMenuItem unsharpToolStripMenuItem;
        private ToolStripMenuItem edgeToolStripMenuItem;
        private ToolStripMenuItem sobelToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
        private ToolStripMenuItem cannyToolStripMenuItem;
        private ToolStripMenuItem 평균필터사용ToolStripMenuItem;
        private ToolStripMenuItem 가우시안필터사용ToolStripMenuItem;
        private ToolStripMenuItem threashHoldToolStripMenuItem;
        private ToolStripMenuItem morphologyToolStripMenuItem;
    }
}