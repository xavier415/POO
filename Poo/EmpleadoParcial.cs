using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class EmpleadoParcial : Empleado
    {
        private double salarioPorHora;
        private int horasTrabajadas;

        
        public EmpleadoParcial(string nombre, int edad, double salarioPorHora, int horasTrabajadas)
            : base(nombre, edad)
        {
            this.salarioPorHora = salarioPorHora;
            this.horasTrabajadas = horasTrabajadas;
        }

        
        public override void CalcularSalario()
        {
            double salario = salarioPorHora * horasTrabajadas;
            Console.WriteLine($"El salario semanal de {Nombre} es: {salario} USD.");
        }
    }
    }
