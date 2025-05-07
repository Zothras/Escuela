using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_escuela_practica
{
    public class Hospital
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

        public List<Doctor> Doc { get; set; } = new List<Doctor>();
    }
}
