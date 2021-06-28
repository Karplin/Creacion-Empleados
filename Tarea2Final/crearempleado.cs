using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Final
{
   static class crearempleado
    {
        public static Iusuario GetIusuario(int menux)
        {
            if (menux == 1)
            {
                return gerencial.tomargerenciax();
            }

            if (menux == 2)
            {
                return new administrativo();
            }

            if (menux == 3)
            {
                return new operativo();
            }

            else {

                return new volver();

            }


        }
    }
}
