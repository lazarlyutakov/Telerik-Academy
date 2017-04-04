using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndImplementation
{
    public interface IResizable
    {
        void Resize(int weigthX, int weigthY);
        void ResizeX(int weigthX);
        void ResizeY(int weigthY);
    }
}
