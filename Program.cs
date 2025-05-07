using Trabajo_escuela_practica;
List<Escuela> escuelass = new List<Escuela>();
List<Curso> cursitos = new List<Curso>();
void CargarEscuela()
{

    do
    {
        Escuela escuela = new Escuela();
        Console.WriteLine("Ingrese el nombre de la escuela");
        escuela.Nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(escuela.Nombre))
        {
            break;
        }

        Console.WriteLine("Ingrese el nombre de la ciudad");
        escuela.Ciudad = Console.ReadLine();



        escuela.Cursos = new List<Curso>();
        do
        {
            Curso curso = new Curso();
            Console.WriteLine("Ingrese el nombre del curso:");
            curso.Nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(curso.Nombre))
            {
                break;
            }


            Profesor profesor = new Profesor();
            Console.WriteLine("Ingrese el nombre del profesor:");
            profesor.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del profesor:");
            profesor.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del profesor:");
            profesor.Sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el título del profesor:");
            profesor.Titulo = Console.ReadLine();
            curso.AsigarProfesor(profesor);


            curso.Alumnoss = new List<Alumnos>();


            do
            {
                Alumnos alumno = new Alumnos();
                Console.WriteLine("Ingrese el nombre del alumno:");
                alumno.Nombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(alumno.Nombre))
                    break; 

                Console.WriteLine("Ingrese el apellido del alumno:");
                alumno.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese el año del alumno:");
                alumno.Año = Console.ReadLine();

                curso.AgregarAlumnos(alumno);

            } while (true);


            escuela.Cursos.Add(curso);

        } while (true);


        escuelass.Add(escuela);

            } while (true) ;
        }


void mostrar()
{
	foreach (var escuelitas in escuelass)
	{

        Console.WriteLine($"Escuela: {escuelitas.Nombre} -Ciudad: {escuelitas.Ciudad}");
        foreach (var cursos in escuelitas.Cursos)
        {
        Console.WriteLine($"  Curso: {cursos.Nombre}");
            Console.WriteLine($"  Profesor: {cursos.profesor.Nombre} {cursos.profesor.Apellido} - Sueldo: {cursos.profesor.Sueldo} - Titulo: {cursos.profesor.Titulo}");
            foreach (var alumno in cursos.Alumnoss)
            {
                Console.WriteLine($"      Alumno: {alumno.Nombre} -Apellido {alumno.Apellido} - Año: {alumno.Año}");
            }
        }
    }


}


CargarEscuela();
Console.WriteLine("Presiona para visualizar el reporte.");
Console.ReadKey();
Console.WriteLine("____________________________");
mostrar();
Console.ReadKey();
Console.WriteLine("Presione una tecla para continuar y visualizar los datos");
Console.ReadKey();
Console.WriteLine("------------------------------------------------------------------------------");
mostrar();
Console.ReadKey();
