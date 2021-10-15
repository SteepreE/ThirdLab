using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdLab
{
    public partial class Form1 : Form
    {
        private MyVector _vectorA;
        private MyVector _vectorB;

        public Form1()
        {
            InitializeComponent();
        }

        public void ChangesHandler(object sender, EventArgs e)
        {
            if (!IsValidFields()) return;

            InitVectors();

            DrawVector(_vectorA, Vec1Img);
            DrawVector(_vectorB, Vec2Img);

            Calculate();
        }

        private void InitVectors()
        {
            var coordinatesA = new Coordinates(
                double.Parse(Vec1XInput.Text),
                double.Parse(Vec1YInput.Text),
                double.Parse(Vec1ZInput.Text)
                );
            var coordinatesB = new Coordinates(
                double.Parse(Vec2XInput.Text),
                double.Parse(Vec2YInput.Text),
                double.Parse(Vec2ZInput.Text)
                );

            _vectorA = new MyVector(coordinatesA);
            _vectorB = new MyVector(coordinatesB);
        }


        private void Calculate()
        {
            Vec1Len.Text = $"{Math.Round(_vectorA.Length(), 2)}";
            Vec2Len.Text = $"{Math.Round(_vectorB.Length(), 2)}";

            SummResult.Text = $"->a+b({_vectorA + _vectorB})";
            DiffResult.Text = $"->a-b({_vectorA - _vectorB})";

            DotResult.Text = $"{_vectorA * _vectorB}";
            CrossResult.Text = $"axb({_vectorA.CrossProductWith(_vectorB)})";
        }

        private void DrawVector(MyVector vector, PictureBox pictBox)
        {
            Graphics g = pictBox.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);
            g.Clear(pictBox.BackColor);

            DrawCoordinateAxis(pictBox, g);

            int scale = 7;
            Point startPoint = new Point(pictBox.Width / 2, 
                                         pictBox.Height / 2);

            Point endPoint = new Point(pictBox.Width / 2 + (int)vector.GetCoordinates().x * scale,
                                       pictBox.Height / 2 - (int)vector.GetCoordinates().y * scale);
            
            g.DrawLine(pen, startPoint, endPoint);
        }

        private void DrawCoordinateAxis(PictureBox pictBox, Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);

            Point xAxisStart = new Point(pictBox.Width / 2, pictBox.Height);
            Point xAxisEnd = new Point(pictBox.Width / 2, 0);

            Point yAxisStart = new Point(0, pictBox.Height / 2);
            Point yAxisEnd = new Point(pictBox.Width, pictBox.Height / 2);

            g.DrawLine(pen, xAxisStart, xAxisEnd);
            g.DrawLine(pen, yAxisStart, yAxisEnd);
        }

        private bool IsOnlyNumbers(String str)
        {
            if (String.IsNullOrEmpty(str)) return false;

            str = str.Replace(" ", "");
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]) && str[i]!='-')
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsValidFields()
        {
            bool isFindExeption = false;

            foreach (var el in this.Controls)
            {
                if (el is TextBox)
                {
                    var textBox = el as TextBox;

                    if (!IsOnlyNumbers(textBox.Text))
                    {
                        isFindExeption = true;
                        textBox.BackColor = Color.Red;
                        ClearLabels();
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
            }

            return !isFindExeption;
        }

        private void ClearLabels()
        {
            SummResult.Text = "";
            DiffResult.Text = "";
            DotResult.Text = "";
            CrossResult.Text = "";
            Vec1Len.Text = "";
            Vec2Len.Text = "";
        }

        private void CreateRandomVectors(object sender, EventArgs e)
        {
            Random r = new Random();

            foreach (var el in this.Controls)
            {
                if (el is TextBox)
                {
                    var textBox = el as TextBox;

                    textBox.Text = $"{r.Next(21) - 10}";
                }
            }
        }
    }
}
