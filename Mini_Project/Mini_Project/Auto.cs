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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            TBPassword.Text = "Введите пароль";
            TBLogin.Text = "Введите логин";
            BHide.Text = "Показать";
            TBError.Visible = false;

            TBPassword.MaxLength = 16;
        }

        //PlaceHolder для textBox ------------------------------------------------------------------- НАЧАЛО -----------------------------------------------------------------------
        private void password_Enter(object sender, EventArgs e)
        {
            if (TBPassword.Text == "Введите пароль") 
            {
                TBPassword.Text = "";
                TBPassword.PasswordChar = '*';
            }
        }

        private void TBPassword_Leave(object sender, EventArgs e)
        {
            if (TBPassword.Text == "")
            {
                TBPassword.Text = "Введите пароль";
                TBPassword.PasswordChar = '\0';
            }
        }

        private void TBLogin_Enter(object sender, EventArgs e)
        {
            if (TBLogin.Text == "Введите логин")
            {
                TBLogin.Text = "";
            }
        }

        private void TBLogin_Leave(object sender, EventArgs e)
        {
            if (TBLogin.Text == "")
            {
                TBLogin.Text = "Введите логин";
            }
        }
        //PlaceHolder для textBox ------------------------------------------------------------------- КОНЕЦ -----------------------------------------------------------------------


        //ДЛЯ ПЕРЕТАСКИВАНИЯ ОКНА
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        //ОТКРЫТИЕ ФОРМ
        private void Test_Click(object sender, EventArgs e)
        {
            AdminMenu adminmenu = new AdminMenu();
            adminmenu.Show();
        }

        //ЗАКРЫТИЕ
        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //SHOW OR HIDE PASSWORD
        private void BHide_Click(object sender, EventArgs e)
        {

            if (BHide.Text == "Показать")
            {
                TBPassword.PasswordChar = '\0';
                BHide.Text = "Скрыть";
            }

            else if (BHide.Text == "Скрыть")
            {
                
                TBPassword.PasswordChar = '*';
                BHide.Text = "Показать";
            }
        }

        //ПРОВЕРКА ЛОГИНА И ПАРОЛЯ ЗАПРОС
        private void BAuto_Click(object sender, EventArgs e)
        {
            if (TBLogin.Text == "" || TBPassword.Text == "")
                return;

            using (var context = new MyDbContext()) 
            {
                var query = context.Clients.Where(x => x.login == TBLogin.Text && x.password == TBPassword.Text);

                if (TBLogin.Text == "RedMark" && TBPassword.Text == "markmark")
                {
                    AdminMenu adminmenu = new AdminMenu();
                    adminmenu.Show();
                    this.Visible = false;
                }
                else if (query.ToList().Count > 0)
                {
                    sendDate.login = TBLogin.Text;
                    sendDate.password = TBPassword.Text;
                    UserMenu usermenu = new UserMenu();
                    usermenu.Show();
                    this.Visible = false;
                }
                else
                {
                    TBError.Text = "Вы ввели логин/пароль неправильно";
                    TBError.Visible = true;
                }

            }
        }
    }
}
