using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    class Coordinates
    {
        public double x;
        public double y;
        public double z;

        public Coordinates(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            this.x = x2 - x1;

            this.y = y2 - y1;

            this.z = z2 - z1;
        }

        public Coordinates(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Coordinates operator +(Coordinates coordinates1, Coordinates coordinates2)
        {
            return new Coordinates(
                coordinates1.x + coordinates2.x,
                coordinates1.y + coordinates2.y,
                coordinates1.z + coordinates2.z
                );
        }

        public static Coordinates operator -(Coordinates coordinates1, Coordinates coordinates2)
        {
            return new Coordinates(
                coordinates1.x - coordinates2.x,
                coordinates1.y - coordinates2.y,
                coordinates1.z - coordinates2.z
                );
        }
    }
}
