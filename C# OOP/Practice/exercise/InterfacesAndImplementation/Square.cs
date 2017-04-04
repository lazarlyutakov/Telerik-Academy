using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndImplementation
{
    public class Square : IShape
    {
        private int x;
        private int y;
        private int size;

        public Square(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()
        {
            return size * size;
        }
    }
}
