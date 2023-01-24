using LiriaVintimillaVisitor;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        double totalCosto = 0;
        int totalObjetos = 0;
        int totalClasificaciones = 0;

        //Estructura de objetos
        Elemento estructuraObjeto =
            new Elemento(89.0, "Botiquin",
            new Elemento(25.60, "Termometro",
            new ElementoL(
                new Elemento(35.8, "Antibiotico",
                new Elemento(15.5, "Antiacido",
                new ElementoL(
                    new Elemento(12.8, "Aspirina", null),
                    new Elemento(56.6, "Anti inflamatorio",
                    null)))),
                new Elemento(12.8, "Gasa",
                new Elemento(23.5, "Cinta",
                new Elemento(112.5, "Tijeras", null))))));

        //Visitante la estructura de objetos
        Visitante visitante = new Visitante();
        visitante.ContarElementos(estructuraObjeto);

        totalCosto = visitante.Total;
        totalClasificaciones = visitante.Clasificaciones;
        totalObjetos = visitante.Conteo;

        Console.WriteLine("Se tiene {0} objetos con un costo de ${1} en {2} clasificaciones.", totalObjetos, totalCosto, totalClasificaciones);
    }
}

