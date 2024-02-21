using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5TP
{
    public partial class Form1 : Form
    {
        private Circle circle;
        private IsoscelesTriangle triangle;
        private Quadrant quadrant;
        private Point t;
        public Form1()
        {
            InitializeComponent();
            circle = new Circle(5); // Пример параметра, можно использовать любые значения
            triangle = new IsoscelesTriangle(6, 8); // Пример параметров, можно использовать любые значения
            quadrant = new Quadrant(4); // Пример параметра, можно использовать любые значения

            
            t = new Point();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Выводим имя класса или название нажатой кнопки
            label1.Text = "Активный класс: " + t.GetType().Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = circle;
            // Выводим имя класса или название нажатой кнопки
            label1.Text = "Активный класс: " + circle.GetType().Name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t = triangle;
            label1.Text = "Активный класс: " + triangle.GetType().Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t = quadrant;
            label1.Text = "Активный класс: " + quadrant.GetType().Name;
        }
    }
}
