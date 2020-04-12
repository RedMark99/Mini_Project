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
    public partial class InfoHotel : Form
    {
        public InfoHotel()
        {
            InitializeComponent();
            AddComboxBox();
            CBCategory.SelectedIndex = 0;
            CBCategory2.SelectedIndex = 0;
        }

        private void InfoHotel_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        public void AddComboxBox()
        {
            CBCategory.Items.Add("Люкс");
            CBCategory.Items.Add("Полудюкс");
            CBCategory.Items.Add("Обычный");
            CBCategory.Items.Add("Все");
            CBCategory2.Items.Add("Люкс");
            CBCategory2.Items.Add("Полудюкс");
            CBCategory2.Items.Add("Обычный");
        }

        private void BSumcategory_Click(object sender, EventArgs e)
        {
            try {
                //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
                //Очищение dateGridView данных

                dataGridView.Rows.Clear();

                //Очищение dateGridView вместе с шапкой

                dataGridView.SelectAll();
                dataGridView.ClearSelection();
                dataGridView.Columns.Clear();

                //Создаём заранее колонки
                dataGridView.Columns.Add("Column0", "Категория");
                dataGridView.Columns.Add("Column1", "Кол-во номеров");

                //Подключение к базе данных MicroSoft Sql server
                if (CBCategory.SelectedItem.ToString() != "Все")
                {
                    using (var context = new MyDbContext())
                    {
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                        var query = from x in context.HotelRooms
                                    select new
                                    {
                                        id = x.idFlat,
                                        nomer = x.nomer,
                                        countPople = x.countPeople,
                                        payment = x.payment,
                                        category = x.category
                                    };

                        var res = from x in query
                                  join y in context.RegHotels
                                  on x.id equals y.idFlat
                                  where x.category == CBCategory.SelectedItem.ToString()
                                  group x by x.category into g
                                  select new
                                  {
                                      CategoryName = g.Key,
                                      Count = g.Select(x => x.nomer).Count()
                                  };

                        foreach (var item in res.ToList())
                        {
                            dataGridView.Rows.Add(item.CategoryName.ToString(), item.Count.ToString());
                        }

                        dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView



                    }
                }
                else
                {
                    using (var context = new MyDbContext())
                    {

                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                        var query = from x in context.HotelRooms
                                    select new
                                    {
                                        id = x.idFlat,
                                        nomer = x.nomer,
                                        countPople = x.countPeople,
                                        payment = x.payment,
                                        category = x.category
                                    };

                        var res = from x in query
                                  join y in context.RegHotels
                                  on x.id equals y.idFlat
                                  group x by x.category into g
                                  select new
                                  {
                                      CategoryName = g.Key,
                                      Count = g.Select(x => x.nomer).Count()
                                  };

                        foreach (var item in res.ToList())
                        {
                            dataGridView.Rows.Add(item.CategoryName.ToString(), item.Count.ToString());
                        }

                        dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView



                    }
                };
            }

            catch (System.NullReferenceException error)
            {
                MessageBox.Show("Выберите категорию номера в выпадающем списке", "Ошибка");
            }
        }

        private void BCountPople_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
                //Очищение dateGridView данных

                dataGridView.Rows.Clear();

                //Очищение dateGridView вместе с шапкой

                dataGridView.SelectAll();
                dataGridView.ClearSelection();
                dataGridView.Columns.Clear();

                //Создаём заранее колонки
                dataGridView.Columns.Add("Column0", "Имя");
                dataGridView.Columns.Add("Column1", "Фамилия");
                dataGridView.Columns.Add("Column2", "Отчество");
                dataGridView.Columns.Add("Column3", "Номер");
                dataGridView.Columns.Add("Column4", "Категория");
                dataGridView.Columns.Add("Column5", "Начало даты");
                dataGridView.Columns.Add("Column6", "Конец даты");

                //Подключение к базе данных MicroSoft Sql server
                if (CBCategory.SelectedItem.ToString() != "Все")
                {
                    using (var context = new MyDbContext())
                    {
                        //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                        var query = from x in context.HotelRooms
                                    where x.category == CBCategory.SelectedItem.ToString()
                                    select new
                                    {
                                        id = x.idFlat,
                                        nomer = x.nomer,
                                        countPople = x.countPeople,
                                        payment = x.payment,
                                        category = x.category
                                    };

                        var res = from x in query
                                  join y in context.RegHotels
                                  on x.id equals y.idFlat
                                  join z in context.Clients
                                  on y.idClient equals z.idClient
                                  where x.category == CBCategory.SelectedItem.ToString()
                                  select new
                                  {
                                      Name = z.name,
                                      Surname = z.surname,
                                      Lastname = z.lastname,
                                      nomer = x.nomer,
                                      category = x.category,
                                      startlive = y.startLive,
                                      endlive = y.endLive
                                  };

                        foreach (var item in res.ToList())
                        {
                            dataGridView.Rows.Add(item.Name, item.Surname, item.Lastname, item.category, item.nomer, item.startlive.ToShortDateString().ToString(), item.endlive.ToShortDateString().ToString());
                        }

                        dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView
                    }
                }
                else
                {
                    using (var context = new MyDbContext())
                    {
                        //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться
                        var query = from x in context.HotelRooms
                                    select new
                                    {
                                        id = x.idFlat,
                                        nomer = x.nomer,
                                        countPople = x.countPeople,
                                        payment = x.payment,
                                        category = x.category
                                    };

                        var res = from x in query
                                  join y in context.RegHotels
                                  on x.id equals y.idFlat
                                  join z in context.Clients
                                  on y.idClient equals z.idClient
                                  select new
                                  {
                                      Name = z.name,
                                      Surname = z.surname,
                                      Lastname = z.lastname,
                                      nomer = x.nomer,
                                      category = x.category,
                                      startlive = y.startLive,
                                      endlive = y.endLive
                                  };

                        foreach (var item in res.ToList())
                        {
                            dataGridView.Rows.Add(item.Name, item.Surname, item.Lastname, item.category, item.nomer, item.startlive.ToShortDateString().ToString(), item.endlive.ToShortDateString().ToString());
                        }

                        dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView
                    }
                };
            }

            catch (System.NullReferenceException error)
            {
                MessageBox.Show("Выберите категорию номера в выпадающем списке", "Ошибка");
            }
        }

        private void TBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.Value = dateTimePickerStart.Value;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                MessageBox.Show("Дата окончания проживания не может \nбыть раньше даты начало проживания", "Ошибка");
                dateTimePickerEnd.Value = dateTimePickerStart.Value;
            }
        }

        private void BRegpay_Click(object sender, EventArgs e)
        {

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
            //Очищение dateGridView данных

            dataGridView.Rows.Clear();

            //Очищение dateGridView вместе с шапкой

            dataGridView.SelectAll();
            dataGridView.ClearSelection();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("Column0", "Имя");
            dataGridView.Columns.Add("Column1", "Фамилия");
            dataGridView.Columns.Add("Column2", "Отчество");
            dataGridView.Columns.Add("Column3", "Номер");
            dataGridView.Columns.Add("Column4", "Категория");
            dataGridView.Columns.Add("Column5", "Начало даты");
            dataGridView.Columns.Add("Column6", "Конец даты");
            dataGridView.Columns.Add("Column7", "Кол-во дней");
            dataGridView.Columns.Add("Column8", "Сумма");
            dataGridView.Columns.Add("Column9", "Расчёт");

            using (var context = new MyDbContext())
            {
                //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться

                var query = context.RegHotels.Where(x => dateTimePickerStart.Value <= x.startLive && x.endLive <= dateTimePickerEnd.Value);

                

                var res = from x in query
                          from y in context.Clients
                          from z in context.HotelRooms
                          where x.idClient == y.idClient && z.idFlat == x.idFlat
                          select new
                          {
                              name = y.name,
                              surname = y.surname,
                              lastname = y.lastname,
                              startlive = x.startLive,
                              endlive = x.endLive,
                              nomer = z.nomer,
                              category = z.category,
                              summa = z.payment,
                              desc = x.desclive
                          };

                foreach (var item in res.ToList())
                {
                    int days = (item.endlive - item.startlive).Days + 1;
                    int summa = item.summa * days;
                    dataGridView.Rows.Add(item.name, item.surname, item.lastname, item.nomer, item.category, item.startlive.ToShortDateString().ToString(), item.endlive.ToShortDateString().ToString(), days.ToString(), summa.ToString(), item.desc);
                }

                dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView

            }
        }

        private void BReginfo_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //HotelRoom --------------------------------------------- DATA GRID VIEW ------------------------------------------------ //
                //Очищение dateGridView данных

                dataGridView.Rows.Clear();

                //Очищение dateGridView вместе с шапкой

                dataGridView.SelectAll();
                dataGridView.ClearSelection();
                dataGridView.Columns.Clear();

                dataGridView.Columns.Add("Column0", "Имя");
                dataGridView.Columns.Add("Column1", "Фамилия");
                dataGridView.Columns.Add("Column2", "Отчество");
                dataGridView.Columns.Add("Column3", "Номер");
                dataGridView.Columns.Add("Column4", "Категория");
                dataGridView.Columns.Add("Column5", "Начало даты");
                dataGridView.Columns.Add("Column6", "Конец даты");
                dataGridView.Columns.Add("Column7", "Кол-во дней");
                dataGridView.Columns.Add("Column8", "Сумма");
                dataGridView.Columns.Add("Column9", "Расчёт");

                using (var context = new MyDbContext())
                {
                    //Запрос для заполнения частично dataGridView без заранее созданых колонок не получиться

                    var query = context.RegHotels.Where(x => dateTimePickerStart.Value <= x.startLive && x.endLive <= dateTimePickerEnd.Value);

                    var query2 = from x in context.HotelRooms
                                 where x.category == CBCategory2.SelectedItem.ToString()
                                 select new
                                 {
                                     idFlat = x.idFlat,
                                     nomer = x.nomer,
                                     countPople = x.countPeople,
                                     payment = x.payment,
                                     category = x.category
                                 };

                    var res = from x in query
                              from y in context.Clients
                              from z in query2
                              where x.idClient == y.idClient && z.idFlat == x.idFlat
                              select new
                              {
                                  name = y.name,
                                  surname = y.surname,
                                  lastname = y.lastname,
                                  startlive = x.startLive,
                                  endlive = x.endLive,
                                  nomer = z.nomer,
                                  category = z.category,
                                  summa = z.payment,
                                  desc = x.desclive
                              };

                    foreach (var item in res.ToList())
                    {
                        int days = (item.endlive - item.startlive).Days + 1;
                        int summa = item.summa * days;
                        dataGridView.Rows.Add(item.name, item.surname, item.lastname, item.nomer, item.category, item.startlive.ToShortDateString().ToString(), item.endlive.ToShortDateString().ToString(), days.ToString(), summa.ToString(), item.desc);
                    }

                    dataGridView.AllowUserToAddRows = false; //Уберает снизу строку в dataGridView
                }

            }
            catch (System.NotSupportedException error)
            {
                MessageBox.Show("Выберите категорию номера в выпадающем списке", "Ошибка");
            }
        }
    }
}
