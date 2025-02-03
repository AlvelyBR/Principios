

namespace YAGNI
{
    public class GestionProductos
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Producto {name} agregado correctamente. " );
        }

        public void DeteleProducto(int id)
        {
            Console.WriteLine($"Producto de ID {id} eliminado. ");
        }
    }
}
