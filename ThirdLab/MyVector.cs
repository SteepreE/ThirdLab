using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    class MyVector
    {
        private Coordinates _coordinates;

        public MyVector(Coordinates coordinates)
        {
            _coordinates = coordinates;
        }

        public MyVector(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            _coordinates = new Coordinates(x1, x2, y1, y2, z1, z2);
        }

        public MyVector(double x, double y, double z)
        {
            _coordinates = new Coordinates(x, y, z);
        }

        public static MyVector operator +(MyVector vec1, MyVector vec2)
        {
            return new MyVector(vec1._coordinates + vec2._coordinates);
        }

        public static MyVector operator -(MyVector vec1, MyVector vec2)
        {
            return new MyVector(vec1._coordinates - vec2._coordinates);
        }

        public static double operator *(MyVector vec1, MyVector vec2)
        {
            return vec1._coordinates.x * vec2._coordinates.x +
                   vec1._coordinates.y * vec2._coordinates.y +
                   vec1._coordinates.z * vec2._coordinates.z
                   ;
        }

        public Coordinates GetCoordinates()
        {
            return _coordinates;
        }

        public String CrossProductWith(MyVector vec)
        {
            double iResult = (this._coordinates.y * vec._coordinates.z) - (this._coordinates.z * vec._coordinates.y);
            double jResult = (this._coordinates.x * vec._coordinates.z) - (this._coordinates.z * vec._coordinates.x);
            double kResult = (this._coordinates.x * vec._coordinates.y) - (this._coordinates.y * vec._coordinates.x);

            return $"{iResult}i - {jResult}j + {kResult}k";
        }

        public override string ToString() { 
            return $"{_coordinates.x}, {_coordinates.y}, {_coordinates.z}"; 
        }

        public double Length()
        {
            return Math.Sqrt(
                Math.Pow(_coordinates.x, 2) +
                Math.Pow(_coordinates.y, 2) +
                Math.Pow(_coordinates.z, 2)
                );
        }
    }
}

