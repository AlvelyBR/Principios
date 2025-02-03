namespace DRY
{
    class Program
    {
        static void Main(string[] args)
        {
            var salario = new Salario();

            Console.WriteLine("Seleccione el tipo de empleado: \n1.Tiempo completo \n2.Por hora");
            string tipoEmpleado = Console.ReadLine();

            decimal totalSalary = 0;

            switch (tipoEmpleado)
            {
                
                case "1":
                    try
                    {
                        Console.WriteLine("Escriba el sueldo base: ");
                        decimal salarioBase = decimal.Parse(Console.ReadLine());
                        totalSalary = salario.CalForFullTime(salarioBase);
                    }
                    catch (FormatException) { Console.WriteLine("Entrada no valida, ingrese un número."); }

                    break;

                case "2":
                    try
                    {
                    Console.WriteLine("Escriba el sueldo por hora: ");
                    decimal hoursRate = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Escriba las horas trabajadas: ");
                    int hoursWorked = int.Parse(Console.ReadLine());
                    totalSalary = salario.CalForPartTime(hoursRate, hoursWorked);
                    }
                    catch (FormatException) { Console.WriteLine("Entrada no valida, ingrese un número."); }
                    break;

                

                default:
                    Console.WriteLine("Tipo de Empleado no existe");
                    return;

            }

            Console.WriteLine($"Salario total con impuestos y bonus incluidos: {totalSalary:C}");
        }
    }
}