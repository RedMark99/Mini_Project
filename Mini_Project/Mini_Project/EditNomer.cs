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
    public partial class EditNomer : Form
    {
        public EditNomer()
        {
            InitializeComponent();
            AddComboxBox();
        }
        public void AddComboxBox()
        {
            CBCateogury.Items.Add("Люкс");
            CBCateogury.Items.Add("Полулюкс");
            CBCateogury.Items.Add("Обычный");
        }

        private void EditNomer_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
