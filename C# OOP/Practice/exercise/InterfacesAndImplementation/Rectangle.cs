using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndImplementation
{
    public class Rectangle : IShape, IMovable, IResizable
    {
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }


        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface()
        {
            return width * height;
        }

        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public void Resize(int weigthX, int weigthY)
        {
            width = width * weigthX;
            height = height * weigthY;
        }

        public void ResizeX(int weigthX)
        {
            width = width * weigthX;
        }

        public void ResizeY(int weigthY)
        {
            height = height * weigthY;
        }
    }
}
