namespace exp11
{
    partial class Form1
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
            this.save = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.sel = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(393, 151);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "Save img";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.sub_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(188, 113);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "label1";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(229, 106);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(145, 20);
            this.tb.TabIndex = 2;
            // 
            // sel
            // 
            this.sel.Location = new System.Drawing.Point(393, 103);
            this.sel.Name = "sel";
            this.sel.Size = new System.Drawing.Size(75, 23);
            this.sel.TabIndex = 3;
            this.sel.Text = "select";
            this.sel.UseVisualStyleBackColor = true;
            this.sel.Click += new System.EventHandler(this.sel_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(229, 80);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(145, 20);
            this.id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.sel);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.name);
            this.Controls.Add(this.save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button sel;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

