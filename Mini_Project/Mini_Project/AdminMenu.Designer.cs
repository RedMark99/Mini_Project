namespace Mini_Project
{
    partial class AdminMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.PMain = new System.Windows.Forms.Panel();
            this.BInfo = new System.Windows.Forms.Button();
            this.BImportExport = new System.Windows.Forms.Button();
            this.BAddreg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BAddcleint = new System.Windows.Forms.Button();
            this.BAddnomer = new System.Windows.Forms.Button();
            this.PActivity = new System.Windows.Forms.Panel();
            this.BSendMoney = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BReghotel = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BNomer = new System.Windows.Forms.Button();
            this.BClient = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TBClose = new System.Windows.Forms.PictureBox();
            this.PBHide = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TBUser = new System.Windows.Forms.Label();
            this.roundPictureBox1 = new Mini_Project.Interface.RoundPictureBox();
            this.PMain.SuspendLayout();
            this.PActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PMain
            // 
            this.PMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PMain.Controls.Add(this.BInfo);
            this.PMain.Controls.Add(this.BImportExport);
            this.PMain.Controls.Add(this.BAddreg);
            this.PMain.Controls.Add(this.label1);
            this.PMain.Controls.Add(this.roundPictureBox1);
            this.PMain.Controls.Add(this.BAddcleint);
            this.PMain.Controls.Add(this.BAddnomer);
            this.PMain.Location = new System.Drawing.Point(0, 23);
            this.PMain.Name = "PMain";
            this.PMain.Size = new System.Drawing.Size(200, 427);
            this.PMain.TabIndex = 0;
            // 
            // BInfo
            // 
            this.BInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BInfo.ForeColor = System.Drawing.Color.White;
            this.BInfo.Location = new System.Drawing.Point(0, 322);
            this.BInfo.Name = "BInfo";
            this.BInfo.Size = new System.Drawing.Size(200, 37);
            this.BInfo.TabIndex = 5;
            this.BInfo.Text = "Сводка данных";
            this.BInfo.UseVisualStyleBackColor = true;
            this.BInfo.Click += new System.EventHandler(this.BInfo_Click);
            // 
            // BImportExport
            // 
            this.BImportExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BImportExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BImportExport.ForeColor = System.Drawing.Color.White;
            this.BImportExport.Location = new System.Drawing.Point(0, 378);
            this.BImportExport.Name = "BImportExport";
            this.BImportExport.Size = new System.Drawing.Size(200, 37);
            this.BImportExport.TabIndex = 4;
            this.BImportExport.Text = "Импорт/Экспорт";
            this.BImportExport.UseVisualStyleBackColor = true;
            this.BImportExport.Click += new System.EventHandler(this.BImportExport_Click);
            // 
            // BAddreg
            // 
            this.BAddreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddreg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddreg.ForeColor = System.Drawing.Color.White;
            this.BAddreg.Location = new System.Drawing.Point(0, 193);
            this.BAddreg.Name = "BAddreg";
            this.BAddreg.Size = new System.Drawing.Size(200, 37);
            this.BAddreg.TabIndex = 1;
            this.BAddreg.Text = "Регистрация";
            this.BAddreg.UseVisualStyleBackColor = true;
            this.BAddreg.Click += new System.EventHandler(this.BAddreg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Администратор";
            // 
            // BAddcleint
            // 
            this.BAddcleint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddcleint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddcleint.ForeColor = System.Drawing.Color.White;
            this.BAddcleint.Location = new System.Drawing.Point(0, 236);
            this.BAddcleint.Name = "BAddcleint";
            this.BAddcleint.Size = new System.Drawing.Size(200, 37);
            this.BAddcleint.TabIndex = 2;
            this.BAddcleint.Text = "Доб. Клиент";
            this.BAddcleint.UseVisualStyleBackColor = true;
            this.BAddcleint.Click += new System.EventHandler(this.BAddcleint_Click);
            // 
            // BAddnomer
            // 
            this.BAddnomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddnomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddnomer.ForeColor = System.Drawing.Color.White;
            this.BAddnomer.Location = new System.Drawing.Point(0, 279);
            this.BAddnomer.Name = "BAddnomer";
            this.BAddnomer.Size = new System.Drawing.Size(200, 37);
            this.BAddnomer.TabIndex = 3;
            this.BAddnomer.Text = "Доб. Номер";
            this.BAddnomer.UseVisualStyleBackColor = true;
            this.BAddnomer.Click += new System.EventHandler(this.BAddnomer_Click);
            // 
            // PActivity
            // 
            this.PActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PActivity.Controls.Add(this.BSendMoney);
            this.PActivity.Controls.Add(this.BEdit);
            this.PActivity.Controls.Add(this.BReghotel);
            this.PActivity.Controls.Add(this.BDelete);
            this.PActivity.Controls.Add(this.label2);
            this.PActivity.Controls.Add(this.BNomer);
            this.PActivity.Controls.Add(this.BClient);
            this.PActivity.Controls.Add(this.dataGridView);
            this.PActivity.Location = new System.Drawing.Point(200, 23);
            this.PActivity.Name = "PActivity";
            this.PActivity.Size = new System.Drawing.Size(603, 427);
            this.PActivity.TabIndex = 1;
            // 
            // BSendMoney
            // 
            this.BSendMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSendMoney.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSendMoney.ForeColor = System.Drawing.Color.White;
            this.BSendMoney.Location = new System.Drawing.Point(263, 13);
            this.BSendMoney.Name = "BSendMoney";
            this.BSendMoney.Size = new System.Drawing.Size(78, 34);
            this.BSendMoney.TabIndex = 7;
            this.BSendMoney.Text = "Расчёт";
            this.BSendMoney.UseVisualStyleBackColor = true;
            this.BSendMoney.Click += new System.EventHandler(this.BSendMoney_Click);
            // 
            // BEdit
            // 
            this.BEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BEdit.ForeColor = System.Drawing.Color.White;
            this.BEdit.Location = new System.Drawing.Point(347, 13);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(149, 34);
            this.BEdit.TabIndex = 6;
            this.BEdit.Text = "Редактировать";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BReghotel
            // 
            this.BReghotel.BackColor = System.Drawing.Color.Transparent;
            this.BReghotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BReghotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReghotel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BReghotel.ForeColor = System.Drawing.Color.White;
            this.BReghotel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BReghotel.Location = new System.Drawing.Point(147, 77);
            this.BReghotel.Name = "BReghotel";
            this.BReghotel.Size = new System.Drawing.Size(157, 26);
            this.BReghotel.TabIndex = 5;
            this.BReghotel.Text = "Регистрация номеров";
            this.BReghotel.UseVisualStyleBackColor = false;
            this.BReghotel.Click += new System.EventHandler(this.BReghotel_Click);
            // 
            // BDelete
            // 
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDelete.ForeColor = System.Drawing.Color.White;
            this.BDelete.Location = new System.Drawing.Point(502, 13);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(98, 34);
            this.BDelete.TabIndex = 4;
            this.BDelete.Text = "Удалить";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Справочная";
            // 
            // BNomer
            // 
            this.BNomer.BackColor = System.Drawing.Color.Transparent;
            this.BNomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BNomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNomer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BNomer.ForeColor = System.Drawing.Color.White;
            this.BNomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BNomer.Location = new System.Drawing.Point(75, 77);
            this.BNomer.Name = "BNomer";
            this.BNomer.Size = new System.Drawing.Size(75, 26);
            this.BNomer.TabIndex = 2;
            this.BNomer.Text = "Номер";
            this.BNomer.UseVisualStyleBackColor = false;
            this.BNomer.Click += new System.EventHandler(this.BNomer_Click);
            // 
            // BClient
            // 
            this.BClient.BackColor = System.Drawing.Color.Transparent;
            this.BClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClient.ForeColor = System.Drawing.Color.White;
            this.BClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BClient.Location = new System.Drawing.Point(0, 77);
            this.BClient.Name = "BClient";
            this.BClient.Size = new System.Drawing.Size(75, 26);
            this.BClient.TabIndex = 1;
            this.BClient.Text = "Клиенты";
            this.BClient.UseVisualStyleBackColor = false;
            this.BClient.Click += new System.EventHandler(this.BClient_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(0, 103);
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
            this.dataGridView.Size = new System.Drawing.Size(603, 324);
            this.dataGridView.TabIndex = 0;
            // 
            // TBClose
            // 
            this.TBClose.Image = ((System.Drawing.Image)(resources.GetObject("TBClose.Image")));
            this.TBClose.Location = new System.Drawing.Point(752, 2);
            this.TBClose.Name = "TBClose";
            this.TBClose.Size = new System.Drawing.Size(66, 17);
            this.TBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TBClose.TabIndex = 0;
            this.TBClose.TabStop = false;
            this.TBClose.Click += new System.EventHandler(this.TBClose_Click);
            // 
            // PBHide
            // 
            this.PBHide.BackColor = System.Drawing.Color.Transparent;
            this.PBHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBHide.Image = ((System.Drawing.Image)(resources.GetObject("PBHide.Image")));
            this.PBHide.Location = new System.Drawing.Point(739, 1);
            this.PBHide.Name = "PBHide";
            this.PBHide.Size = new System.Drawing.Size(31, 20);
            this.PBHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHide.TabIndex = 2;
            this.PBHide.TabStop = false;
            this.PBHide.Click += new System.EventHandler(this.PBHide_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Hotel";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // TBUser
            // 
            this.TBUser.AutoSize = true;
            this.TBUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBUser.Location = new System.Drawing.Point(7, 4);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(99, 15);
            this.TBUser.TabIndex = 8;
            this.TBUser.Text = "Администратор";
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox1.Image")));
            this.roundPictureBox1.Location = new System.Drawing.Point(29, 21);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(139, 116);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundPictureBox1.TabIndex = 0;
            this.roundPictureBox1.TabStop = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.PBHide);
            this.Controls.Add(this.TBClose);
            this.Controls.Add(this.PActivity);
            this.Controls.Add(this.PMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.SizeChanged += new System.EventHandler(this.AdminMenu_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminMenu_MouseDown);
            this.PMain.ResumeLayout(false);
            this.PMain.PerformLayout();
            this.PActivity.ResumeLayout(false);
            this.PActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PMain;
        private System.Windows.Forms.Label label1;
        private Interface.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Button BAddnomer;
        private System.Windows.Forms.Button BAddcleint;
        private System.Windows.Forms.Button BAddreg;
        private System.Windows.Forms.Panel PActivity;
        private System.Windows.Forms.PictureBox TBClose;
        private System.Windows.Forms.PictureBox PBHide;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button BClient;
        private System.Windows.Forms.Button BNomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BReghotel;
        private System.Windows.Forms.Label TBUser;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BSendMoney;
        private System.Windows.Forms.Button BImportExport;
        private System.Windows.Forms.Button BInfo;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}