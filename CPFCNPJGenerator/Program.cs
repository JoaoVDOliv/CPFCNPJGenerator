using CPFCNPJGenerator;

Generator generator;
int menuIterator = 0;

Console.WriteLine("Welcome to Document Generator!");
Console.WriteLine("We generate CPF or CNPJ, as you prefer");
Console.WriteLine("--------------------------------------");
do
{
    Console.WriteLine("What you want to do?");
    Console.WriteLine("1. Generate CPF");
    Console.WriteLine("2. Generate CNPJ");
    Console.WriteLine("0. Exit");
    
    menuIterator = Convert.ToInt32(Console.ReadLine());

    switch (menuIterator)
    {                
        case 0:
            Console.WriteLine("Bye");
            break;

        case 1:
            generator = new Generator(true);

            Console.WriteLine(generator.process());
            break;
        
        default:
            Console.WriteLine("Invalid choice, try again");
            break;
    }

} while (menuIterator != 0);
