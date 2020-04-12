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
    public partial class EditReg : Form
    {

        internal int clientid;
        internal int nomerid;
        private bool converted;

        public EditReg()
        {
            InitializeComponent();
            Nomer();
            addComboBox();
            dateTimePickerStart.Value = DateTime.Today;
            CBDesclive.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void addComboBox()
        {
            CBDesclive.Items.Add("Оплачено");
            CBDesclive.Items.Add("Не оплачено");
        }


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

        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Клики по dateGridView

        //Для перетаскивания
        private void EditReg_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        //Ограничение времени Начало
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

        private void dataGridViewNomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dataGridViewNomer.CurrentCell.RowIndex;

            nomerid = Convert.ToInt32(dataGridViewNomer.Rows[indexRow].Cells[0].Value);
        }
        //Ограничение времени Конец
    }
}
