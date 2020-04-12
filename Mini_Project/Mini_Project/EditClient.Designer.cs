namespace Mini_Project
{
    partial class EditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClient));
            this.LDataOfBirth = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.TBDeschotel = new System.Windows.Forms.TextBox();
            this.TBNumerpassport = new System.Windows.Forms.TextBox();
            this.TBSeriapassport = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBLastname = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TBHeadname = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // LDataOfBirth
            // 
            this.LDataOfBirth.AutoSize = true;
            this.LDataOfBirth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDataOfBirth.ForeColor = System.Drawing.Color.White;
            this.LDataOfBirth.Location = new System.Drawing.Point(61, 298);
            this.LDataOfBirth.Name = "LDataOfBirth";
            this.LDataOfBirth.Size = new System.Drawing.Size(136, 19);
            this.LDataOfBirth.TabIndex = 34;
            this.LDataOfBirth.Text = "Дата рождения";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateOfBirth.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dateTimePickerDateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dateTimePickerDateOfBirth.CalendarTitleBackColor = System.Drawing.Color.DarkOrange;
            this.dateTimePickerDateOfBirth.CalendarTitleForeColor = System.Drawing.Color.PapayaWhip;
            this.dateTimePickerDateOfBirth.CalendarTrailingForeColor = System.Drawing.Color.OliveDrab;
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(9, 324);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(240, 27);
            this.dateTimePickerDateOfBirth.TabIndex = 33;
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(215, 9);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(34, 17);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 32;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // TBDeschotel
            // 
            this.TBDeschotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBDeschotel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDeschotel.ForeColor = System.Drawing.Color.White;
            this.TBDeschotel.Location = new System.Drawing.Point(9, 361);
            this.TBDeschotel.Multiline = true;
            this.TBDeschotel.Name = "TBDeschotel";
            this.TBDeschotel.Size = new System.Drawing.Size(241, 176);
            this.TBDeschotel.TabIndex = 31;
            // 
            // TBNumerpassport
            // 
            this.TBNumerpassport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBNumerpassport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBNumerpassport.ForeColor = System.Drawing.Color.White;
            this.TBNumerpassport.Location = new System.Drawing.Point(9, 264);
            this.TBNumerpassport.MaxLength = 6;
            this.TBNumerpassport.Name = "TBNumerpassport";
            this.TBNumerpassport.Size = new System.Drawing.Size(241, 27);
            this.TBNumerpassport.TabIndex = 30;
            // 
            // TBSeriapassport
            // 
            this.TBSeriapassport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBSeriapassport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSeriapassport.ForeColor = System.Drawing.Color.White;
            this.TBSeriapassport.Location = new System.Drawing.Point(9, 231);
            this.TBSeriapassport.MaxLength = 4;
            this.TBSeriapassport.Name = "TBSeriapassport";
            this.TBSeriapassport.Size = new System.Drawing.Size(241, 27);
            this.TBSeriapassport.TabIndex = 29;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(9, 198);
            this.TBPassword.MaxLength = 16;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(241, 27);
            this.TBPassword.TabIndex = 28;
            // 
            // TBLogin
            // 
            this.TBLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLogin.ForeColor = System.Drawing.Color.White;
            this.TBLogin.Location = new System.Drawing.Point(9, 165);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(241, 27);
            this.TBLogin.TabIndex = 27;
            // 
            // TBLastname
            // 
            this.TBLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLastname.ForeColor = System.Drawing.Color.White;
            this.TBLastname.Location = new System.Drawing.Point(9, 132);
            this.TBLastname.Name = "TBLastname";
            this.TBLastname.Size = new System.Drawing.Size(241, 27);
            this.TBLastname.TabIndex = 26;
            // 
            // TBSurname
            // 
            this.TBSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSurname.ForeColor = System.Drawing.Color.White;
            this.TBSurname.Location = new System.Drawing.Point(9, 99);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(241, 27);
            this.TBSurname.TabIndex = 25;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(8, 544);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(241, 39);
            this.ButtonAdd.TabIndex = 22;
            this.ButtonAdd.Text = "Редактировать";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            // 
            // TBHeadname
            // 
            this.TBHeadname.AutoSize = true;
            this.TBHeadname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHeadname.ForeColor = System.Drawing.Color.White;
            this.TBHeadname.Location = new System.Drawing.Point(10, 31);
            this.TBHeadname.Name = "TBHeadname";
            this.TBHeadname.Size = new System.Drawing.Size(191, 25);
            this.TBHeadname.TabIndex = 24;
            this.TBHeadname.Text = "Редактирование\r\n";
            // 
            // TBName
            // 
            this.TBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.ForeColor = System.Drawing.Color.White;
            this.TBName.Location = new System.Drawing.Point(9, 66);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(241, 27);
            this.TBName.TabIndex = 23;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(260, 592);
            this.Controls.Add(this.LDataOfBirth);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.PBClose);
            this.Controls.Add(this.TBDeschotel);
            this.Controls.Add(this.TBNumerpassport);
            this.Controls.Add(this.TBSeriapassport);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.TBLastname);
            this.Controls.Add(this.TBSurname);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TBHeadname);
            this.Controls.Add(this.TBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditClient";
            this.Text = "EditClient";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditClient_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDataOfBirth;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label TBHeadname;
        internal System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        internal System.Windows.Forms.TextBox TBDeschotel;
        internal System.Windows.Forms.TextBox TBNumerpassport;
        internal System.Windows.Forms.TextBox TBSeriapassport;
        internal System.Windows.Forms.TextBox TBPassword;
        internal System.Windows.Forms.TextBox TBLogin;
        internal System.Windows.Forms.TextBox TBLastname;
        internal System.Windows.Forms.TextBox TBSurname;
        internal System.Windows.Forms.TextBox TBName;
    }
}