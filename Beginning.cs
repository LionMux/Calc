public class Beginning
{
    float one;
    float two;
    float result;
    char sign;
    public void FirstN()
    {
        bool OneInput = false;

        do
        {
            Console.Write("Введите первое число:");
            if (float.TryParse(Console.ReadLine(), out one))
            {
                OneInput = true;
            }
            else
            {
                Console.WriteLine("Некорректно введненное число");
            }
        }
        while (!OneInput);
        }
    public void Operation()
    {
        bool OpInput = false;
        do
        {
            Console.Write("Введите оператор (+, -, *, /): ");
            sign = Convert.ToChar(Console.ReadLine());
            if (sign == '+' || sign == '-' || sign == '*' || sign == '/')
            {
                OpInput = true;
            }
            else
            {
                Console.WriteLine("Некорректно введенный оператор, вы можете ввести только: +, -, *, /");
            }
        }
        while (!OpInput);
    }
    public void SecondN()
    {
        bool TwoInput = false;
        do
        {
            Console.Write("Введи второе число: ");
            if (float.TryParse(Console.ReadLine(), out two))
            {
                TwoInput = true;
            }
            else
            {
                Console.WriteLine("Некорректно введненное число");
            }
        }
        while (!TwoInput);
    }
    public void Result()
    {
        result = sign == '+' ? one + two :
                 sign == '-' ? one - two :
                 sign == '*' ? one * two :
                 sign == '/' && two != 0 ? one / two :
                 throw new ArgumentException("Некорректный ввод");
        string message = "";
        if (sign == '/' && two == 0)
        {
            message = "Деление на ноль";
        }
        else
        {
            message = $"{one} {sign} {two} = {result}";
        }
        Console.WriteLine(message);
    }
}