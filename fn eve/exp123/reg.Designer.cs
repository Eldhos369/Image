namespace exp123
{
    partial class reg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg));
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.propic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.ComboBox();
            this.br = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.ids = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.namer = new System.Windows.Forms.Label();
            this.secr = new System.Windows.Forms.Label();
            this.dobr = new System.Windows.Forms.Label();
            this.pror = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pror)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(172, 79);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(178, 20);
            this.id.TabIndex = 1;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(307, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(172, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(178, 20);
            this.name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sec";
            // 
            // propic
            // 
            this.propic.Location = new System.Drawing.Point(172, 203);
            this.propic.Name = "propic";
            this.propic.Size = new System.Drawing.Size(144, 20);
            this.propic.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Profile pic";
            // 
            // sec
            // 
            this.sec.FormattingEnabled = true;
            this.sec.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.sec.Location = new System.Drawing.Point(172, 158);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(41, 21);
            this.sec.TabIndex = 9;
            // 
            // br
            // 
            this.br.FormattingEnabled = true;
            this.br.Items.AddRange(new object[] {
            "ECE",
            "EEE",
            "CSE",
            "PEE",
            "CVE"});
            this.br.Location = new System.Drawing.Point(308, 158);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(41, 21);
            this.br.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Branch";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sel
            // 
            this.sel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sel.Location = new System.Drawing.Point(322, 201);
            this.sel.Name = "sel";
            this.sel.Size = new System.Drawing.Size(58, 23);
            this.sel.TabIndex = 12;
            this.sel.Text = "choose";
            this.sel.UseVisualStyleBackColor = true;
            this.sel.Click += new System.EventHandler(this.sel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DOB";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(172, 245);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(178, 20);
            this.dob.TabIndex = 14;
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(516, 77);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(116, 20);
            this.ids.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Student ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(638, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 20);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Section";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "DOB";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.pror);
            this.gb.Controls.Add(this.dobr);
            this.gb.Controls.Add(this.secr);
            this.gb.Controls.Add(this.namer);
            this.gb.Controls.Add(this.label10);
            this.gb.Controls.Add(this.label8);
            this.gb.Controls.Add(this.label9);
            this.gb.Location = new System.Drawing.Point(450, 105);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(336, 200);
            this.gb.TabIndex = 25;
            this.gb.TabStop = false;
            this.gb.Text = "gb";
            // 
            // namer
            // 
            this.namer.AutoSize = true;
            this.namer.Location = new System.Drawing.Point(68, 34);
            this.namer.Name = "namer";
            this.namer.Size = new System.Drawing.Size(35, 13);
            this.namer.TabIndex = 25;
            this.namer.Text = "Name";
            // 
            // secr
            // 
            this.secr.AutoSize = true;
            this.secr.Location = new System.Drawing.Point(68, 70);
            this.secr.Name = "secr";
            this.secr.Size = new System.Drawing.Size(24, 13);
            this.secr.TabIndex = 26;
            this.secr.Text = "sec";
            // 
            // dobr
            // 
            this.dobr.AutoSize = true;
            this.dobr.Location = new System.Drawing.Point(68, 102);
            this.dobr.Name = "dobr";
            this.dobr.Size = new System.Drawing.Size(25, 13);
            this.dobr.TabIndex = 27;
            this.dobr.Text = "dob";
            // 
            // pror
            // 
            this.pror.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pror.Location = new System.Drawing.Point(179, 18);
            this.pror.Name = "pror";
            this.pror.Size = new System.Drawing.Size(143, 170);
            this.pror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pror.TabIndex = 28;
            this.pror.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(242, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 32);
            this.button3.TabIndex = 26;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(732, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 26);
            this.button4.TabIndex = 27;
            this.button4.Text = "Log out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ids);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sel);
            this.Controls.Add(this.br);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.propic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "reg";
            this.Text = "reg";
            this.Load += new System.EventHandler(this.reg_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox propic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sec;
        private System.Windows.Forms.ComboBox br;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label namer;
        private System.Windows.Forms.Label dobr;
        private System.Windows.Forms.Label secr;
        private System.Windows.Forms.PictureBox pror;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}