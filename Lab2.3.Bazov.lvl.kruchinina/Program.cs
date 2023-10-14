//12 вариант
Console.Write("Введите число от 1 до 3:");
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        {

            int a = 45, b = 13, c = -23;
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            Console.WriteLine(min);
        }
        break;
    case 2:
        {

            int a = -31, b = 65, c = 12;
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            Console.WriteLine(min);

        }
        break;
    case 3:
        {
            int a = 52, b = -1, c = -33;
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            Console.WriteLine(min);
        }
        break;
}