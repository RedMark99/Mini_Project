namespace Mini_Project
{
    partial class EditReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReg));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.TBHeadname = new System.Windows.Forms.Label();
            this.dataGridViewNomer = new System.Windows.Forms.DataGridView();
            this.CBDesclive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dateTimePickerEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.DarkOrange;
            this.dateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.PapayaWhip;
            this.dateTimePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.OliveDrab;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(197, 73);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerEnd.TabIndex = 26;
            this.dateTimePickerEnd.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStart.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dateTimePickerStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.DarkOrange;
            this.dateTimePickerStart.CalendarTitleForeColor = System.Drawing.Color.PapayaWhip;
            this.dateTimePickerStart.CalendarTrailingForeColor = System.Drawing.Color.OliveDrab;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 73);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerStart.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerStart.TabIndex = 25;
            this.dateTimePickerStart.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(798, 9);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(34, 14);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 24;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // BAdd
            // 
            this.BAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.ForeColor = System.Drawing.Color.White;
            this.BAdd.Location = new System.Drawing.Point(606, 72);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(212, 27);
            this.BAdd.TabIndex = 23;
            this.BAdd.Text = "Редактировать";
            this.BAdd.UseVisualStyleBackColor = true;
            // 
            // TBHeadname
            // 
            this.TBHeadname.AutoSize = true;
            this.TBHeadname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHeadname.ForeColor = System.Drawing.Color.White;
            this.TBHeadname.Location = new System.Drawing.Point(12, 9);
            this.TBHeadname.Name = "TBHeadname";
            this.TBHeadname.Size = new System.Drawing.Size(332, 25);
            this.TBHeadname.TabIndex = 21;
            this.TBHeadname.Text = "Регистрация клиента в номер";
            // 
            // dataGridViewNomer
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewNomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridViewNomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewNomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridViewNomer.Location = new System.Drawing.Point(12, 125);
            this.dataGridViewNomer.Name = "dataGridViewNomer";
            this.dataGridViewNomer.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomer.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewNomer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dataGridViewNomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewNomer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewNomer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewNomer.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewNomer.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomer.Size = new System.Drawing.Size(837, 324);
            this.dataGridViewNomer.TabIndex = 20;
            this.dataGridViewNomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNomer_CellClick);
            // 
            // CBDesclive
            // 
            this.CBDesclive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CBDesclive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBDesclive.ForeColor = System.Drawing.Color.White;
            this.CBDesclive.FormattingEnabled = true;
            this.CBDesclive.Location = new System.Drawing.Point(377, 72);
            this.CBDesclive.Name = "CBDesclive";
            this.CBDesclive.Size = new System.Drawing.Size(174, 27);
            this.CBDesclive.TabIndex = 27;
            // 
            // EditReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(851, 451);
            this.Controls.Add(this.CBDesclive);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.PBClose);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TBHeadname);
            this.Controls.Add(this.dataGridViewNomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 9);
            this.Name = "EditReg";
            this.Text = "EditReg";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditReg_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label TBHeadname;
        internal System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        internal System.Windows.Forms.DateTimePicker dateTimePickerStart;
        internal System.Windows.Forms.DataGridView dataGridViewNomer;
        internal System.Windows.Forms.ComboBox CBDesclive;
    }
}