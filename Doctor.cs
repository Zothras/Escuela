using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_escuela_practica
{
    public class Doctor
    {
        public string Nombre { get; set; } 
        public string Especialidad { get; set; }

        public List<Paciente> pacientes { get; set; } = new List<Paciente>();

        public void asignarpaciente(Paciente paciente)
        {
            this.pacientes.Add(paciente);
        }
    }
}
