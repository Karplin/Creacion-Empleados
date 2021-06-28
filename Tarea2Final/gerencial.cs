using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Final
{
    class gerencial : Iusuario
    {

        static List<empleado> listaempleados = new List<empleado>();

        static gerencial tomargerencia;

        empleado empleadonuevo = new empleado();

        public void crear()
        {

            empleadonuevo.Categoria = "Gerencial";

            Console.Write("Coloque la cedula: ");
            empleadonuevo.Cedula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque el Nombre: ");
            empleadonuevo.Nombre = Console.ReadLine();

            Console.Write("Coloque el Apellido: ");
            empleadonuevo.Apellido = Console.ReadLine();

            Console.Write("Coloque el Email: ");
            empleadonuevo.Email = Console.ReadLine();

            Console.Write("Coloque el Telefono: ");
            empleadonuevo.Telefono = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque el Departamento: ");
            empleadonuevo.Departa = Console.ReadLine();

            Console.Write("Coloque el cargo: ");
            empleadonuevo.Cargo = Console.ReadLine();

            Console.Write("Coloque el Precio por hora: ");
            empleadonuevo.Precio_hora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Coloque las horas trabajadas: ");
            empleadonuevo.Horas_trabajo = Convert.ToInt32(Console.ReadLine());

            empleadonuevo.Salario_neto = empleadonuevo.Precio_hora * empleadonuevo.Horas_trabajo;
           
            
            empleadonuevo.Bono = Convert.ToInt32(empleadonuevo.Salario_neto * 0.50);

            empleadonuevo.Salario_total = empleadonuevo.Bono + empleadonuevo.Salario_neto;

       
            var ids = listaempleados;
            ids.Add(empleadonuevo);

            crearcodigo();
         

        }

        public void crearcodigo()
        {
            //----------------------GENERACION DE CODIGO-----------------
    
            string codigox = empleadonuevo.Departa.Substring(0, 3);

            var random = new Random();
            var rango = random.Next(1000, 9999);

            string codex = codigox + rango;

            empleadonuevo.Codigo = codex;
            //------------------------------------------------------------
        }



        public static void ver()
        {
            foreach (empleado ver in listaempleados)
            {
                Console.WriteLine("---------VER + COBRO---------------------");

                Console.WriteLine("Cedula: " + ver.Cedula);

                Console.WriteLine("Nombre: " + ver.Nombre);

                Console.WriteLine("Apellido: " + ver.Apellido);

                Console.WriteLine("Precio por hora: " + ver.Precio_hora);

                Console.WriteLine("Horas trabajadas: " + ver.Horas_trabajo);

                Console.WriteLine("Salario Neto: " + ver.Salario_neto);

                Console.WriteLine("Bono: " + ver.Bono);

                Console.WriteLine("Salario + Bono : " + ver.Salario_total);

                Console.WriteLine("-----------------------------------------");

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

        //  PATRON SINGLETON
        private gerencial()
        {
           
        }

        public static gerencial tomargerenciax()
        {
            if (tomargerencia == null)
            {
                tomargerencia = new gerencial();
                return tomargerencia;
            }
            else
            {
                Console.WriteLine("YA EXISTE UN EMPLEADO GERENCIAL");
                return null;
               
            }
        }


    }
}
