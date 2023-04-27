using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urok2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Статик";
            label1.Parent = this;
            label1.Location = new Point(10, 10); // Location – позиция левого верхнего угла
            // label1.AutoSize = true; //подстройка размера статика под содержимое
            label1.Width = 200; // ширина статика
            label1.Height = 200; // вісота 
            label1.BorderStyle = BorderStyle.Fixed3D; // трехмерный стиль границ
            BackColor = Color.AliceBlue; // цвет
            label1.BackColor = Color.Orange; // цвет формы
            label1.ForeColor = Color.FromArgb(255, 0, 0); // цвет текста на статике
            label1.Cursor = Cursors.Hand; // тип курсора
            Opacity = 0.8; // степень прозрачности формы
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
                
        }

     
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Text = String.Format($"X={e.X}, Y={e.Y}");
        }
    }
}
