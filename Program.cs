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

Console.WriteLine("Ikki nuqta orasidagi masofani topish formulasi");
Console.Write("X1 sonini kiriting : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1 sonini kiriting : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("X2 sonini kiriting : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2 sonini kiriting : ");
double y2 = Convert.ToDouble(Console.ReadLine());

 double masofa = Math.Sqrt(Math.Pow(x2-x1,2)) + Math.Pow(y2-y1,2);
 Console.WriteLine("Ntija : "+ masofa);
