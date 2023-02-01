using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;//запуск формы по центру экрана
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point[] polygonPoints = {
                new Point(100-65, 100-65), //координаты пятиугольника
                new Point(120-65, 350-65),
                new Point(220-65, 350-65),
                new Point(240-65, 220-65),
                new Point(220-65, 250-65),
               /* new Point(67,67),*/        
            };

            Graphics g = CreateGraphics();
            g.Clear(BackColor); //очистка
            g.TranslateTransform(this.Width / 2, this.Height / 2); 
            //поворот вместе с отрисовкой относительна центра формы
            for (int i = 0; i < 20; i++){
                g.DrawPolygon(Pens.Red, polygonPoints);//отрисовка
                g.RotateTransform(18);//поворот на 18 градусов
            }
        }

    }
}
