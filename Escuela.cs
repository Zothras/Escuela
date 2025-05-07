using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_escuela_practica
{
    public class Escuela
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set;}

        public List<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
