namespace Mini_Project
{
    partial class InfoHotelPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoHotelPerson));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TBClose = new System.Windows.Forms.PictureBox();
            this.PActivity = new System.Windows.Forms.Panel();
            this.CBCategory2 = new System.Windows.Forms.ComboBox();
            this.BReginfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.BRegpay = new System.Windows.Forms.Button();
            this.BCountPople = new System.Windows.Forms.Button();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.BSumcategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).BeginInit();
            this.PActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TBClose
            // 
            this.TBClose.Image = ((System.Drawing.Image)(resources.GetObject("TBClose.Image")));
            this.TBClose.Location = new System.Drawing.Point(750, 1);
            this.TBClose.Name = "TBClose";
            this.TBClose.Size = new System.Drawing.Size(66, 17);
            this.TBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TBClose.TabIndex = 5;
            this.TBClose.TabStop = false;
            this.TBClose.Click += new System.EventHandler(this.TBClose_Click);
            // 
            // PActivity
            // 
            this.PActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PActivity.Controls.Add(this.CBCategory2);
            this.PActivity.Controls.Add(this.BReginfo);
            this.PActivity.Controls.Add(this.label3);
            this.PActivity.Controls.Add(this.label1);
            this.PActivity.Controls.Add(this.dateTimePickerEnd);
            this.PActivity.Controls.Add(this.dateTimePickerStart);
            this.PActivity.Controls.Add(this.BRegpay);
            this.PActivity.Controls.Add(this.BCountPople);
            this.PActivity.Controls.Add(this.CBCategory);
            this.PActivity.Controls.Add(this.BSumcategory);
            this.PActivity.Controls.Add(this.label2);
            this.PActivity.Controls.Add(this.dataGridView);
            this.PActivity.Location = new System.Drawing.Point(-1, 21);
            this.PActivity.Name = "PActivity";
            this.PActivity.Size = new System.Drawing.Size(803, 598);
            this.PActivity.TabIndex = 4;
            // 
            // CBCategory2
            // 
            this.CBCategory2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CBCategory2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCategory2.ForeColor = System.Drawing.Color.White;
            this.CBCategory2.FormattingEnabled = true;
            this.CBCategory2.Location = new System.Drawing.Point(585, 214);
            this.CBCategory2.Name = "CBCategory2";
            this.CBCategory2.Size = new System.Drawing.Size(174, 27);
            this.CBCategory2.TabIndex = 28;
            // 
            // BReginfo
            // 
            this.BReginfo.BackColor = System.Drawing.Color.Transparent;
            this.BReginfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BReginfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReginfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BReginfo.ForeColor = System.Drawing.Color.White;
            this.BReginfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BReginfo.Location = new System.Drawing.Point(13, 214);
            this.BReginfo.Name = "BReginfo";
            this.BReginfo.Size = new System.Drawing.Size(553, 27);
            this.BReginfo.TabIndex = 27;
            this.BReginfo.Text = "Информация о регистрации и оплате по дате и категории";
            this.BReginfo.UseVisualStyleBackColor = false;
            this.BReginfo.Click += new System.EventHandler(this.BReginfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "ДО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "C";
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
            this.dateTimePickerEnd.Location = new System.Drawing.Point(392, 148);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerEnd.TabIndex = 24;
            this.dateTimePickerEnd.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
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
            this.dateTimePickerStart.Location = new System.Drawing.Point(77, 148);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerStart.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerStart.TabIndex = 23;
            this.dateTimePickerStart.Value = new System.DateTime(2020, 3, 23, 0, 0, 0, 0);
            // 
            // BRegpay
            // 
            this.BRegpay.BackColor = System.Drawing.Color.Transparent;
            this.BRegpay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BRegpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRegpay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRegpay.ForeColor = System.Drawing.Color.White;
            this.BRegpay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BRegpay.Location = new System.Drawing.Point(13, 181);
            this.BRegpay.Name = "BRegpay";
            this.BRegpay.Size = new System.Drawing.Size(553, 27);
            this.BRegpay.TabIndex = 22;
            this.BRegpay.Text = "Информация о регистрации и оплате по дате";
            this.BRegpay.UseVisualStyleBackColor = false;
            this.BRegpay.Click += new System.EventHandler(this.BRegpay_Click);
            // 
            // BCountPople
            // 
            this.BCountPople.BackColor = System.Drawing.Color.Transparent;
            this.BCountPople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BCountPople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCountPople.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCountPople.ForeColor = System.Drawing.Color.White;
            this.BCountPople.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BCountPople.Location = new System.Drawing.Point(13, 100);
            this.BCountPople.Name = "BCountPople";
            this.BCountPople.Size = new System.Drawing.Size(553, 27);
            this.BCountPople.TabIndex = 21;
            this.BCountPople.Text = "Вывод регистрации пользователей и номеров";
            this.BCountPople.UseVisualStyleBackColor = false;
            this.BCountPople.Click += new System.EventHandler(this.BCountPople_Click);
            // 
            // CBCategory
            // 
            this.CBCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CBCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCategory.ForeColor = System.Drawing.Color.White;
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(585, 67);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(174, 27);
            this.CBCategory.TabIndex = 20;
            // 
            // BSumcategory
            // 
            this.BSumcategory.BackColor = System.Drawing.Color.Transparent;
            this.BSumcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BSumcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSumcategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSumcategory.ForeColor = System.Drawing.Color.White;
            this.BSumcategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BSumcategory.Location = new System.Drawing.Point(13, 67);
            this.BSumcategory.Name = "BSumcategory";
            this.BSumcategory.Size = new System.Drawing.Size(553, 27);
            this.BSumcategory.TabIndex = 6;
            this.BSumcategory.Text = "Кол-во зарегистрированых номеров по категориям";
            this.BSumcategory.UseVisualStyleBackColor = false;
            this.BSumcategory.Click += new System.EventHandler(this.BSumcategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Информация об отеле";
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
            this.dataGridView.Location = new System.Drawing.Point(0, 271);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.dataGridView.Size = new System.Drawing.Size(803, 324);
            this.dataGridView.TabIndex = 0;
            // 
            // InfoHotelPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.TBClose);
            this.Controls.Add(this.PActivity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoHotelPerson";
            this.Text = "InfoHotelPerson";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfoHotelPerson_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).EndInit();
            this.PActivity.ResumeLayout(false);
            this.PActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TBClose;
        private System.Windows.Forms.Panel PActivity;
        private System.Windows.Forms.ComboBox CBCategory2;
        private System.Windows.Forms.Button BReginfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button BRegpay;
        private System.Windows.Forms.Button BCountPople;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Button BSumcategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}