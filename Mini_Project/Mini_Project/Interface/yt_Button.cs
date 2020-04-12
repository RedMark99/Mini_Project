using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mini_Project
{
    public class yt_Button: Control
    {

        private StringFormat SF = new StringFormat();

        public Color SplashColor;

        private bool MouseEnterned = false;
        private bool MousePressed = false;

        public yt_Button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true); // Указываем флаги
            DoubleBuffered = true;

            Size = new Size(100, 30); //Размер

            BackColor = Color.Tomato;
            ForeColor = Color.White;
            SplashColor = Color.White;
            

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0,0, Width - 1, Height - 1);

            graph.DrawRectangle(new Pen(BackColor), rect);
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            if (MouseEnterned)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(60, SplashColor)), rect);
            }
            
            if (MousePressed)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }

        protected override void OnMouseEnter(EventArgs e) 
        {
            base.OnMouseEnter(e);

            MouseEnterned = true;

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEnterned = false;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }


    }
}
