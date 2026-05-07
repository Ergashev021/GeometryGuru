
bool s = true;
while(s)
{
    Console.Clear();
    Console.WriteLine("Ushbu dastur orqali \n \t 1: Arifmetik amallarni xisoblash \n\t 2: Geron Formulasi \n\t 3:Sonning kvadratini qaytarish \n\t 4 : Tub son  ");
    string str = Console.ReadLine();
    int userInput = Convert.ToInt32(str);
    switch (userInput)
    {
        case 1:
            {
                Console.Write("Ikki son ustida amallar ");
                Console.Write("a sonini kiriting : ");
                string inputFirst = Console.ReadLine();
                int a = Convert.ToInt32(inputFirst);
                Console.Write("b sonini kiriting : ");
                string inputSecond = Console.ReadLine();
                int b = Convert.ToInt32(inputSecond);
                Console.Write("Amalni kiriting (+, -, *, /): ");
                string amal = Console.ReadLine();
                if (amal == "+")
                {
                    Console.WriteLine("Natija: " + (a + b));
                }
                else if (amal == "-")
                {
                    Console.WriteLine("Natija: " + (a - b));
                }
                else if (amal == "*")
                {
                    Console.WriteLine("Natija: " + (a * b));
                }
                else if (amal == "/")
                {
                    if (b == 0)
                        Console.WriteLine("0 ga bolish mumkin emas ");
                    else
                        Console.WriteLine("Natija: " + (a / b));
                }
                else
                {
                    Console.WriteLine("Notogri amal kiritildi ");
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("Uchburchakni yuzini topish Geron Formulasi");
                Console.Write(" a tomon : ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write(" b tomon : ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write(" c tomon : ");
                double c = Convert.ToDouble(Console.ReadLine());
                if (a + b > c && a + c > b && b + c > a)
                {
                    double p = (a + b + c) / 2;
                    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                    Console.WriteLine("Yuza: " + S);
                }
                else
                {
                    Console.WriteLine("Bunday uchburchak mavjud emas ");
                }
                break;
            }
        case 3:
            {
                Console.Write("Sonning kvadratini topuvchi dastur : ");
                string inputFirst = Console.ReadLine();
                int a = Convert.ToInt32(inputFirst);
                Console.Write("b sonini kiriting : ");
                string inputSecond = Console.ReadLine();
                int b = Convert.ToInt32(inputSecond);
                Console.WriteLine(Math.Pow(a,b));
                break;   
            }
        case 4:
            {
                Console.WriteLine("Tub sonlarni yig'indisini topuvchi dastur ");
                int summa = 0;
                // string inputFirst = Console.ReadLine();
                // int a = Convert.ToInt32(inputFirst);
                // Console.Write("b sonini kiriting : ");
                // string inputSecond = Console.ReadLine();
                // int b = Convert.ToInt32(inputSecond);
                for (int i = 1;i <= 10;i++)
                {
                    int counter = 0;
                    for (int j = 2;j <= i;j++)
                    {
                        if (i % j == 0)
                        {
                            counter ++;
                           
                        }
                    }
                    if (counter == 1)
                    {
                        Console.Write($"-{i}-");
                         summa += i;
                    }

                }
                Console.WriteLine("Natija : " + summa);
                break;
            }
        default:
            Console.WriteLine("Bunday tugma mavjud emas ");
            break;

    }

    Console.Write("\n Yana davom etassizmi ? (Yes/No): ");
    string answer = Console.ReadLine().ToLower();
    if(answer == "No" || answer == "n")
    {
        s = false;
    }
    Console.WriteLine();
}

