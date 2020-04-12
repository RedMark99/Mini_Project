namespace Mini_Project
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TBHeadname = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.TBLastname = new System.Windows.Forms.TextBox();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBSeriapassport = new System.Windows.Forms.TextBox();
            this.TBNumerpassport = new System.Windows.Forms.TextBox();
            this.TBDeschotel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.LDataOfBirth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(6, 544);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(241, 39);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TBHeadname
            // 
            this.TBHeadname.AutoSize = true;
            this.TBHeadname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHeadname.ForeColor = System.Drawing.Color.White;
            this.TBHeadname.Location = new System.Drawing.Point(10, 31);
            this.TBHeadname.Name = "TBHeadname";
            this.TBHeadname.Size = new System.Drawing.Size(235, 25);
            this.TBHeadname.TabIndex = 7;
            this.TBHeadname.Text = "Добавление клиента";
            // 
            // TBName
            // 
            this.TBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.ForeColor = System.Drawing.Color.White;
            this.TBName.Location = new System.Drawing.Point(7, 66);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(241, 27);
            this.TBName.TabIndex = 6;
            this.TBName.Enter += new System.EventHandler(this.TBName_Enter);
            this.TBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBName_KeyPress);
            this.TBName.Leave += new System.EventHandler(this.TBName_Leave);
            // 
            // TBSurname
            // 
            this.TBSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSurname.ForeColor = System.Drawing.Color.White;
            this.TBSurname.Location = new System.Drawing.Point(7, 99);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(241, 27);
            this.TBSurname.TabIndex = 8;
            this.TBSurname.Enter += new System.EventHandler(this.TBSurname_Enter);
            this.TBSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSurname_KeyPress);
            this.TBSurname.Leave += new System.EventHandler(this.TBSurname_Leave);
            // 
            // TBLastname
            // 
            this.TBLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLastname.ForeColor = System.Drawing.Color.White;
            this.TBLastname.Location = new System.Drawing.Point(7, 132);
            this.TBLastname.Name = "TBLastname";
            this.TBLastname.Size = new System.Drawing.Size(241, 27);
            this.TBLastname.TabIndex = 9;
            this.TBLastname.Enter += new System.EventHandler(this.TBLastname_Enter);
            this.TBLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLastname_KeyPress);
            this.TBLastname.Leave += new System.EventHandler(this.TBLastname_Leave);
            // 
            // TBLogin
            // 
            this.TBLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLogin.ForeColor = System.Drawing.Color.White;
            this.TBLogin.Location = new System.Drawing.Point(7, 165);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(241, 27);
            this.TBLogin.TabIndex = 10;
            this.TBLogin.Enter += new System.EventHandler(this.TBLogin_Enter);
            this.TBLogin.Leave += new System.EventHandler(this.TBLogin_Leave);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(7, 198);
            this.TBPassword.MaxLength = 16;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(241, 27);
            this.TBPassword.TabIndex = 11;
            this.TBPassword.Enter += new System.EventHandler(this.TBPassword_Enter);
            this.TBPassword.Leave += new System.EventHandler(this.TBPassword_Leave);
            // 
            // TBSeriapassport
            // 
            this.TBSeriapassport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBSeriapassport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSeriapassport.ForeColor = System.Drawing.Color.White;
            this.TBSeriapassport.Location = new System.Drawing.Point(7, 231);
            this.TBSeriapassport.MaxLength = 4;
            this.TBSeriapassport.Name = "TBSeriapassport";
            this.TBSeriapassport.Size = new System.Drawing.Size(241, 27);
            this.TBSeriapassport.TabIndex = 12;
            this.TBSeriapassport.Enter += new System.EventHandler(this.TBSeriapassport_Enter);
            this.TBSeriapassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSeriapassport_KeyPress);
            this.TBSeriapassport.Leave += new System.EventHandler(this.TBSeriapassport_Leave);
            // 
            // TBNumerpassport
            // 
            this.TBNumerpassport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBNumerpassport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBNumerpassport.ForeColor = System.Drawing.Color.White;
            this.TBNumerpassport.Location = new System.Drawing.Point(7, 264);
            this.TBNumerpassport.MaxLength = 6;
            this.TBNumerpassport.Name = "TBNumerpassport";
            this.TBNumerpassport.Size = new System.Drawing.Size(241, 27);
            this.TBNumerpassport.TabIndex = 13;
            this.TBNumerpassport.Enter += new System.EventHandler(this.TBNumerpassport_Enter);
            this.TBNumerpassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNumerpassport_KeyPress);
            this.TBNumerpassport.Leave += new System.EventHandler(this.TBNumerpassport_Leave);
            // 
            // TBDeschotel
            // 
            this.TBDeschotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBDeschotel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDeschotel.ForeColor = System.Drawing.Color.White;
            this.TBDeschotel.Location = new System.Drawing.Point(7, 361);
            this.TBDeschotel.Multiline = true;
            this.TBDeschotel.Name = "TBDeschotel";
            this.TBDeschotel.Size = new System.Drawing.Size(241, 176);
            this.TBDeschotel.TabIndex = 18;
            this.TBDeschotel.Enter += new System.EventHandler(this.TBDeschotel_Enter);
            this.TBDeschotel.Leave += new System.EventHandler(this.TBDeschotel_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(7, 324);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(240, 27);
            this.dateTimePickerDateOfBirth.TabIndex = 20;
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfBirth_ValueChanged);
            // 
            // LDataOfBirth
            // 
            this.LDataOfBirth.AutoSize = true;
            this.LDataOfBirth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDataOfBirth.ForeColor = System.Drawing.Color.White;
            this.LDataOfBirth.Location = new System.Drawing.Point(59, 298);
            this.LDataOfBirth.Name = "LDataOfBirth";
            this.LDataOfBirth.Size = new System.Drawing.Size(136, 19);
            this.LDataOfBirth.TabIndex = 21;
            this.LDataOfBirth.Text = "Дата рождения";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(256, 597);
            this.Controls.Add(this.LDataOfBirth);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddClient_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label TBHeadname;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.TextBox TBLastname;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBSeriapassport;
        private System.Windows.Forms.TextBox TBNumerpassport;
        private System.Windows.Forms.TextBox TBDeschotel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label LDataOfBirth;
    }
}