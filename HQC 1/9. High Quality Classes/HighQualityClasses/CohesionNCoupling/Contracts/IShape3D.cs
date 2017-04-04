namespace CohesionNCoupling.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IShape3D
    {
        double Width { get; }

        double Height { get; }

        double Depth { get; }
    }
}
