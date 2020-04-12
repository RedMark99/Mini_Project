using Mini_Project.MyDbClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project
{

    public partial class AdminMenu : Form
    {

        MyDbContext db = new MyDbContext();
        
        //Переменые для подсветки

        bool ClientLight = false;
        bool NomerLight = false;
        bool RegHotelLight = false;

        public void RefreshAddClient()
        {
            if (ClientLight == true)
            {
                Client();
            }
            else if (NomerLight == true) 
            {
                Nomer();
            }
            else if (RegHotelLight == true)
            {
                RegHotel();
            }
        }


        //Подсветка выбранной таблицы
        public void light() 
        {
            if (ClientLight == true) 
            {
                BClient.BackColor = Color.FromArgb(255, 128, 0); // orange
                BNomer.BackColor = Color.FromArgb(26, 26, 26); // gray
                BReghotel.BackColor = Color.FromArgb(26, 26, 26);
            }
            else if (NomerLight == true) 
            {
                BNomer.BackColor = Color.FromArgb(255, 128, 0);
                BClient.BackColor = Color.FromArgb(26, 26, 26);
                BReghotel.BackColor = Color.FromArgb(26, 26, 26);
            }
            else if (RegHotelLight == true)
            {
                BReghotel.BackColor = Color.FromArgb(255, 128, 0);
                BClient.BackColor = Color.FromArgb(26, 26, 26);
                BNomer.BackColor = Color.FromArgb(26, 26, 26);
            }
        }

        public AdminMenu()
        {
            InitializeComponent();
        }

        //Кнопки для открытие форм  ---------------------------------------------- НАЧАЛО -------------------------------------------------------
        private void BAddcleint_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient(this); // передаём owner в addClient для автомочиского обновление DATAGRIDVIEW с дочерней формы
            addClient.Show();
        }

        private void BAddnomer_Click(object sender, EventArgs e)
        {
            AddNomer addNomer = new AddNomer(this); // передаём owner в addNomer для автомочиского обновление DATAGRIDVIEW с дочерней формы
            addNomer.Show();
        }

        private void BAddreg_Click(object sender, EventArgs e)
        {
            AddReg addreg = new AddReg(this);
            addreg.Show();
        }
        //Кнопки для открытие форм  ---------------------------------------------- КОНЕЦ -------------------------------------------------------

        //Для перетаскивания формы по рабочему столу ----------------------------- НАЧАЛО ------------------------------------------------------
        private void AdminMenu_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        //Для перетаскивания формы по рабочему столу ----------------------------- КОНЕЦ ------------------------------------------------------


        //Кнопки и трей ---------------------------------------------------------- НАЧАЛО -----------------------------------------------------
        private void PBHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void TBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMenu_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) 
            {
                notifyIcon.Icon = SystemIcons.Application;
                notifyIcon.BalloonTipText = "Hotel в трей";
                notifyIcon.ShowBalloonTip(1000);
            }

            else if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.BalloonTipText = "Hotel развёрнуто";
                notifyIcon.ShowBalloonTip(1000);
            }
        }

        //Кнопки и трей ---------------------------------------------------------- КОНЕЦ -----------------------------------------------------

        //Client --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
        public void Client() 
        {
            dataGridView.Rows.Clear();

            //Очищение dateGridView вместе с шапкой

            dataGridView.SelectAll();
            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();




            //Создаём заранее колонки
            dataGridView.Columns.Add("Column0", "ID Клиента");
            dataGridView.Columns.Add("Column1", "Имя");
            dataGridView.Columns.Add("Column2", "Фамилия");
            dataGridView.Columns.Add("Column3", "Отчество");
            dataGridView.Columns.Add("Column4", "Дата рождения");
            dataGridView.Columns.Add("Column5", "Серия паспорта");
            dataGridView.Columns.Add("Column6", "Номер паспорта");
            dataGridView.Columns.Add("Column7", "Кол-во дней прожитых");

            //Подключение к базе данных MicroSoft Sql server
            using (var context = new MyDbContext())
            {
                //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                var res = from x in context.Clients
                          select new
                          {
                              Id = x.idClient,
                              Name = x.name,
                              Surname = x.surname,
                              Lastname = x.lastname,
                              dateOfBirth = x.dataOfBirth,
                              seriapassport = x.seriaPassport,
                              nomerpassport = x.numberPassport,
                              countlive = x.countDaysLive
                          };
                //Считываем в datagrid view
                foreach (var item in res.ToList())
                {
                    dataGridView.Rows.Add(item.Id, item.Name, item.Surname, item.Lastname, item.dateOfBirth, item.seriapassport, item.nomerpassport, item.countlive);
                }

                dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView

                //Код для полного заполнения базы данных
                //BindingSource dbclient = new BindingSource();
                //dbclient.DataSource = typeof(Client);
                //context.Clients.ToList().ForEach(x => dbclient.Add(x));
                //dataGridView.DataSource = dbclient;
            }
        }
        //Client --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //


        //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
        public void Nomer() 
        {
            //Очищение dateGridView данных

            dataGridView.Rows.Clear();

            //Очищение dateGridView вместе с шапкой

            dataGridView.SelectAll();
            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();



            //Создаём заранее колонки
            dataGridView.Columns.Add("Column0", "ID Номер");
            dataGridView.Columns.Add("Column1", "Номер");
            dataGridView.Columns.Add("Column2", "Кол-во спальных мест");
            dataGridView.Columns.Add("Column3", "Категория");
            dataGridView.Columns.Add("Column4", "Цена");

            //Подключение к базе данных MicroSoft Sql server
            using (var context = new MyDbContext())
            {
                //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                var res = from x in context.HotelRooms
                          select new
                          {
                              Id = x.idFlat,
                              Nomer = x.nomer,
                              CountPeople = x.countPeople,
                              Category = x.category,
                              Payment = x.payment,
                          };
                //Считываем в datagrid view
                foreach (var item in res.ToList())
                {
                    dataGridView.Rows.Add(item.Id, item.Nomer, item.CountPeople, item.Category, item.Payment);
                }

                dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView

                //Код для полного заполнения базы данных
                //BindingSource dbclient = new BindingSource();
                //dbclient.DataSource = typeof(Client);
                //context.Clients.ToList().ForEach(x => dbclient.Add(x));
                //dataGridView.DataSource = dbclient;



            }
        }
        //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //

        //RegHotel --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
        public void RegHotel()
        {
            //Очищение dateGridView данных

            dataGridView.Rows.Clear();

            //Очищение dateGridView вместе с шапкой

            dataGridView.SelectAll();
            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();



            //Создаём заранее колонки
            dataGridView.Columns.Add("Column0", "ID Регистрации");
            dataGridView.Columns.Add("Column1", "Номер");
            dataGridView.Columns.Add("Column2", "Имя");
            dataGridView.Columns.Add("Column3", "Фамилия");
            dataGridView.Columns.Add("Column4", "Отчество");
            dataGridView.Columns.Add("Column5", "Начало");
            dataGridView.Columns.Add("Column6", "Конец");
            dataGridView.Columns.Add("Column7", "Расчёт");

            //Подключение к базе данных MicroSoft Sql server
            using (var context = new MyDbContext())
            {
                //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                var res = from x in context.RegHotels
                          from y in context.HotelRooms
                          from z in context.Clients
                          where x.idClient == z.idClient && x.idFlat == y.idFlat
                          select new
                          {
                              Id = x.idLive,
                              Nomer = y.nomer,
                              Name = z.name,
                              Surname = z.surname,
                              Lastname = z.lastname,
                              DataStart = x.startLive,
                              DataEnd = x.endLive,
                              Desc = x.desclive
                          };
                //Считываем в datagrid view
                foreach (var item in res.ToList())
                {
                    dataGridView.Rows.Add(item.Id, item.Nomer, item.Name, item.Surname, item.Lastname, item.DataStart, item.DataEnd, item.Desc);
                }

                dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView

                //Код для полного заполнения базы данных
                //BindingSource dbclient = new BindingSource();
                //dbclient.DataSource = typeof(Client);
                //context.Clients.ToList().ForEach(x => dbclient.Add(x));
                //dataGridView.DataSource = dbclient;



            }
        }
        //RegHotel --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //


        private void BClient_Click(object sender, EventArgs e)
        {
            //Custom Внешний вид
            ClientLight = true;
            NomerLight = false;
            RegHotelLight = false;
            light();
            //Обновление dateGridView данных
            Client();
            
        }


        private void BNomer_Click(object sender, EventArgs e)
        {
            //Custom Внешний вид
            ClientLight = false;
            NomerLight = true;
            RegHotelLight = false;
            light();
            //Обновление dateGridView данных
            Nomer();
            
        }

        private void BReghotel_Click(object sender, EventArgs e)
        {
            //Custom Внешний вид
            RegHotelLight = true;
            ClientLight = false;
            NomerLight = false;
            light();
            //Обновление dateGridView данных
            RegHotel();
        }

        //Удаление из базы данных
        private void BDelete_Click(object sender, EventArgs e)
        {
            if (NomerLight == true)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    HotelRoom hotelroom = db.HotelRooms.Find(id);
                    db.HotelRooms.Remove(hotelroom);
                    db.SaveChanges();

                    MessageBox.Show("Обьект удален");
                    Nomer();
                }
            }
            else if (ClientLight == true)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    Client client = db.Clients.Find(id);
                    db.Clients.Remove(client);
                    db.SaveChanges();

                    MessageBox.Show("Обьект удален");
                    Client();

                }

            }
            else if (RegHotelLight == true) 
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    RegHotel reghotel = db.RegHotels.Find(id);
                    db.RegHotels.Remove(reghotel);
                    db.SaveChanges();

                    MessageBox.Show("Обьект удален");
                    RegHotel();

                }
            }
        }

        //Редактирование
        private void BEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    int indexRow = dataGridView.CurrentCell.RowIndex;

                    int id = Convert.ToInt32(dataGridView.Rows[indexRow].Cells[0].Value);


                    if (ClientLight == true)
                    {
                        Client client = db.Clients.Find(id);

                        EditClient editClient = new EditClient();

                        editClient.TBName.Text = client.name; // что бы поля были видны в свойствах нужно было поменять private на internal
                        editClient.TBSurname.Text = client.surname;
                        editClient.TBLastname.Text = client.lastname;
                        editClient.TBLogin.Text = client.login;
                        editClient.TBPassword.Text = client.password;
                        editClient.TBSeriapassport.Text = client.seriaPassport;
                        editClient.TBNumerpassport.Text = client.numberPassport;
                        editClient.dateTimePickerDateOfBirth.Value = DateTime.Parse(client.dataOfBirth.ToShortDateString());
                        editClient.TBDeschotel.Text = client.deschotel;
                        DialogResult result = editClient.ShowDialog(this); // в свойствах DialogRisult надо указать ОК 

                        if (result == DialogResult.Cancel)
                            return;

                        var query = context.Clients.Where(x => x.login == editClient.TBLogin.Text || x.numberPassport == editClient.TBNumerpassport.Text);

                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////Сделать проверку////////////////////////////////////////////////
                        if (query.ToList().Count < 1)
                        {
                            client.name = editClient.TBName.Text;
                            client.surname = editClient.TBSurname.Text;
                            client.lastname = editClient.TBLastname.Text;
                            client.login = editClient.TBLogin.Text;
                            client.password = editClient.TBPassword.Text;
                            client.seriaPassport = editClient.TBSeriapassport.Text;
                            client.numberPassport = editClient.TBNumerpassport.Text;
                            client.dataOfBirth = DateTime.Parse(editClient.dateTimePickerDateOfBirth.Value.ToString());

                            db.SaveChanges();
                            Client(); // обновляем грид
                            MessageBox.Show("Объект изменён");
                        }
                        else 
                        {
                            MessageBox.Show("Логин или Номер Пасспорта такой уже есть в базе данных");
                        }
                    }

                    if (NomerLight == true)
                    {
                        HotelRoom hotelRoom = db.HotelRooms.Find(id);

                        EditNomer editHotelRoom = new EditNomer();

                        editHotelRoom.TBNomer.Text = hotelRoom.nomer;
                        editHotelRoom.TBCountpeople.Text = hotelRoom.countPeople.ToString();
                        editHotelRoom.CBCateogury.Text = hotelRoom.category;
                        editHotelRoom.TBPayment.Text = hotelRoom.payment.ToString();
                        DialogResult result = editHotelRoom.ShowDialog(this);

                        if (result == DialogResult.Cancel)
                            return;

                        var query = context.HotelRooms.Where(x => x.nomer == editHotelRoom.TBNomer.Text);
                        if (query.ToList().Count < 1)
                        {
                            hotelRoom.nomer = editHotelRoom.TBNomer.Text;
                            hotelRoom.category = editHotelRoom.CBCateogury.SelectedItem.ToString();
                            hotelRoom.countPeople = Convert.ToInt32(editHotelRoom.TBCountpeople.Text);
                            hotelRoom.payment = Convert.ToInt32(editHotelRoom.TBPayment.Text);

                            db.SaveChanges();
                            Nomer(); // обновляем грид
                            MessageBox.Show("Объект изменён");
                        }
                        else 
                        {
                            MessageBox.Show("Такой номер уже существует");
                        }
                    }

                    if (RegHotelLight == true)
                    {

                        RegHotel regHotel = db.RegHotels.Find(id);

                        EditReg editReg = new EditReg();

                        editReg.dateTimePickerStart.Value = regHotel.startLive;
                        editReg.dateTimePickerEnd.Value = regHotel.endLive;
                        editReg.CBDesclive.Text = regHotel.desclive;
                        editReg.clientid = regHotel.idClient;
                        editReg.nomerid = regHotel.idFlat;


                        Client client = db.Clients.Find(regHotel.idClient);
                        {
                            client.countDaysLive = client.countDaysLive - (regHotel.endLive - regHotel.startLive).Days;
                        }

                        DialogResult result = editReg.ShowDialog(this);

                        if (result == DialogResult.Cancel)
                            return;
                        
                            var query = context.RegHotels.Where(x => x.idFlat == editReg.nomerid && (editReg.dateTimePickerStart.Value >= x.startLive && x.endLive >= editReg.dateTimePickerStart.Value || editReg.dateTimePickerEnd.Value >= x.startLive && x.endLive >= editReg.dateTimePickerEnd.Value));
                            //Селект из data grid view на номер id
                            var queryPerson = context.RegHotels.Where(x => x.idFlat == editReg.nomerid && x.idClient == editReg.clientid && (editReg.dateTimePickerStart.Value >= x.startLive && x.endLive >= editReg.dateTimePickerStart.Value || editReg.dateTimePickerEnd.Value >= x.startLive && x.endLive >= editReg.dateTimePickerEnd.Value));

                            regHotel.desclive = editReg.CBDesclive.SelectedItem.ToString();
                            regHotel.startLive = editReg.dateTimePickerStart.Value;
                            regHotel.endLive = editReg.dateTimePickerEnd.Value;
                            regHotel.idClient = editReg.clientid;
                            regHotel.idFlat = editReg.nomerid;

                            client = db.Clients.Find(editReg.clientid);
                            {
                                client.countDaysLive = client.countDaysLive + (editReg.dateTimePickerEnd.Value - editReg.dateTimePickerStart.Value).Days;
                            }

                            if (queryPerson.ToList().Count > 0)
                            {
                                db.SaveChanges();
                                RegHotel(); // обновляем грид
                                MessageBox.Show("Объект изменён");
                            }

                            else if (query.ToList().Count > 0)
                            {
                                MessageBox.Show("Это дата уже занята");
                            }

                            else
                            {
                                db.SaveChanges();
                                RegHotel(); // обновляем грид
                                MessageBox.Show("Объект изменён");
                            }
                    }
                }

            }
            catch (System.NullReferenceException error) 
            {
                MessageBox.Show("Выберите таблицу", "Ошибка");
            }
        }

        //Оплата
        public void payForHotel() 
        {

            int indexRow = dataGridView.CurrentCell.RowIndex;

            int id = Convert.ToInt32(dataGridView.Rows[indexRow].Cells[0].Value);

            using (var context = new MyDbContext()) 
            {
                RegHotel regHotel = db.RegHotels.Find(id);

                var query = from x in context.HotelRooms
                            from y in context.RegHotels
                            from z in context.Clients
                            where y.idFlat == regHotel.idFlat && regHotel.idClient == y.idClient && regHotel.startLive == y.startLive && regHotel.endLive == y.endLive && x.idFlat == y.idFlat && z.idClient == y.idClient
                            select new
                            {
                                money = x.payment,
                                name = z.name,
                                surname = z.surname,
                                lastname = z.lastname,
                                nomer = y.idFlat,
                                startDays = y.startLive,
                                endDays = y.endLive,
                                count = z.countDaysLive
                            };

                Check check = new Check(this);
                

                foreach (var x in query.ToList()) 
                {
                    check.LFIO.Text = x.surname.ToString() + " " + x.name.ToString() + " " + x.lastname.ToString();
                    check.LNomer.Text = x.nomer.ToString();
                    check.LStartlive.Text = x.startDays.ToShortDateString().ToString();
                    check.LEndlive.Text = x.endDays.ToShortDateString().ToString();
                    check.LDays.Text = ((x.endDays - x.startDays).Days + 1).ToString();

                    if (x.count > 20) 
                    {
                        check.LSale.Text = "Есть";
                        int countDays = (x.endDays - x.startDays).Days + 1;
                        int summa = x.money * countDays;
                        int procent = (summa / 100) * 15;
                        summa = summa - procent;
                        check.LSumma.Text = summa.ToString();
                    }
                    else 
                    {
                        check.LSale.Text = "Отсутствует";
                        int countDays = (x.endDays - x.startDays).Days + 1;
                        int summa = x.money * countDays;
                        check.LSumma.Text = summa.ToString();
                    }
                    check.id = id;
                    check.Show();        
                }
            }
        }
        //вызов метода оплаты 
        private void BSendMoney_Click(object sender, EventArgs e)
        {
            payForHotel();
        }

        private void BImportExport_Click(object sender, EventArgs e)
        {
            ExportImport exportimport = new ExportImport();
            exportimport.Show();
        }

        private void BInfo_Click(object sender, EventArgs e)
        {
            InfoHotel infohotel = new InfoHotel();
            infohotel.Show();
        }
    }
}
