using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoFlyweight
{
    interface IFlyweight
    {
        void ColocarNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string obtenerNombre();
    }
}
