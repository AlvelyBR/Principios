namespace KISS
{
    class Program
    {
        static void Main(string[] args)
        {
            var factura = new Factura();

            try
            {

                Console.WriteLine("Ingrese los precios de los platos (separados por comas):");
                var precios = Console.ReadLine();

                Console.WriteLine("¿Desea agregar una propina personalizada? (s/n):");
                var respuesta = Console.ReadLine().ToLower();

                decimal totalFinal;



                if (respuesta == "s")
                {

                    Console.Write("Ingrese el porcentaje de propina: ");
                    var porcentaje = decimal.Parse(Console.ReadLine()) / 100;

                    totalFinal = factura.ProcesodePago(precios, true, porcentaje);
                }
                else
                {
                    totalFinal = factura.ProcesodePago(precios);
                }

                Console.WriteLine($"Tu cuenta final es de: {totalFinal:C}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

        }

    }

}