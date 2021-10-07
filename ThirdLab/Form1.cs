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
        public Form1()
        {
            InitializeComponent();
        }

        public void CalculateHandler(object sender, EventArgs e)
        {
            Calculate();
        }

        public void Calculate()
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
                        SummResult.Text = "";
                        DiffResult.Text = "";
                        DotResult.Text = "";
                        CrossResult.Text = "";
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
            }

            if (isFindExeption) return;

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

            MyVector vectorA = new MyVector(coordinatesA);
            MyVector vectorB = new MyVector(coordinatesB);
            MyVector tempVect;

            tempVect = vectorA + vectorB;
            SummResult.Text = $"->a+b({tempVect})";

            tempVect = vectorA - vectorB;
            DiffResult.Text = $"->a-b({tempVect})";

            DotResult.Text = $"{vectorA*vectorB}";

            CrossResult.Text = vectorA.CrossProductWith(vectorB);
        }

        private bool IsOnlyNumbers(String str)
        {
            if (String.IsNullOrEmpty(str)) return false;

            str = str.Replace(" ", "");
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
