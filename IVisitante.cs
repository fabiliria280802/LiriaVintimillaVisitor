using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiriaVintimillaVisitor
{
    interface IVisitante
    {
        //Un metodo visitar para cada tipo de elemento
        void Visitar(Elemento pElemento);
        void Visitar(ElementoL pElemento);
    }
}
