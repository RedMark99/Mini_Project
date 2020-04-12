namespace Mini_Project
{
    partial class RegNomer
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
            this.Lname = new System.Windows.Forms.Label();
            this.yt_Button1 = new Mini_Project.yt_Button();
            this.TBDesc = new System.Windows.Forms.TextBox();
            this.TBLastname = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBIdFlat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lname.Location = new System.Drawing.Point(7, 9);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(166, 20);
            this.Lname.TabIndex = 21;
            this.Lname.Text = "Регистрация номера";
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.Tomato;
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(7, 288);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Size = new System.Drawing.Size(275, 30);
            this.yt_Button1.TabIndex = 20;
            this.yt_Button1.Text = "yt_Button1";
            // 
            // TBDesc
            // 
            this.TBDesc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDesc.Location = new System.Drawing.Point(6, 170);
            this.TBDesc.Multiline = true;
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(276, 100);
            this.TBDesc.TabIndex = 17;
            // 
            // TBLastname
            // 
            this.TBLastname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLastname.Location = new System.Drawing.Point(7, 106);
            this.TBLastname.Name = "TBLastname";
            this.TBLastname.Size = new System.Drawing.Size(276, 26);
            this.TBLastname.TabIndex = 13;
            // 
            // TBSurname
            // 
            this.TBSurname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBSurname.Location = new System.Drawing.Point(8, 74);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(276, 26);
            this.TBSurname.TabIndex = 12;
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.Location = new System.Drawing.Point(8, 42);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(276, 26);
            this.TBName.TabIndex = 11;
            // 
            // TBIdFlat
            // 
            this.TBIdFlat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBIdFlat.Location = new System.Drawing.Point(7, 138);
            this.TBIdFlat.Name = "TBIdFlat";
            this.TBIdFlat.Size = new System.Drawing.Size(276, 26);
            this.TBIdFlat.TabIndex = 14;
            // 
            // RegNomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 325);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.TBDesc);
            this.Controls.Add(this.TBIdFlat);
            this.Controls.Add(this.TBLastname);
            this.Controls.Add(this.TBSurname);
            this.Controls.Add(this.TBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegNomer";
            this.Text = "RegNomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lname;
        private yt_Button yt_Button1;
        private System.Windows.Forms.TextBox TBDesc;
        private System.Windows.Forms.TextBox TBLastname;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBIdFlat;
    }
}