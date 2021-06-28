using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Final
{
    class operativo : Iusuario
    {
        static List<empleado> listaempleados = new List<empleado>();

        empleado empleadoope = new empleado();
        public void crear()
        {

            empleadoope.Categoria = "Operativo";


            Console.Write("Coloque la cedula: ");
            empleadoope.Cedula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque el Nombre: ");
            empleadoope.Nombre = Console.ReadLine();

            Console.Write("Coloque el Apellido: ");
            empleadoope.Apellido = Console.ReadLine();

            Console.Write("Coloque el Email: ");
            empleadoope.Email = Console.ReadLine();

            Console.Write("Coloque el Telefono: ");
            empleadoope.Telefono = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque el Departamento: ");
            empleadoope.Departa = Console.ReadLine();

            Console.Write("Coloque el cargo: ");
            empleadoope.Cargo = Console.ReadLine();

            Console.Write("Coloque el Precio por hora: ");
            empleadoope.Precio_hora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque las horas trabajadas: ");
            empleadoope.Horas_trabajo = Convert.ToInt32(Console.ReadLine());

            empleadoope.Salario_neto = empleadoope.Precio_hora * empleadoope.Horas_trabajo;
            empleadoope.Bono = Convert.ToInt32(empleadoope.Salario_neto * 0.10);

            empleadoope.Salario_total = empleadoope.Bono + empleadoope.Salario_neto;


            //----------------------GENERACION DE CODIGO-----------------
            string codigox = empleadoope.Departa.Substring(0, 3);

            var random = new Random();
            var rango = random.Next(1000, 9999);

            string codex = codigox + rango;

            empleadoope.Codigo = codex;
            //------------------------------------------------------------


            var ids = listaempleados;
            ids.Add(empleadoope);

            crearcodigo();

        }
        public void crearcodigo()
        {
            //----------------------GENERACION DE CODIGO-----------------
            string codigox = empleadoope.Departa.Substring(0, 3);

            var random = new Random();
            var rango = random.Next(1000, 9999);

            string codex = codigox + rango;

            empleadoope.Codigo = codex;
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
