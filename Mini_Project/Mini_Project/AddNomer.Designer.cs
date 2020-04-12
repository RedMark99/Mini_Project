namespace Mini_Project
{
    partial class AddNomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNomer));
            this.BAddNomer = new System.Windows.Forms.Button();
            this.TBHeadname = new System.Windows.Forms.Label();
            this.TBNomer = new System.Windows.Forms.TextBox();
            this.TBCountpeople = new System.Windows.Forms.TextBox();
            this.TBPayment = new System.Windows.Forms.TextBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.CBCateogury = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            this.SuspendLayout();
            // 
            // BAddNomer
            // 
            this.BAddNomer.BackColor = System.Drawing.Color.Transparent;
            this.BAddNomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddNomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddNomer.ForeColor = System.Drawing.Color.White;
            this.BAddNomer.Location = new System.Drawing.Point(8, 204);
            this.BAddNomer.Name = "BAddNomer";
            this.BAddNomer.Size = new System.Drawing.Size(241, 39);
            this.BAddNomer.TabIndex = 8;
            this.BAddNomer.Text = "Добавить";
            this.BAddNomer.UseVisualStyleBackColor = false;
            this.BAddNomer.Click += new System.EventHandler(this.BAddNomer_Click);
            // 
            // TBHeadname
            // 
            this.TBHeadname.AutoSize = true;
            this.TBHeadname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBHeadname.ForeColor = System.Drawing.Color.White;
            this.TBHeadname.Location = new System.Drawing.Point(12, 27);
            this.TBHeadname.Name = "TBHeadname";
            this.TBHeadname.Size = new System.Drawing.Size(232, 25);
            this.TBHeadname.TabIndex = 10;
            this.TBHeadname.Text = "Добавление номера";
            // 
            // TBNomer
            // 
            this.TBNomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBNomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBNomer.ForeColor = System.Drawing.Color.White;
            this.TBNomer.Location = new System.Drawing.Point(8, 61);
            this.TBNomer.MaxLength = 3;
            this.TBNomer.Name = "TBNomer";
            this.TBNomer.Size = new System.Drawing.Size(241, 27);
            this.TBNomer.TabIndex = 9;
            this.TBNomer.Enter += new System.EventHandler(this.TBNomer_Enter);
            this.TBNomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNomer_KeyPress);
            this.TBNomer.Leave += new System.EventHandler(this.TBNomer_Leave);
            // 
            // TBCountpeople
            // 
            this.TBCountpeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBCountpeople.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBCountpeople.ForeColor = System.Drawing.Color.White;
            this.TBCountpeople.Location = new System.Drawing.Point(8, 94);
            this.TBCountpeople.MaxLength = 1;
            this.TBCountpeople.Name = "TBCountpeople";
            this.TBCountpeople.Size = new System.Drawing.Size(241, 27);
            this.TBCountpeople.TabIndex = 11;
            this.TBCountpeople.Enter += new System.EventHandler(this.TBCountpeople_Enter);
            this.TBCountpeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCountpeople_KeyPress);
            this.TBCountpeople.Leave += new System.EventHandler(this.TBCountpeople_Leave);
            // 
            // TBPayment
            // 
            this.TBPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TBPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPayment.ForeColor = System.Drawing.Color.White;
            this.TBPayment.Location = new System.Drawing.Point(8, 160);
            this.TBPayment.Name = "TBPayment";
            this.TBPayment.Size = new System.Drawing.Size(241, 27);
            this.TBPayment.TabIndex = 13;
            this.TBPayment.Enter += new System.EventHandler(this.TBPayment_Enter);
            this.TBPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPayment_KeyPress);
            this.TBPayment.Leave += new System.EventHandler(this.TBPayment_Leave);
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(229, 5);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(34, 14);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 14;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // CBCateogury
            // 
            this.CBCateogury.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CBCateogury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBCateogury.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCateogury.ForeColor = System.Drawing.Color.White;
            this.CBCateogury.FormattingEnabled = true;
            this.CBCateogury.Location = new System.Drawing.Point(8, 127);
            this.CBCateogury.Name = "CBCateogury";
            this.CBCateogury.Size = new System.Drawing.Size(241, 27);
            this.CBCateogury.TabIndex = 15;
            this.CBCateogury.Enter += new System.EventHandler(this.CBCateogury_Enter);
            this.CBCateogury.Leave += new System.EventHandler(this.CBCateogury_Leave);
            // 
            // AddNomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(260, 252);
            this.Controls.Add(this.CBCateogury);
            this.Controls.Add(this.PBClose);
            this.Controls.Add(this.TBPayment);
            this.Controls.Add(this.TBCountpeople);
            this.Controls.Add(this.BAddNomer);
            this.Controls.Add(this.TBHeadname);
            this.Controls.Add(this.TBNomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNomer";
            this.Text = "AddNomer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNomer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAddNomer;
        private System.Windows.Forms.Label TBHeadname;
        private System.Windows.Forms.TextBox TBNomer;
        private System.Windows.Forms.TextBox TBCountpeople;
        private System.Windows.Forms.TextBox TBPayment;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.ComboBox CBCateogury;
    }
}