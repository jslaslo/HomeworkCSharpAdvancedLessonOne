namespace HomeworkSeminarOne;

class Program
{
    static void Main(string[] args)
    {
        int firstValue;
        int secondValue;
        int result;

        if(args.Length == 3)
        {
            if (int.TryParse(args[0], out firstValue))
            {
                firstValue = int.Parse(args[0]);
            }
            else
            {
                Console.WriteLine("Не число");
                return;
            }
            if (int.TryParse(args[2], out secondValue))
            {
                secondValue = int.Parse(args[2]);
            }
            else
            {
                Console.WriteLine("Не число");
                return;
            }
        }
        else
        {
            Console.WriteLine("Некорректное количество аргументов");
            return;
        }
         
        switch (args[1])
        {
            case "+":
                result = firstValue + secondValue;
                Console.WriteLine($"Результат {result}");
                break;
            case "-":
                result = firstValue - secondValue;
                Console.WriteLine($"Результат {result}");
                break;
            case "/":
                if (firstValue == 0)
                {
                    Console.WriteLine("Нельзя делить на ноль");
                }
                else
                {
                    result = firstValue / secondValue;
                    Console.WriteLine($"Результат {result}");
                }                
                break;
            case "*":
                result = firstValue * secondValue;
                Console.WriteLine($"Результат {result}");
                break;

            default:
                Console.WriteLine($"Такой операции нет ({args[1]}), повторите попытку");
                break;
        }
    }
}

