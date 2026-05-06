// 2 - dars 
/*
Console.WriteLine("Ikki son ustida amallar ");
Console.Write("a sonini kiriting : ");
string inputFirst = Console.ReadLine();
int a = Convert.ToInt32(inputFirst);
Console.Write("b sonini kiriting : ");
string inputSecond = Console.ReadLine();
int b = Convert.ToInt32(inputSecond);
Console.WriteLine("Yig'indi : " + (a + b));
Console.WriteLine("Ayirma : " + (a - b));
Console.WriteLine("Ko'paytma : " + (a * b));
Console.WriteLine("Bo'linma : " + (a / b)); */

/*string userInput = Console.ReadLine();
decimal userNumber = Convert.ToDecimal(userInput);
Console.WriteLine(userNumber+1);*/

/*Console.WriteLine("Ikki nuqta orasidagi masofani topish formulasi");
Console.Write("X1 sonini kiriting : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1 sonini kiriting : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("X2 sonini kiriting : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2 sonini kiriting : ");
double y2 = Convert.ToDouble(Console.ReadLine());

 double masofa = Math.Sqrt(Math.Pow(x2-x1,2)) + Math.Pow(y2-y1,2);
 Console.WriteLine("Ntija : "+ masofa);*/
 // 5 - dars 
/* Console.Write("Bizning dasturimiz ikki turdagi amalni bajaradi 1-Arifmetik amal  2-Geometrik amal  :");
 string str = Console.ReadLine();
 int userInput = Convert.ToInt32(str);
 switch (userInput)
{
    case 1:
        {
            Console.WriteLine("Ikki son ustida amallar ");
            Console.Write("a sonini kiriting : ");
            string inputFirst = Console.ReadLine();
            int a = Convert.ToInt32(inputFirst);
            Console.Write("b sonini kiriting : ");
            string inputSecond = Console.ReadLine();
            int b = Convert.ToInt32(inputSecond);
            Console.WriteLine("Yig'indi : " + (a + b));
            Console.WriteLine("Ayirma : " + (a - b));
            Console.WriteLine("Ko'paytma : " + (a * b));
            Console.WriteLine("Bo'linma : " + (a / b));
            break;
        }
    case 2:
        {
            Console.WriteLine("Ikki nuqta orasidagi masofani topish formulasi");
            Console.Write("X1 sonini kiriting : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 sonini kiriting : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("X2 sonini kiriting : ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 sonini kiriting : ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double masofa = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
            Console.WriteLine("Ntija : "+ masofa);
            break;
        }
    default:
        Console.WriteLine("Bunday tugma mavjud emas ");
        break;

}*/
// 5-dars vazifasi 
bool s = true;
while(s)
{
    Console.Clear();
    Console.WriteLine("Ushbu dastur orqali \n \t 1: Arifmetik amallarni xisoblash \n\t 2: Geron Formulasi \n\t 3:Sonning kvadratini qaytarish ");
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

