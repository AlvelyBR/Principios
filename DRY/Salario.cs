
namespace DRY
{
    public class Salario
    {
        private const decimal Tax = 0.18m;
        private const decimal Bonus = 0.05m;

        private decimal CalTax(decimal monto)
        {
            return monto * Tax;
        }

        private decimal CalBonus(decimal monto)
        {
            return monto * Bonus;
        }

        private decimal SalarioNeto(decimal salarioBruto)
        {
            decimal tax = CalTax(salarioBruto);
            decimal bonus = CalBonus(salarioBruto);

            return (salarioBruto - tax) + bonus;
        }

        public decimal CalForFullTime(decimal salarioBase)
        {
            return SalarioNeto(salarioBase);

        }

        public decimal CalForPartTime(decimal hoursRate, decimal hoursWorked)
        {
            decimal salarioBruto = hoursRate * hoursWorked;
            return SalarioNeto(salarioBruto);
        }
    }
}
