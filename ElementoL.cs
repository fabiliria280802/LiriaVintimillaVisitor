using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiriaVintimillaVisitor
{
    class ElementoL : Elemento
    {
        public ElementoL(Elemento pHijo, Elemento pSiguiente)
        {
            siguiente = pSiguiente;
            hijo = pHijo;
        }
        public override void Aceptar(IVisitante pVisitante)
        {
            //Se manda como parametro para que visitante
            //obtenga los datos
            pVisitante.Visitar(this);
        }
    }
}
