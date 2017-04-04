using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemos
{
    public interface IResizable
    {
        void Resize(int weigthX, int wigthY);
        void ResizeByX(int weigthX);
        void ResizeByY(int weigthY);
    }
}
