using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Final
{
    public class empleado
    {

        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Departa { get => departa; set => departa = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Precio_hora { get => precio_hora; set => precio_hora = value; }
        public int Horas_trabajo { get => horas_trabajo; set => horas_trabajo = value; }
        public int Salario_neto { get => salario_neto; set => salario_neto = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Bono { get => bono; set => bono = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public static List<empleado> listaempleados { get; set; }
        public int Salario_total { get => salario_total; set => salario_total = value; }



        private int cedula;
        private string nombre;
        private string apellido;
        private string email;
        private int telefono;
        private string departa;
        private string cargo;
        private int precio_hora;
        private int horas_trabajo;
        private int salario_neto;
        private string codigo;
        private int bono;
        private string categoria;
        private int salario_total;


    }
}
