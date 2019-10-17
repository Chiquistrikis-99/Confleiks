using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// Tabla de multiplicar del 2
    /// </summary>
    public static void kk()
    {
        int tabla, numero;
        Console.WriteLine(" Lo siguiente es la tabla de multiplicar del 2 es la siguiente: \n ");
        for (tabla = 2; tabla <= 2; tabla++)
        {
            for (numero = 1; numero <= 10; numero++)
            {
                Console.WriteLine("por " + tabla + " * " + numero + " es: " + tabla * numero);// +"por: " + numero + tabla * numero
            }
        }
    }
}