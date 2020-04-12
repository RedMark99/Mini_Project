using Mini_Project.MyDbClass;
using System;
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
    public partial class UserMenu : Form
    {
        public string login;
        public string password;
        public int idclient;
        public int nomerid;
        MyDbContext db = new MyDbContext();

        public UserMenu()
        {
            InitializeComponent();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LToday.Text = DateTime.Today.ToShortDateString().ToString();
            PInfo.Visible = false;
            State();
            personInfo();
            BReg.BackColor = Color.FromArgb(255, 128, 0); // orange
        }

        //Для перетаскивания формы по рабочему столу ----------------------------- НАЧАЛО ------------------------------------------------------
        private void UserMenu_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        //Для перетаскивания формы по рабочему столу ----------------------------- КОНЕЦ ------------------------------------------------------

        public void State() 
        {
            login = sendDate.login;
            password = sendDate.password;
        }

        //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //

        //Ограниечение времени
        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today > dateTimePickerStart.Value)
            {
                MessageBox.Show("Даты ранее не могут быть выбраны", "Ошибка");
                dateTimePickerStart.Value = DateTime.Today;
            }
            else
            {
                dateTimePickerEnd.Value = dateTimePickerStart.Value;
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                MessageBox.Show("Дата окончания проживания не может \nбыть раньше даты начало проживания", "Ошибка");
                dateTimePickerEnd.Value = dateTimePickerStart.Value;
            }
        }
        //Ограниечение времени

        //Для закрытие формы
        private void TBClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        //Подсветка кнопок ---------------------------------------- НАЧАЛО ------------------------------------
        private void BInfoYour_Click(object sender, EventArgs e)
        {
            PInfo.Visible = true;
            if (PInfo.Visible == true)
            {
                BReg.BackColor = Color.FromArgb(26, 26, 26); // gray
                BInfoYour.BackColor = Color.FromArgb(255, 128, 0); // orange
            }
        }

        private void BReg_Click(object sender, EventArgs e)
        {
            PInfo.Visible = false;
            if (PInfo.Visible == false) 
            {
                BReg.BackColor = Color.FromArgb(255, 128, 0); // orange
                BInfoYour.BackColor = Color.FromArgb(26, 26, 26); // gray
            }
        }
        //Подсветка кнопок ---------------------------------------- Конец ------------------------------------

        //Запрос на получение данных для PInfo
        public void personInfo() 
        {
            using (var context = new MyDbContext())
            {
                var res = from x in context.Clients
                          where x.login == login && x.password == password
                          select new
                          {
                              Id = x.idClient,
                              Name = x.name,
                              Surname = x.surname,
                              Lastname = x.lastname,
                              dateOfBirth = x.dataOfBirth,
                              countlive = x.countDaysLive,
                              desc = x.deschotel
                          };
                foreach (var x in res) 
                {
                    LNSL.Text = x.Name.ToString() + " " + x.Surname.ToString() + " " + x.Lastname.ToString();
                    LDateofbirth.Text = x.dateOfBirth.ToShortDateString().ToString();
                    LDesc.Text = x.desc.ToString();
                    LCountlive.Text = x.countlive.ToString();
                    idclient = x.Id;
                }
            }
        }

        public void freenomer() 
        {
            using (var context = new MyDbContext())
            {
                var res = from x in context.RegHotels
                          from y in context.HotelRooms
                          where x.idFlat == y.idFlat && (dateTimePickerStart.Value >= x.startLive && x.endLive >= dateTimePickerStart.Value || dateTimePickerEnd.Value >= x.startLive && x.endLive >= dateTimePickerEnd.Value)
                          select new
                          {
                              idFlat = x.idFlat,
                              nomer = y.nomer,
                              countPeople = y.countPeople,
                              category = y.category,
                              payment = y.payment
                          };

                var res2 = context.HotelRooms.Select(x => x.idFlat).ToList().Except(res.Select(x => x.idFlat).ToList()).ToList();

                //var result = res2.Select(x => x.idFlat).Distinct().ToList();

                //DateGridView

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

                //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                var query = from x in context.HotelRooms
                            from y in res2
                            where x.idFlat == y
                            select new
                            {
                                Id = x.idFlat,
                                nomer = x.nomer,
                                countpeople = x.countPeople,
                                category = x.category,
                                payment = x.payment
                            };
                //Считываем в datagrid view
                foreach (var item in query.ToList())
                {
                    dataGridView.Rows.Add(item.Id, item.nomer, item.countpeople, item.category, item.payment);
                }

                dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView
            }
        }

        private void Test_Click(object sender, EventArgs e)
        {
            freenomer();
        }

        private void BAddreg_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {

                var res = from x in context.Clients
                where x.login == login && x.password == password
                select new
                {
                    Id = x.idClient,
                    Name = x.name,
                    Surname = x.surname,
                    Lastname = x.lastname,
                    dateOfBirth = x.dataOfBirth,
                    countlive = x.countDaysLive,
                    desc = x.deschotel
                };

                var regHotel = new RegHotel()
                {
                    idClient = idclient,
                    idFlat = nomerid,
                    startLive = dateTimePickerStart.Value,
                    endLive = dateTimePickerEnd.Value,
                    desclive = "Не оплачено"
                };

                Client client = db.Clients.Find(idclient);
                {
                    client.countDaysLive = client.countDaysLive + (regHotel.endLive - regHotel.startLive).Days;
                }

                    context.RegHotels.Add(regHotel);
                    context.SaveChanges();
                    db.SaveChanges();
                    MessageBox.Show("Вы забронировали номер");
                    freenomer();

            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridView.CurrentCell.RowIndex;

            nomerid = Convert.ToInt32(dataGridView.Rows[indexRow].Cells[0].Value);
        }

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
                          where x.idClient == z.idClient && x.idFlat == y.idFlat && x.idClient == idclient && z.idClient == idclient
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

        private void BQuery_Click(object sender, EventArgs e)
        {
            RegHotel();
        }

        private void BInfo_Click(object sender, EventArgs e)
        {
            InfoHotelPerson infohotelperson = new InfoHotelPerson();
            infohotelperson.Show();
        }
    }
}
