namespace YAGNI
{
    public class Program
    {
        static void Main(string[] args)
        {
            GestionProductos producto = new GestionProductos();

            Console.WriteLine("Selecione una opcion:\n \n1.Agregar Producto\n2.Eliminar producto");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Escriba el nombre del producto");
                        string name = Console.ReadLine();

                        Console.WriteLine("ingrese el precio del producto ");
                        decimal price = decimal.Parse(Console.ReadLine());
                   

                    producto.AddProduct(name, price);
                    }
                    catch (FormatException)
                    { Console.WriteLine("Entrada no valida. "); }

                    break;

                    case 2:
                    try
                    {
                        Console.WriteLine("Escribe el ID del producto que va a eliminar. ");
                        int id = int.Parse(Console.ReadLine());
                        producto.DeteleProducto(id);

                    }
                    catch (FormatException)
                    { Console.WriteLine("Entrada no valida. "); }

                    break;

                default:
                    Console.WriteLine("Opción no valida. ");
                    break;
            }
        }

    }
}