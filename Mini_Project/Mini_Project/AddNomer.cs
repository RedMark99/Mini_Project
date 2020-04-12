using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mini_Project.MyDbClass;

namespace Mini_Project
{
    public partial class AddNomer : Form
    {

        //Для обновления datagridview в форме AdminMenu https://stackoverflow.com/questions/2395624/how-to-refresh-datagridview-when-closing-child-form
        AdminMenu _owner;

        public AddNomer(AdminMenu owner)
        {
            InitializeComponent();
            AddComboxBox();
            CBCateogury.Text = "Выберите категорию";
            TBNomer.Text = "Номер";
            TBCountpeople.Text = "Кол-во людей";
            TBPayment.Text = "Цена";
            CBCateogury.DropDownStyle = ComboBoxStyle.DropDownList;
            //Для обновления datagridview в форме AdminMenu
            _owner = owner;
            this.FormClosing += new FormClosingEventHandler(this.AddNomer_FormClosing);
        }

        private void AddNomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshAddClient();
        }

        //Добавление в базу данных данные ----------------------------------------------------------- НАЧАЛО ------------------------------------------------------------------------
        public void addNomer()
        {
            using (var context = new MyDbContext())
            {
                var query = context.HotelRooms.Where(x => x.nomer == TBNomer.Text);

                if (TBCountpeople.Text == "Кол-во людей" || TBNomer.Text == "Номер" || TBPayment.Text == "Цена" || CBCateogury.Text == "Выберите категорию") 
                {
                    MessageBox.Show("Заполните все поля");
                }
                else 
                { 
                    var nomer = new HotelRoom()
                    {
                        nomer = TBNomer.Text,
                        category = CBCateogury.SelectedItem.ToString(),
                        countPeople = Convert.ToInt32(TBCountpeople.Text),
                        payment = Convert.ToInt32(TBPayment.Text)
                    };

                    if (query.ToList().Count < 1)
                    {
                        if (CBCateogury.Text != "Выберите категорию")
                        {
                            context.HotelRooms.Add(nomer);
                            context.SaveChanges();
                            MessageBox.Show("Добавлено");
                            this.Close();
                        }
                        else 
                        {
                            MessageBox.Show("Выберите категорию", "Ошибка");
                        }
                    }

                    else if (query.ToList().Count > 0)
                    {
                        MessageBox.Show("Такой номер уже существует");
                    }
                }

            }
        }

        public void AddComboxBox() 
        {
            CBCateogury.Items.Add("Люкс");
            CBCateogury.Items.Add("Полулюкс");
            CBCateogury.Items.Add("Обычный");
        }

        private void BAddNomer_Click(object sender, EventArgs e)
        {
            addNomer();
        }

        //Добавление в базу данных данные ----------------------------------------------------------- КОНЕЦ ------------------------------------------------------------------------

        //PlaceHolder для textBox ------------------------------------------------------------------- НАЧАЛО -----------------------------------------------------------------------
        private void TBNomer_Enter(object sender, EventArgs e)
        {
            if (TBNomer.Text == "Номер") 
            {
                TBNomer.Text = "";
            }
        }

        private void TBNomer_Leave(object sender, EventArgs e)
        {
            if (TBNomer.Text == "")
            {
                TBNomer.Text = "Номер";
            }
        }

        private void TBCountpeople_Enter(object sender, EventArgs e)
        {
            if (TBCountpeople.Text == "Кол-во людей")
            {
                TBCountpeople.Text = "";
            }
        }

        private void TBCountpeople_Leave(object sender, EventArgs e)
        {
            if (TBCountpeople.Text == "")
            {
                TBCountpeople.Text = "Кол-во людей";
            }
        }

        private void TBPayment_Enter(object sender, EventArgs e)
        {
            if (TBPayment.Text == "Цена")
            {
                TBPayment.Text = "";
            }
        }

        private void TBPayment_Leave(object sender, EventArgs e)
        {
            if (TBPayment.Text == "")
            {
                TBPayment.Text = "Цена";
            }
        }
        private void CBCateogury_Enter(object sender, EventArgs e)
        {
            if (CBCateogury.Text == "Выберите категорию")
                CBCateogury.Text = "";
        }

        private void CBCateogury_Leave(object sender, EventArgs e)
        {
            if (CBCateogury.Text == "")
                CBCateogury.Text = "Выберите категорию";
        }

        //PlaceHolder для textBox ------------------------------------------------------------------- КОНЕЦ -----------------------------------------------------------------------

        //ДЛЯ ПЕРЕТАСКИВАНИЯ ФОРМЫ
        private void AddNomer_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        // ДЛЯ ЗАКРЫТИЕ ФОРМЫ
        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) //Запрет на ввод букв
            {
                e.Handled = true;
            }
        }

        private void TBCountpeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) //Запрет на ввод букв
            {
                e.Handled = true;
            }
        }

        private void TBCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)8) return; //Запрет на ввод цифр (e.KeyChar == (char)8 разрешение работы backspace)
            e.Handled = true;
        }

        private void TBPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) //Запрет на ввод букв
            {
                e.Handled = true;
            }
        }


    }
}

