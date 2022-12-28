
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите параметр а: ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Выберете \n" +
                "1 |  + \n" +
                "2 |  - \n" +
                "3 |  / \n" +
                "4 |  * \n\n");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Введите параметр b: ");

            int b = int.Parse(Console.ReadLine());


            if (c == 1)
            {
                double otv = a + b;
                Console.WriteLine("Ответ :" + otv);
            }
            else if (c == 2)
            {
                double otv = a - b;
                Console.WriteLine("Ответ :" + otv);
            }
            else if (c == 3)
            {
                double otv = a / b;
                Console.WriteLine("Ответ :" + otv);
            }
            else if (c == 4)
            {
                double otv = a * b;
                Console.WriteLine("Ответ :" + otv);
            }
        }
        catch (System.FormatException e)
        {
            Console.WriteLine("Неправильно введены данные перезапустите приложения!", e);
            
        }
        




        Console.ReadKey();
    }
}