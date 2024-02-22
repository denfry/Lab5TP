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
            circle = new Circle(5);
            triangle = new IsoscelesTriangle(6, 8);
            quadrant = new Quadrant(4);

            
            t = new Point();
        }

        private void PointSetActive(object sender, EventArgs e)
        { 
            t = new Point();
            label1.Text = "Активный класс: " + t.GetType().Name;
        }

        private void CircleSetActive(object sender, EventArgs e)
        {
            t = circle;
            label1.Text = "Активный класс: " + circle.GetType().Name;
        }

        private void TriangleSetActive(object sender, EventArgs e)
        {
            t = triangle;
            label1.Text = "Активный класс: " + triangle.GetType().Name;
        }

        private void QuadrantSetActive(object sender, EventArgs e)
        {
            t = quadrant;
            label1.Text = "Активный класс: " + quadrant.GetType().Name;
        }

        private void Square_O(object sender, EventArgs e)
        {
            if (t is Circle)
            {
                Circle activeCircle = (Circle)t;
                double result = activeCircle.CalculateArea();
                MessageBox.Show("Площадь_О: " + result);
            }
            else if (t is IsoscelesTriangle)
            {
                IsoscelesTriangle activeTriangle = (IsoscelesTriangle)t;
                double result = activeTriangle.CalculateArea();
                MessageBox.Show("Площадь_О: " + result);
            }
            else if (t is Quadrant)
            {
                Quadrant activeQuadrant = (Quadrant)t;
                double result = activeQuadrant.CalculateArea();
                MessageBox.Show("Площадь_О: " + result);
            }
            else if (t is Point)
            {
                Point activePoint = (Point)t;
                double result = activePoint.CalculateArea();
                MessageBox.Show("Площадь_О: " + result);
            }
        }

        private void Square_V(object sender, EventArgs e)
        {
            Point activeFigure = t;
            if (activeFigure != null)
            {
                double result = activeFigure.CalculateVirtualArea();
                MessageBox.Show("Площадь_В: " + result);
            }
        } // одной строчкой
        

        private void Diametr(object sender, EventArgs e)
        {
            if (t is Circle)
            {
                Circle activeCircle = (Circle)t;
                double result = activeCircle.GetDiameter();
                MessageBox.Show("Диаметр: " + result);
            }
            else
            {
                MessageBox.Show("Метод GetDiameter() для активного объекта не определен");
            }
        }

        private void Perimeter(object sender, EventArgs e)
        {
            if (t is IsoscelesTriangle)
            {
                IsoscelesTriangle activeTriangle = (IsoscelesTriangle)t;
                double result = activeTriangle.CalculatePerimetr();
                MessageBox.Show("Периметр: " + result);
            }
            else if (t is Quadrant)
            {
                Quadrant activeQuadrant = (Quadrant)t;
                double result = activeQuadrant.CalculatePerimeter();
                MessageBox.Show("Периметр: " + result);
            }
            else
            {
                MessageBox.Show("Метод GetPerimeter() для активного объекта не определен");
            }
        }

        private void Diagonal(object sender, EventArgs e)
        {
            if (t is Quadrant)
            {
                Quadrant activeQuadrant = (Quadrant)t;
                double result = activeQuadrant.CalculateDiagonal();
                MessageBox.Show("Диагональ: " + result);
            }
            else
            {
                MessageBox.Show("Метод GetDiagonal() для активного объекта не определен");
            }
        }
    }
}
