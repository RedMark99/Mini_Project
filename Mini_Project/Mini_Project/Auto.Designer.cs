namespace Mini_Project
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBHeadname = new System.Windows.Forms.Label();
            this.BAuto = new System.Windows.Forms.Button();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.BHide = new System.Windows.Forms.Button();
            this.TBError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // TBLogin
            // 
            this.TBLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLogin.ForeColor = System.Drawing.Color.White;
            this.TBLogin.Location = new System.Drawing.Point(426, 174);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(241, 27);
            this.TBLogin.TabIndex = 2;
            this.TBLogin.Enter += new System.EventHandler(this.TBLogin_Enter);
            this.TBLogin.Leave += new System.EventHandler(this.TBLogin_Leave);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassword.ForeColor = System.Drawing.Color.White;
            this.TBPassword.Location = new System.Drawing.Point(426, 220);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(241, 27);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.Enter += new System.EventHandler(this.password_Enter);
            this.TBPassword.Leave += new System.EventHandler(this.TBPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-377, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TBHeadname
            // 
            this.TBHeadname.AutoSize = true;
            this.TBHeadname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHeadname.ForeColor = System.Drawing.Color.White;
            this.TBHeadname.Location = new System.Drawing.Point(470, 126);
            this.TBHeadname.Name = "TBHeadname";
            this.TBHeadname.Size = new System.Drawing.Size(151, 25);
            this.TBHeadname.TabIndex = 4;
            this.TBHeadname.Text = "Авторизация";
            // 
            // BAuto
            // 
            this.BAuto.BackColor = System.Drawing.Color.Transparent;
            this.BAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAuto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAuto.ForeColor = System.Drawing.Color.White;
            this.BAuto.Location = new System.Drawing.Point(426, 264);
            this.BAuto.Name = "BAuto";
            this.BAuto.Size = new System.Drawing.Size(241, 39);
            this.BAuto.TabIndex = 1;
            this.BAuto.Text = "Авторизоваться";
            this.BAuto.UseVisualStyleBackColor = false;
            this.BAuto.Click += new System.EventHandler(this.BAuto_Click);
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(664, 6);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(61, 20);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 6;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // BHide
            // 
            this.BHide.BackColor = System.Drawing.Color.Transparent;
            this.BHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BHide.ForeColor = System.Drawing.Color.White;
            this.BHide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BHide.Location = new System.Drawing.Point(591, 220);
            this.BHide.Name = "BHide";
            this.BHide.Size = new System.Drawing.Size(76, 27);
            this.BHide.TabIndex = 7;
            this.BHide.Text = "Показать";
            this.BHide.UseVisualStyleBackColor = false;
            this.BHide.Click += new System.EventHandler(this.BHide_Click);
            // 
            // TBError
            // 
            this.TBError.AutoSize = true;
            this.TBError.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBError.ForeColor = System.Drawing.Color.Red;
            this.TBError.Location = new System.Drawing.Point(426, 310);
            this.TBError.Name = "TBError";
            this.TBError.Size = new System.Drawing.Size(49, 16);
            this.TBError.TabIndex = 8;
            this.TBError.Text = "label1";
            this.TBError.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(717, 469);
            this.Controls.Add(this.TBError);
            this.Controls.Add(this.BHide);
            this.Controls.Add(this.PBClose);
            this.Controls.Add(this.BAuto);
            this.Controls.Add(this.TBHeadname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TBHeadname;
        private System.Windows.Forms.Button BAuto;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.Button BHide;
        private System.Windows.Forms.Label TBError;
    }
}

