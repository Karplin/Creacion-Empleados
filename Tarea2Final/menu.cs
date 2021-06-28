using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Final
{
    static class menu
    {
        static private int opcion1 = 0;
        static List<empleado> listaempleados = new List<empleado>();

        static public void desplegar() {

            do
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Creacion de Empleados");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("Seleccione una opción\n" +
                    "\n1.Crear Empleado"       +
                    "\n2.Visualizar Empleados + Cobro" +
                    "\n3.Recibo de Pago"       +
                    "\n4.Salir\n");

                int optionNum = 0;
                optionNum = Convert.ToInt32(Console.ReadLine());

                
        //------------------------------------------------------------------------------------------------------

                    switch (optionNum)
                {
                    //------------------ CREAR EMPLEADO ------------------
                    case 1:

                         Console.Clear();
                         Console.WriteLine("Seleccione el Tipo de Empleado\n" +
                         "\n1.Gerencial"       +
                         "\n2.Administrativo"  +
                         "\n3.Operativo"       +
                         "\n4.Volver\n");

                         int categoriax;
                         categoriax = int.Parse(Console.ReadLine());

                         Iusuario nuevox = crearempleado.GetIusuario(categoriax);

                        if (nuevox == null)
                        {
                            categoriax = 4;
                        }
                        else { nuevox.crear(); }

                        break;

                    //------------------ VISUALIZAR EMPLEADO ------------------
                    case 2:

                        Console.Clear();
                        gerencial.ver();
                        administrativo.ver();
                        operativo.ver();

                        break;

              
                    //------------------ RECIBO DE PAGO ------------------
                    case 3:

                        Console.Clear();
                        gerencial.recibo();
                        administrativo.recibo();
                        operativo.recibo();

                        break;

                    //------------------ SALIR ------------------
                    case 4:

                        Environment.Exit(0);

                        break;

                        default:
                        break;
                }
            


                 Console.WriteLine("Quieres volver al menu principal? Pulse 1, de lo contrario otro numero ");
                 opcion1 = Convert.ToInt32(Console.ReadLine());
                 Console.Clear();
                 Console.ReadKey();

             } while (opcion1 == 1);




         
        }

    }







}

