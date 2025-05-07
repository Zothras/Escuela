using Trabajo_escuela_practica;
List<Hospital> hospitales = new List<Hospital>();    
List<Doctor> doctores = new List<Doctor>();

void CargarHospital()
{
    do
    {
        Hospital hospital = new Hospital();

        // Ingreso del nombre del hospital
        Console.WriteLine("Ingrese el nombre del hospital:");
        hospital.Nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(hospital.Nombre))
            break;

        // Ingreso de ciudad con validación
        string ciudadInput;
        do
        {
            Console.WriteLine("Ingrese la ciudad:");
            ciudadInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ciudadInput))
            {
                Console.WriteLine("La ciudad no puede estar vacía. Intente de nuevo.");
            }
        } while (string.IsNullOrWhiteSpace(ciudadInput));
        hospital.Ciudad = ciudadInput;

        hospital.Doc = new List<Doctor>();

        // Carga de doctores
        while (true)
        {
            Doctor doctor = new Doctor();

            Console.WriteLine("Ingrese el nombre del doctor:");
            doctor.Nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(doctor.Nombre))
                break;

            string especialidadInput;
            do
            {
                Console.WriteLine("Ingrese su especialidad:");
                especialidadInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(especialidadInput))
                {
                    Console.WriteLine("La especialidad no puede estar vacía. Intente de nuevo.");
                }
            } while (string.IsNullOrWhiteSpace(especialidadInput));
            doctor.Especialidad = especialidadInput;

            doctor.pacientes = new List<Paciente>();

            // Carga de pacientes
            while (true)
            {
                Paciente paciente = new Paciente();

                Console.WriteLine("Ingrese el nombre del paciente:");
                paciente.Nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(paciente.Nombre))
                    break;

                int edad;
                while (true)
                {
                    Console.WriteLine("Ingrese su edad:");
                    string edadInput = Console.ReadLine();
                    if (!int.TryParse(edadInput, out edad) || edad <= 0)
                    {
                        Console.WriteLine("La edad debe ser un número válido mayor a 0. Intente de nuevo.");
                    }
                    else break;
                }
                paciente.Edad = edad;

                string diagnosticoInput;
                do
                {
                    Console.WriteLine("Ingrese su diagnóstico:");
                    diagnosticoInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(diagnosticoInput))
                    {
                        Console.WriteLine("El diagnóstico no puede estar vacío. Intente de nuevo.");
                    }
                } while (string.IsNullOrWhiteSpace(diagnosticoInput));
                paciente.Diagnostico = diagnosticoInput;

                doctor.asignarpaciente(paciente);
            }

            hospital.Doc.Add(doctor);
        }

        hospitales.Add(hospital);

    } while (true);
}

void mostrar()
{

    foreach (var hospitalitos in hospitales)
    {
        Console.WriteLine($"Hospital: {hospitalitos.Nombre} -Ciudad: {hospitalitos.Ciudad}");
        foreach (var doctor in hospitalitos.Doc)
        {
            Console.WriteLine($"Doctor: {doctor.Nombre} -Ciudad: {doctor.Especialidad}");
            foreach (var pacientes in doctor.pacientes)
            {
                Console.WriteLine($"Paciente: {pacientes.Nombre} -Ciudad: {pacientes.Edad} -Diagnostico: {pacientes.Diagnostico}");
            }
        }
    }


}

CargarHospital();
Console.WriteLine("Presione una tecla para continuar y visualizar los datos");
Console.ReadKey();
Console.WriteLine("------------------------------------------------------------------------------");
mostrar();
Console.ReadKey();