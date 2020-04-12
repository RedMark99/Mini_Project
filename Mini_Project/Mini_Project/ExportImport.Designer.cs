namespace Mini_Project
{
    partial class ExportImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportImport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BExportplease = new System.Windows.Forms.Button();
            this.TBCount = new System.Windows.Forms.TextBox();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.BImport = new System.Windows.Forms.Button();
            this.TBHeadname = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TBClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.BExportplease);
            this.panel1.Controls.Add(this.TBCount);
            this.panel1.Controls.Add(this.CBCategory);
            this.panel1.Controls.Add(this.BImport);
            this.panel1.Controls.Add(this.TBHeadname);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 498);
            this.panel1.TabIndex = 0;
            // 
            // BExportplease
            // 
            this.BExportplease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExportplease.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BExportplease.ForeColor = System.Drawing.Color.White;
            this.BExportplease.Location = new System.Drawing.Point(12, 363);
            this.BExportplease.Name = "BExportplease";
            this.BExportplease.Size = new System.Drawing.Size(110, 34);
            this.BExportplease.TabIndex = 18;
            this.BExportplease.Text = "Экспорт";
            this.BExportplease.UseVisualStyleBackColor = true;
            this.BExportplease.Click += new System.EventHandler(this.BExportplease_Click);
            // 
            // TBCount
            // 
            this.TBCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCount.ForeColor = System.Drawing.Color.White;
            this.TBCount.Location = new System.Drawing.Point(334, 364);
            this.TBCount.Name = "TBCount";
            this.TBCount.Size = new System.Drawing.Size(64, 33);
            this.TBCount.TabIndex = 17;
            // 
            // CBCategory
            // 
            this.CBCategory.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(144, 364);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(184, 33);
            this.CBCategory.TabIndex = 16;
            // 
            // BImport
            // 
            this.BImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BImport.ForeColor = System.Drawing.Color.White;
            this.BImport.Location = new System.Drawing.Point(12, 415);
            this.BImport.Name = "BImport";
            this.BImport.Size = new System.Drawing.Size(110, 34);
            this.BImport.TabIndex = 8;
            this.BImport.Text = "Импорт";
            this.BImport.UseVisualStyleBackColor = true;
            this.BImport.Click += new System.EventHandler(this.BImport_Click);
            // 
            // TBHeadname
            // 
            this.TBHeadname.AutoSize = true;
            this.TBHeadname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHeadname.ForeColor = System.Drawing.Color.White;
            this.TBHeadname.Location = new System.Drawing.Point(303, 16);
            this.TBHeadname.Name = "TBHeadname";
            this.TBHeadname.Size = new System.Drawing.Size(194, 25);
            this.TBHeadname.TabIndex = 12;
            this.TBHeadname.Text = "Импорт/Экспорт";
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.Size = new System.Drawing.Size(762, 273);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // TBClose
            // 
            this.TBClose.Image = ((System.Drawing.Image)(resources.GetObject("TBClose.Image")));
            this.TBClose.Location = new System.Drawing.Point(732, 2);
            this.TBClose.Name = "TBClose";
            this.TBClose.Size = new System.Drawing.Size(66, 17);
            this.TBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TBClose.TabIndex = 3;
            this.TBClose.TabStop = false;
            this.TBClose.Click += new System.EventHandler(this.TBClose_Click);
            // 
            // ExportImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 520);
            this.Controls.Add(this.TBClose);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExportImport";
            this.Text = "ExportImport";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExportImport_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BImport;
        private System.Windows.Forms.Label TBHeadname;
        private System.Windows.Forms.PictureBox TBClose;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.TextBox TBCount;
        private System.Windows.Forms.Button BExportplease;
    }
}