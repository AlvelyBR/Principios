namespace KISS
{
    public class Factura
    {
        private const decimal propinaFija = 0.10m;

        private decimal SumarPrecios(string precios)
        {

            return precios.Split(',').Select(decimal.Parse).Sum();

        }

        private decimal CalPropina(decimal total, decimal propinaAPagar)
        {

            return total * propinaAPagar;

        }

        public decimal ProcesodePago(string precios, bool propinaPersonalizada = false, decimal propinaAPagar = propinaFija )
        {
            var total = SumarPrecios(precios);
            var propina = CalPropina(total, propinaAPagar);

            return total + propina;

        }
    }
}