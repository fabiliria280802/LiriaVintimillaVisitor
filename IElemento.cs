using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiriaVintimillaVisitor
{
    interface IElemento
    {
        void Aceptar(IVisitante pVisitante);
    }
}
