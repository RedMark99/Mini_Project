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
    public partial class AddClient : Form
    {
        //Для обновления datagridview в форме AdminMenu https://stackoverflow.com/questions/2395624/how-to-refresh-datagridview-when-closing-child-form
        AdminMenu _owner;
        public AddClient(AdminMenu owner) // Модификация формы
        {
            InitializeComponent();

            TBName.Text = "Имя";
            TBSurname.Text = "Фамилия";
            TBLastname.Text = "Отчество";
            TBLogin.Text = "Логин";
            TBPassword.Text = "Пароль";
            TBSeriapassport.Text = "Серия Паспорта";
            TBNumerpassport.Text = "Номер Паспорта";
            TBDeschotel.Text = "Описание";

            //Для обновления datagridview в форме AdminMenu
            _owner = owner; 
            this.FormClosing += new FormClosingEventHandler(this.AddClient_FormClosing);
        }

        //Вызов метода из AdminMenu с помощью модификации 
        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshAddClient();
        }

        //Добавление в базу данных данные ----------------------------------------------------------- НАЧАЛО ------------------------------------------------------------------------
        public void addClient() 
        {
            using (var context = new MyDbContext())
            {

                if (TBName.Text == "Имя" || TBSurname.Text == "Фамилия" || TBLastname.Text == "Отчество" || TBLogin.Text == "Логин" || TBPassword.Text == "Пароль" || TBSeriapassport.Text == "Серия Паспорта" || TBNumerpassport.Text == "Номер Паспорта" || TBDeschotel.Text == "Описание")
                {
                    MessageBox.Show("Заполните все поля");
                }
                else 
                {  
                    var query = context.Clients.Where(x => x.login == TBLogin.Text || x.numberPassport == TBNumerpassport.Text);

                    var client = new Client()
                    {
                        name = TBName.Text,
                        surname = TBSurname.Text,
                        lastname = TBLastname.Text,
                        login = TBLogin.Text,
                        password = TBPassword.Text,
                        seriaPassport = TBSeriapassport.Text,
                        numberPassport = TBNumerpassport.Text,
                        dataOfBirth = DateTime.Parse(dateTimePickerDateOfBirth.Value.ToString()),
                        countDaysLive = 0,
                        deschotel = TBDeschotel.Text
                    };

                    if (query.ToList().Count < 1) 
                    {
                        context.Clients.Add(client);
                        context.SaveChanges();
                        MessageBox.Show("Добавлено");
                        this.Close();
                    }

                    else if (query.ToList().Count > 0) 
                    {
                        MessageBox.Show("Логин или Номер Пасспорта такой уже есть в базе данных");
                    }
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addClient();

        }

        //Добавление в базу данных данные ----------------------------------------------------------- КОНЕЦ ------------------------------------------------------------------------

        //PlaceHolder для textBox ------------------------------------------------------------------- НАЧАЛО -----------------------------------------------------------------------
        private void TBName_Enter(object sender, EventArgs e)
        {
            if (TBName.Text == "Имя")
            {
                TBName.Text = "";
            }
        }

        private void TBName_Leave(object sender, EventArgs e)
        {
            if (TBName.Text == "")
            {
                TBName.Text = "Имя";
            }
        }

        private void TBSurname_Enter(object sender, EventArgs e)
        {
            if (TBSurname.Text == "Фамилия")
            {
                TBSurname.Text = "";
            }
        }

        private void TBSurname_Leave(object sender, EventArgs e)
        {
            if (TBSurname.Text == "")
            {
                TBSurname.Text = "Фамилия";
            }
        }

        private void TBLastname_Enter(object sender, EventArgs e)
        {
            if (TBLastname.Text == "Отчество")
            {
                TBLastname.Text = "";
            }
        }

        private void TBLastname_Leave(object sender, EventArgs e)
        {
            if (TBLastname.Text == "")
            {
                TBLastname.Text = "Отчество";
            }
        }

        private void TBLogin_Enter(object sender, EventArgs e)
        {
            if (TBLogin.Text == "Логин")
            {
                TBLogin.Text = "";
            }
        }

        private void TBLogin_Leave(object sender, EventArgs e)
        {
            if (TBLogin.Text == "")
            {
                TBLogin.Text = "Логин";
            }
        }

        private void TBPassword_Enter(object sender, EventArgs e)
        {
            if (TBPassword.Text == "Пароль")
            {
                TBPassword.Text = "";
            }
        }

        private void TBPassword_Leave(object sender, EventArgs e)
        {
            if (TBPassword.Text == "")
            {
                TBPassword.Text = "Пароль";
            }
        }

        private void TBSeriapassport_Enter(object sender, EventArgs e)
        {
            if (TBSeriapassport.Text == "Серия Паспорта")
            {
                TBSeriapassport.Text = "";
            }
        }

        private void TBSeriapassport_Leave(object sender, EventArgs e)
        {
            if (TBSeriapassport.Text == "")
            {
                TBSeriapassport.Text = "Серия Паспорта";
            }
        }

        private void TBNumerpassport_Enter(object sender, EventArgs e)
        {
            if (TBNumerpassport.Text == "Номер Паспорта")
            {
                TBNumerpassport.Text = "";
            }
        }

        private void TBNumerpassport_Leave(object sender, EventArgs e)
        {
            if (TBNumerpassport.Text == "")
            {
                TBNumerpassport.Text = "Номер Паспорта";
            }
        }

        private void TBDeschotel_Enter(object sender, EventArgs e)
        {
            if (TBDeschotel.Text == "Описание")
            {
                TBDeschotel.Text = "";
            }
        }

        private void TBDeschotel_Leave(object sender, EventArgs e)
        {
            if (TBDeschotel.Text == "")
            {
                TBDeschotel.Text = "Описание";
            }
        }

        //PlaceHolder для textBox ------------------------------------------------------------------- КОНЕЦ -----------------------------------------------------------------------

        //ДЛЯ ПЕРЕТАСКИВАНИЯ ФОРМЫ
        private void AddClient_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        // ДЛЯ ЗАКРЫТИЕ ФОРМЫ
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ввод только цифр
        private void TBSeriapassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) //Запрет на ввод букв
            {
                e.Handled = true;
            }
        }

        private void TBNumerpassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) //Запрет на ввод букв
            {
                e.Handled = true;
            }
        }

        private void TBLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)8) return; //Запрет на ввод цифр (e.KeyChar == (char)8 разрешение работы backspace)
            e.Handled = true;
        }

        private void TBSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)8) return; //Запрет на ввод цифр (e.KeyChar == (char)8 разрешение работы backspace)
            e.Handled = true;
        }

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)8) return; //Запрет на ввод цифр (e.KeyChar == (char)8 разрешение работы backspace)
            e.Handled = true;

        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Today < dateTimePickerDateOfBirth.Value)
            {
                MessageBox.Show("Вы не могли родиться в будущем", "Ошибка");
                dateTimePickerDateOfBirth.Value = DateTime.Today;
            }
        }
    }
}
