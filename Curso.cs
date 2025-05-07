using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_escuela_practica
{
    public class Curso
    {
        public string Nombre { get; set; }
        public List <Alumnos> Alumnoss { get; set; } = new List<Alumnos>();
        public Profesor profesor { get; set; } = new Profesor();


        public void AsigarProfesor(Profesor profesor)
        {

            this.profesor = profesor;

        }

        public void AgregarAlumnos(Alumnos alumnos)
        {
            this.Alumnoss.Add(alumnos);
        }
    }
}
