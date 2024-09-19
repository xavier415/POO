using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{

    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        
        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

       
        public virtual void CalcularSalario()
        {
            Console.WriteLine("Calculando salario");
        }

        
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
    }