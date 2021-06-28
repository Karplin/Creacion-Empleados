using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Final
{
    class administrativo : Iusuario
    {
        static List<empleado> listaempleados = new List<empleado>();

        empleado empleadoadmin = new empleado();
        public void crear()
        {
          
           
            empleadoadmin.Categoria = "Administrativo";

            Console.Write("Coloque la cedula: ");
            empleadoadmin.Cedula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque el Nombre: ");
            empleadoadmin.Nombre = Console.ReadLine();

            Console.Write("Coloque el Apellido: ");
            empleadoadmin.Apellido = Console.ReadLine();

            Console.Write("Coloque el Email: ");
            empleadoadmin.Email = Console.ReadLine();

            Console.Write("Coloque el Telefono: ");
            empleadoadmin.Telefono = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque el Departamento: ");
            empleadoadmin.Departa = Console.ReadLine();

            Console.Write("Coloque el cargo: ");
            empleadoadmin.Cargo = Console.ReadLine();

            Console.Write("Coloque el Precio por hora: ");
            empleadoadmin.Precio_hora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque las horas trabajadas: ");
            empleadoadmin.Horas_trabajo = Convert.ToInt32(Console.ReadLine());

            empleadoadmin.Salario_neto = empleadoadmin.Precio_hora * empleadoadmin.Horas_trabajo;
            empleadoadmin.Bono = Convert.ToInt32(empleadoadmin.Salario_neto * 0.25);

            empleadoadmin.Salario_total = empleadoadmin.Bono + empleadoadmin.Salario_neto;


           
            var ids = listaempleados;

            ids.Add(empleadoadmin);

            crearcodigo();

        }
        public void crearcodigo()
        {
            //----------------------GENERACION DE CODIGO-----------------
            string codigox = empleadoadmin.Departa.Substring(0, 3);

            var random = new Random();
            var rango = random.Next(1000, 9999);

            string codex = codigox + rango;

            empleadoadmin.Codigo = codex;
            //------------------------------------------------------------

        }

        public static void ver()
        {
            foreach (empleado ver in listaempleados)
            {
                Console.WriteLine("------------------------------");

                Console.WriteLine("Cedula: " + ver.Cedula);

                Console.WriteLine("Nombre: " + ver.Nombre);

                Console.WriteLine("Apellido: " + ver.Apellido);

                Console.WriteLine("Precio por hora: " + ver.Precio_hora);

                Console.WriteLine("Horas trabajadas: " + ver.Horas_trabajo);

                Console.WriteLine("Salario Neto: " + ver.Salario_neto);

                Console.WriteLine("Bono: " + ver.Bono);

                Console.WriteLine("Salario + Bono : " + ver.Salario_total);

                Console.WriteLine("------------------------------");

            }

        }

        public static void recibo()
        {

            foreach (empleado ver in listaempleados)
            {

                Console.WriteLine("------------RECIBO DE PAGO------------------");

                Console.WriteLine("Codigo: " + ver.Codigo);

                Console.WriteLine("Nombre: " + ver.Nombre);

                Console.WriteLine("Categoria: " + ver.Categoria);

                Console.WriteLine("Precio por hora: " + ver.Precio_hora);

                Console.WriteLine("Horas trabajadas: " + ver.Horas_trabajo);

                Console.WriteLine("Salario Neto: " + ver.Salario_neto);

                Console.WriteLine("--------------------------------------------");

            }

        }


    }
}
