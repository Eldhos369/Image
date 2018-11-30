namespace exp11
{
    partial class view
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
            this.components = new System.ComponentModel.Container();
            this.pb = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.TextBox();
            this.get = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new exp11.Database1DataSet();
            this.imgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imgeTableAdapter = new exp11.Database1DataSetTableAdapters.imgeTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(255, 74);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(145, 167);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(53, 74);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 1;
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(122, 101);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(75, 23);
            this.get.TabIndex = 2;
            this.get.Text = "Get";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.imgeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(218, 120);
            this.dataGridView1.TabIndex = 3;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imgeBindingSource
            // 
            this.imgeBindingSource.DataMember = "imge";
            this.imgeBindingSource.DataSource = this.database1DataSet;
            // 
            // imgeTableAdapter
            // 
            this.imgeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(13, 101);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(75, 23);
            this.DEL.TabIndex = 4;
            this.DEL.Text = "dEL";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 283);
            this.Controls.Add(this.DEL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.get);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pb);
            this.Name = "view";
            this.Text = "view";
            this.Load += new System.EventHandler(this.view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource imgeBindingSource;
        private Database1DataSetTableAdapters.imgeTableAdapter imgeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Button DEL;
    }
}