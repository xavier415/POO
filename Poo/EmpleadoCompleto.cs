using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class EmpleadoCompleto : Empleado
    {
        private double salarioMensual;

        
        public EmpleadoCompleto(string nombre, int edad, double salarioMensual)
            : base(nombre, edad)
        {
            this.salarioMensual = salarioMensual;
        }

        
        public override void CalcularSalario()
        {
            Console.WriteLine($"El salario mensual de {Nombre} es: {salarioMensual} USD.");
        }
    }

    

}
