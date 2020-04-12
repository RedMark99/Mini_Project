namespace Mini_Project
{
    partial class UserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PBHide = new System.Windows.Forms.PictureBox();
            this.TBClose = new System.Windows.Forms.PictureBox();
            this.PActivity = new System.Windows.Forms.Panel();
            this.BQuery = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.Test = new System.Windows.Forms.Button();
            this.LToday = new System.Windows.Forms.Label();
            this.BAddreg = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PInfo = new System.Windows.Forms.Panel();
            this.LCountlive = new System.Windows.Forms.Label();
            this.LDesc = new System.Windows.Forms.Label();
            this.LDateofbirth = new System.Windows.Forms.Label();
            this.LSCountlive = new System.Windows.Forms.Label();
            this.LSDesc = new System.Windows.Forms.Label();
            this.LSDateofbirth = new System.Windows.Forms.Label();
            this.LNSL = new System.Windows.Forms.Label();
            this.LSName = new System.Windows.Forms.Label();
            this.Linfo = new System.Windows.Forms.Label();
            this.PMain = new System.Windows.Forms.Panel();
            this.BInfo = new System.Windows.Forms.Button();
            this.BInfoYour = new System.Windows.Forms.Button();
            this.BReg = new System.Windows.Forms.Button();
            this.TName = new System.Windows.Forms.Label();
            this.roundPictureBox1 = new Mini_Project.Interface.RoundPictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TBUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).BeginInit();
            this.PActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PInfo.SuspendLayout();
            this.PMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBHide
            // 
            this.PBHide.BackColor = System.Drawing.Color.Transparent;
            this.PBHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBHide.Image = ((System.Drawing.Image)(resources.GetObject("PBHide.Image")));
            this.PBHide.Location = new System.Drawing.Point(730, 1);
            this.PBHide.Name = "PBHide";
            this.PBHide.Size = new System.Drawing.Size(31, 20);
            this.PBHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBHide.TabIndex = 6;
            this.PBHide.TabStop = false;
            this.PBHide.Click += new System.EventHandler(this.PBHide_Click);
            // 
            // TBClose
            // 
            this.TBClose.Image = ((System.Drawing.Image)(resources.GetObject("TBClose.Image")));
            this.TBClose.Location = new System.Drawing.Point(743, 2);
            this.TBClose.Name = "TBClose";
            this.TBClose.Size = new System.Drawing.Size(66, 17);
            this.TBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TBClose.TabIndex = 3;
            this.TBClose.TabStop = false;
            this.TBClose.Click += new System.EventHandler(this.TBClose_Click);
            // 
            // PActivity
            // 
            this.PActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PActivity.Controls.Add(this.BQuery);
            this.PActivity.Controls.Add(this.dateTimePickerEnd);
            this.PActivity.Controls.Add(this.dateTimePickerStart);
            this.PActivity.Controls.Add(this.Test);
            this.PActivity.Controls.Add(this.LToday);
            this.PActivity.Controls.Add(this.BAddreg);
            this.PActivity.Controls.Add(this.dataGridView);
            this.PActivity.Controls.Add(this.label2);
            this.PActivity.Location = new System.Drawing.Point(200, 23);
            this.PActivity.Name = "PActivity";
            this.PActivity.Size = new System.Drawing.Size(609, 427);
            this.PActivity.TabIndex = 5;
            // 
            // BQuery
            // 
            this.BQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BQuery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BQuery.ForeColor = System.Drawing.Color.White;
            this.BQuery.Location = new System.Drawing.Point(294, 58);
            this.BQuery.Name = "BQuery";
            this.BQuery.Size = new System.Drawing.Size(294, 35);
            this.BQuery.TabIndex = 34;
            this.BQuery.Text = "Ваши бронированные номера";
            this.BQuery.UseVisualStyleBackColor = false;
            this.BQuery.Click += new System.EventHandler(this.BQuery_Click);
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
            this.dateTimePickerEnd.Location = new System.Drawing.Point(188, 110);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerEnd.TabIndex = 20;
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
            this.dateTimePickerStart.Location = new System.Drawing.Point(8, 110);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerStart.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerStart.TabIndex = 19;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // Test
            // 
            this.Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Test.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test.ForeColor = System.Drawing.Color.White;
            this.Test.Location = new System.Drawing.Point(368, 110);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(76, 30);
            this.Test.TabIndex = 33;
            this.Test.Text = "Поиск";
            this.Test.UseVisualStyleBackColor = false;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // LToday
            // 
            this.LToday.AutoSize = true;
            this.LToday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LToday.ForeColor = System.Drawing.Color.White;
            this.LToday.Location = new System.Drawing.Point(78, 10);
            this.LToday.Name = "LToday";
            this.LToday.Size = new System.Drawing.Size(120, 19);
            this.LToday.TabIndex = 3;
            this.LToday.Text = "Информация";
            // 
            // BAddreg
            // 
            this.BAddreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAddreg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddreg.ForeColor = System.Drawing.Color.White;
            this.BAddreg.Location = new System.Drawing.Point(450, 110);
            this.BAddreg.Name = "BAddreg";
            this.BAddreg.Size = new System.Drawing.Size(138, 30);
            this.BAddreg.TabIndex = 1;
            this.BAddreg.Text = "Бронировать";
            this.BAddreg.UseVisualStyleBackColor = true;
            this.BAddreg.Click += new System.EventHandler(this.BAddreg_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(0, 146);
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
            this.dataGridView.Size = new System.Drawing.Size(599, 281);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Сегодня:";
            // 
            // PInfo
            // 
            this.PInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PInfo.Controls.Add(this.LCountlive);
            this.PInfo.Controls.Add(this.LDesc);
            this.PInfo.Controls.Add(this.LDateofbirth);
            this.PInfo.Controls.Add(this.LSCountlive);
            this.PInfo.Controls.Add(this.LSDesc);
            this.PInfo.Controls.Add(this.LSDateofbirth);
            this.PInfo.Controls.Add(this.LNSL);
            this.PInfo.Controls.Add(this.LSName);
            this.PInfo.Controls.Add(this.Linfo);
            this.PInfo.Location = new System.Drawing.Point(200, 23);
            this.PInfo.Name = "PInfo";
            this.PInfo.Size = new System.Drawing.Size(599, 427);
            this.PInfo.TabIndex = 21;
            // 
            // LCountlive
            // 
            this.LCountlive.AutoSize = true;
            this.LCountlive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCountlive.ForeColor = System.Drawing.Color.White;
            this.LCountlive.Location = new System.Drawing.Point(184, 200);
            this.LCountlive.Name = "LCountlive";
            this.LCountlive.Size = new System.Drawing.Size(172, 19);
            this.LCountlive.TabIndex = 31;
            this.LCountlive.Text = "Кол-во дней в отеле";
            // 
            // LDesc
            // 
            this.LDesc.AutoSize = true;
            this.LDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDesc.ForeColor = System.Drawing.Color.White;
            this.LDesc.Location = new System.Drawing.Point(121, 163);
            this.LDesc.Name = "LDesc";
            this.LDesc.Size = new System.Drawing.Size(114, 19);
            this.LDesc.TabIndex = 30;
            this.LDesc.Text = "Примечание";
            // 
            // LDateofbirth
            // 
            this.LDateofbirth.AutoSize = true;
            this.LDateofbirth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDateofbirth.ForeColor = System.Drawing.Color.White;
            this.LDateofbirth.Location = new System.Drawing.Point(144, 124);
            this.LDateofbirth.Name = "LDateofbirth";
            this.LDateofbirth.Size = new System.Drawing.Size(136, 19);
            this.LDateofbirth.TabIndex = 29;
            this.LDateofbirth.Text = "Дата рождения";
            // 
            // LSCountlive
            // 
            this.LSCountlive.AutoSize = true;
            this.LSCountlive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSCountlive.ForeColor = System.Drawing.Color.White;
            this.LSCountlive.Location = new System.Drawing.Point(8, 200);
            this.LSCountlive.Name = "LSCountlive";
            this.LSCountlive.Size = new System.Drawing.Size(176, 19);
            this.LSCountlive.TabIndex = 28;
            this.LSCountlive.Text = "Кол-во дней в отеле:";
            // 
            // LSDesc
            // 
            this.LSDesc.AutoSize = true;
            this.LSDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSDesc.ForeColor = System.Drawing.Color.White;
            this.LSDesc.Location = new System.Drawing.Point(6, 163);
            this.LSDesc.Name = "LSDesc";
            this.LSDesc.Size = new System.Drawing.Size(118, 19);
            this.LSDesc.TabIndex = 27;
            this.LSDesc.Text = "Примечание:";
            // 
            // LSDateofbirth
            // 
            this.LSDateofbirth.AutoSize = true;
            this.LSDateofbirth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSDateofbirth.ForeColor = System.Drawing.Color.White;
            this.LSDateofbirth.Location = new System.Drawing.Point(6, 124);
            this.LSDateofbirth.Name = "LSDateofbirth";
            this.LSDateofbirth.Size = new System.Drawing.Size(140, 19);
            this.LSDateofbirth.TabIndex = 26;
            this.LSDateofbirth.Text = "Дата рождения:";
            // 
            // LNSL
            // 
            this.LNSL.AutoSize = true;
            this.LNSL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNSL.ForeColor = System.Drawing.Color.White;
            this.LNSL.Location = new System.Drawing.Point(51, 88);
            this.LNSL.Name = "LNSL";
            this.LNSL.Size = new System.Drawing.Size(45, 19);
            this.LNSL.TabIndex = 25;
            this.LNSL.Text = "ФИО";
            // 
            // LSName
            // 
            this.LSName.AutoSize = true;
            this.LSName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSName.ForeColor = System.Drawing.Color.White;
            this.LSName.Location = new System.Drawing.Point(6, 88);
            this.LSName.Name = "LSName";
            this.LSName.Size = new System.Drawing.Size(49, 19);
            this.LSName.TabIndex = 24;
            this.LSName.Text = "ФИО:";
            // 
            // Linfo
            // 
            this.Linfo.AutoSize = true;
            this.Linfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Linfo.ForeColor = System.Drawing.Color.White;
            this.Linfo.Location = new System.Drawing.Point(6, 10);
            this.Linfo.Name = "Linfo";
            this.Linfo.Size = new System.Drawing.Size(120, 19);
            this.Linfo.TabIndex = 23;
            this.Linfo.Text = "Информация";
            // 
            // PMain
            // 
            this.PMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PMain.Controls.Add(this.BInfo);
            this.PMain.Controls.Add(this.BInfoYour);
            this.PMain.Controls.Add(this.BReg);
            this.PMain.Controls.Add(this.TName);
            this.PMain.Controls.Add(this.roundPictureBox1);
            this.PMain.Location = new System.Drawing.Point(0, 23);
            this.PMain.Name = "PMain";
            this.PMain.Size = new System.Drawing.Size(200, 427);
            this.PMain.TabIndex = 4;
            // 
            // BInfo
            // 
            this.BInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BInfo.ForeColor = System.Drawing.Color.White;
            this.BInfo.Location = new System.Drawing.Point(0, 284);
            this.BInfo.Name = "BInfo";
            this.BInfo.Size = new System.Drawing.Size(200, 37);
            this.BInfo.TabIndex = 22;
            this.BInfo.Text = "Сводка данных";
            this.BInfo.UseVisualStyleBackColor = true;
            this.BInfo.Click += new System.EventHandler(this.BInfo_Click);
            // 
            // BInfoYour
            // 
            this.BInfoYour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInfoYour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BInfoYour.ForeColor = System.Drawing.Color.White;
            this.BInfoYour.Location = new System.Drawing.Point(0, 236);
            this.BInfoYour.Name = "BInfoYour";
            this.BInfoYour.Size = new System.Drawing.Size(200, 41);
            this.BInfoYour.TabIndex = 22;
            this.BInfoYour.Text = "Информация о вас";
            this.BInfoYour.UseVisualStyleBackColor = true;
            this.BInfoYour.Click += new System.EventHandler(this.BInfoYour_Click);
            // 
            // BReg
            // 
            this.BReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BReg.ForeColor = System.Drawing.Color.White;
            this.BReg.Location = new System.Drawing.Point(0, 189);
            this.BReg.Name = "BReg";
            this.BReg.Size = new System.Drawing.Size(200, 41);
            this.BReg.TabIndex = 21;
            this.BReg.Text = "Бронирование";
            this.BReg.UseVisualStyleBackColor = true;
            this.BReg.Click += new System.EventHandler(this.BReg_Click);
            // 
            // TName
            // 
            this.TName.AutoSize = true;
            this.TName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TName.ForeColor = System.Drawing.Color.White;
            this.TName.Location = new System.Drawing.Point(36, 146);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(119, 19);
            this.TName.TabIndex = 1;
            this.TName.Text = "Пользователь";
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox1.Image")));
            this.roundPictureBox1.Location = new System.Drawing.Point(30, 10);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(137, 130);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundPictureBox1.TabIndex = 0;
            this.roundPictureBox1.TabStop = false;
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
            this.TBUser.Size = new System.Drawing.Size(82, 15);
            this.TBUser.TabIndex = 7;
            this.TBUser.Text = "Пользователь";
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PInfo);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.PBHide);
            this.Controls.Add(this.TBClose);
            this.Controls.Add(this.PActivity);
            this.Controls.Add(this.PMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserMenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PBHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBClose)).EndInit();
            this.PActivity.ResumeLayout(false);
            this.PActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PInfo.ResumeLayout(false);
            this.PInfo.PerformLayout();
            this.PMain.ResumeLayout(false);
            this.PMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBHide;
        private System.Windows.Forms.PictureBox TBClose;
        private System.Windows.Forms.Panel PActivity;
        private System.Windows.Forms.Panel PMain;
        private System.Windows.Forms.Button BAddreg;
        private System.Windows.Forms.Label TName;
        private Interface.RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label LToday;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button BInfoYour;
        private System.Windows.Forms.Button BReg;
        private System.Windows.Forms.Label TBUser;
        private System.Windows.Forms.Panel PInfo;
        private System.Windows.Forms.Label LSDesc;
        private System.Windows.Forms.Label LSDateofbirth;
        private System.Windows.Forms.Label LNSL;
        private System.Windows.Forms.Label LSName;
        private System.Windows.Forms.Label Linfo;
        private System.Windows.Forms.Label LSCountlive;
        private System.Windows.Forms.Label LCountlive;
        private System.Windows.Forms.Label LDesc;
        private System.Windows.Forms.Label LDateofbirth;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button BQuery;
        private System.Windows.Forms.Button BInfo;
    }
}