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
    public partial class AddReg : Form
    {

        public int clientid;
        public int nomerid;
        MyDbContext db = new MyDbContext();

        AdminMenu _owner;

        public AddReg(AdminMenu owner)
        {
            InitializeComponent();
            Client();
            Nomer();
            addComboBox();
            CBDesclive.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePickerStart.Value = DateTime.Today;
            _owner = owner;
            this.FormClosing += new FormClosingEventHandler(this.AddReg_FormClosing);
        }

        private void AddReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshAddClient();
        }

        //ПЕРЕТАСКИВАНИЯ ОКНА
        private void AddReg_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        //Закрытие формы
        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Client --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
        public void Client()
        {
            dataGridViewClient.Rows.Clear();

            //Очищение dateGridView вместе с шапкой

            dataGridViewClient.SelectAll();
            dataGridViewClient.ClearSelection();
            dataGridViewClient.Columns.Clear();




            //Создаём заранее колонки
            dataGridViewClient.Columns.Add("Column0", "ID Клиента");
            dataGridViewClient.Columns.Add("Column1", "Имя");
            dataGridViewClient.Columns.Add("Column2", "Фамилия");
            dataGridViewClient.Columns.Add("Column3", "Отчество");
            dataGridViewClient.Columns.Add("Column4", "Дата рождения");
            dataGridViewClient.Columns.Add("Column5", "Серия паспорта");
            dataGridViewClient.Columns.Add("Column6", "Номер паспорта");
            dataGridViewClient.Columns.Add("Column7", "Кол-во дней прожитых");

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
                    dataGridViewClient.Rows.Add(item.Id, item.Name, item.Surname, item.Lastname, item.dateOfBirth, item.seriapassport, item.nomerpassport, item.countlive);
                }

                dataGridViewClient.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView

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

            dataGridViewNomer.Rows.Clear();

            //Очищение dateGridView вместе с шапкой

            dataGridViewNomer.SelectAll();
            dataGridViewNomer.ClearSelection();
            dataGridViewNomer.Columns.Clear();



            //Создаём заранее колонки
            dataGridViewNomer.Columns.Add("Column0", "ID Номер");
            dataGridViewNomer.Columns.Add("Column1", "Номер");
            dataGridViewNomer.Columns.Add("Column2", "Кол-во спальных мест");
            dataGridViewNomer.Columns.Add("Column3", "Категория");
            dataGridViewNomer.Columns.Add("Column4", "Цена");

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
                    dataGridViewNomer.Rows.Add(item.Id, item.Nomer, item.CountPeople, item.Category, item.Payment);
                }

                dataGridViewNomer.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView

                //Код для полного заполнения базы данных
                //BindingSource dbclient = new BindingSource();
                //dbclient.DataSource = typeof(Client);
                //context.Clients.ToList().ForEach(x => dbclient.Add(x));
                //dataGridView.DataSource = dbclient;



            }
        }
        //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //

        //Добавление
        private void BAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var query = context.RegHotels.Where(x => x.idFlat == nomerid && (dateTimePickerStart.Value >= x.startLive && x.endLive >= dateTimePickerStart.Value || dateTimePickerEnd.Value >= x.startLive && x.endLive >= dateTimePickerEnd.Value));

                    var regHotel = new RegHotel()
                    {
                        idClient = clientid,
                        idFlat = nomerid,
                        startLive = dateTimePickerStart.Value,
                        endLive = dateTimePickerEnd.Value,
                        desclive = CBDesclive.SelectedItem.ToString(),
                    };

                    Client client = db.Clients.Find(clientid);
                    {
                        client.countDaysLive = client.countDaysLive + (regHotel.endLive - regHotel.startLive).Days;
                    }

                    if (query.ToList().Count > 0)
                    {
                        MessageBox.Show("Это дата уже занята");
                    }

                    else
                    {
                        context.RegHotels.Add(regHotel);
                        context.SaveChanges();
                        db.SaveChanges();
                        MessageBox.Show("Добавлено");
                        this.Close();
                    }

                }
            }
            catch (System.NullReferenceException error) 
            {
                MessageBox.Show("В выпадающим списке выберете данные", "ошибка");
            }


        }
        //Клики по dateGridView
        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridViewClient.CurrentCell.RowIndex;

            clientid = Convert.ToInt32(dataGridViewClient.Rows[indexRow].Cells[0].Value);
        }

        private void dataGridViewNomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridViewNomer.CurrentCell.RowIndex;

            nomerid = Convert.ToInt32(dataGridViewNomer.Rows[indexRow].Cells[0].Value);
        }

        //comboBox добавление
        public void addComboBox() 
        {
            CBDesclive.Items.Add("Оплачено");
            CBDesclive.Items.Add("Не оплачено");
        }


        //Ограниечение времени Начало
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

        //Ограниечение времени Конец


    }
}
