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
    public partial class Check : Form
    {
        internal int id;
        MyDbContext db = new MyDbContext();
        AdminMenu _owner;

        public Check(AdminMenu owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new FormClosingEventHandler(this.AddRegHotel_FormClosing);
        }
        private void AddRegHotel_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.RefreshAddClient();
        }

        private void Check_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BEnd_Click(object sender, EventArgs e)
        {
            RegHotel regHotel = db.RegHotels.Find(id);
            regHotel.desclive = "Оплачено";
            db.SaveChanges();
            this.Close();

        }
    }
}
