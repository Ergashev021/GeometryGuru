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

/*string userInput = Console.ReadLine();
decimal userNumber = Convert.ToDecimal(userInput);
Console.WriteLine(userNumber+1);*/
