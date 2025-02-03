namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            Logger logger = new Logger();

            Console.WriteLine("Seleccione el tipo de notificación:");
            Console.WriteLine("1. Email");
            Console.WriteLine("2. SMS");

            int option = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mensaje: ");
            string message = Console.ReadLine();

            switch (option)
            {
                case 1:
                    Console.Write("Ingrese el correo electrónico: ");
                    string email = Console.ReadLine();
                    emailService.SendEmail(email, message);
                    break;

                case 2:
                    Console.Write("Ingrese el número de teléfono: ");
                    string phoneNumber = Console.ReadLine();
                    smsService.SendSMS(phoneNumber, message);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            logger.LogNotification(message);
        }
    }
}