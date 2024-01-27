namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание: возведение в квадрат по методу Васи
            Console.WriteLine("Введите число, которое заканчивается на 5: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 10 != 5)
            {
                Console.WriteLine("Error number: Число должно заканчиваться на 5");
            }
            else
            {
                number = ((number / 10) * ((number / 10) + 1));
            }

            Console.WriteLine(number.ToString() + 25);
            Console.WriteLine("=======");

            //Задание 1: -

/*            //Задание 2: Пользователь вводит с клавиатуры четыре цифры
            //(каждая в свою переменную). Необходимо создать переменную
            //содержащее эти цифры в виде числа. Например,
            //если с клавиатуры введено 1, 5, 7, 8 тогда необходимо
            //сформировать число 1578. */            
            string numberString = "";
            
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Введите {i} переменную: ");
                numberString += Console.ReadLine();
            }

            if(int.TryParse(numberString, out int number2)) 
            {
                Console.WriteLine($"Число в переменной типа int: {number2}");
            }
            else 
            {
                Console.WriteLine("Error: не удалось успешно преобразовать.");
            }
            Console.WriteLine("=======");

        }
    }
}
