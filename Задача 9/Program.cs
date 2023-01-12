Console.WriteLine("Мегамозг к Вашим услугам!");
Console.WriteLine("Введите два целых числа");
try
{
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите код операции: 1 - сложение, 2 - вычитание, 3 - произведение, 4 - частное");
int c = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int minus = 0;
int umnozh = 0;
int chastnoe = 0;


    if (c == 1)
    {
        sum = a + b;
        Console.WriteLine("Сумма равна {0} ", sum);
    }

    else if (c == 2)
    {
        minus = a - b;
        Console.WriteLine("Разность равна {0} ", minus);
    }

    else if (c == 3)
    {
        umnozh = a * b;
        Console.WriteLine("Произведение равно {0} ", umnozh);
    }

    else if (c == 4)
    {
        chastnoe = a / b;
        Console.WriteLine("Частное равно {0} ", chastnoe);
    }
    else 
    {
        Console.WriteLine("Выбран неверный код операции");
    }
}
    catch (DivideByZeroException)
{
    Console.WriteLine("На 0 делить нельзя");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
