using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Empleado empTiempoCompleto = new EmpleadoCompleto("Xavier Elias Colon Duarte", 20, 30000);
            Empleado empTiempoParcial = new EmpleadoParcial("Pablo Gomez", 21, 15, 20);

           
            empTiempoCompleto.MostrarInfo();
            empTiempoCompleto.CalcularSalario();

            empTiempoParcial.MostrarInfo();
            empTiempoParcial.CalcularSalario();

            
            Console.ReadKey();
        }
    }



}
