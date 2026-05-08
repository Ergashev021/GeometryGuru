using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        bool s = true;
        while(s)
        {
            Console.Clear();
            Console.WriteLine("Ushbu dastur orqali \n \t 1: AddNumber \n\t 2: DivideNumber \n\t 3:CalculateGeron \n\t 4 : Eng kat sonta  \n\t 5:Faktarial \n\t 6: Yigindi  ");
            string str = Console.ReadLine();
            int userInput = Convert.ToInt32(str);
            switch (userInput)
            {
                case 1:
                    {
                        Console.Write("A sonini kiriting : ");
                        string str1 = Console.ReadLine();
                        double a = Convert.ToDouble(str1);
                        Console.Write("B sonini kiriting : ");
                        string str2 = Console.ReadLine();
                        double b = Convert.ToDouble(str2);
                        Console.WriteLine(AddNumber(a,b));
                        break;
                    }
                case 2:
                    {
                        Console.Write("A sonini kiriting : ");
                        string str1 = Console.ReadLine();
                        double a = Convert.ToDouble(str1);
                        Console.Write("B sonini kiriting : ");
                        string str2 = Console.ReadLine();
                        double b = Convert.ToDouble(str2);
                        Console.WriteLine(DivideNumber(a,b));
                        break;
                    }
                case 3:
                    {   
                        Console.Write("A sonini kiriting : ");
                        string str1 = Console.ReadLine();
                        double a = Convert.ToDouble(str1);
                        Console.Write("B sonini kiriting : ");
                        string str2 = Console.ReadLine();
                        double b = Convert.ToDouble(str2);
                        string str3 = Console.ReadLine();
                        double c = Convert.ToDouble(str3);
                        Console.WriteLine(CalculateGeron(a,b,c));
                        break;   
                    }
                case 4:
                    {
                        Console.Write("A sonini kiriting : ");
                        string str1 = Console.ReadLine();
                        int  a = Convert.ToInt32(str1);
                        Console.Write("B sonini kiriting : ");
                        string str2 = Console.ReadLine();
                        int  b = Convert.ToInt32(str2);
                        string str3 = Console.ReadLine();
                        int  c = Convert.ToInt32(str3);
                        Console.WriteLine(EngKattaSon(a,b,c));
                        break;
                    }
                case 5:
                    {
                        Console.Write("A sonini kiriting : ");
                        string str1 = Console.ReadLine();
                        int a = Convert.ToInt32(str1);
                        Console.WriteLine(Factarial(a));
                        break;
                    }
                case 6:
                    {
                        Console.Write("A sonini kiriting : ");
                        string str1 = Console.ReadLine();
                        int a = Convert.ToInt32(str1);
                        Console.WriteLine(Yigindi(a));
                        break;
                    }
            }

            Console.Write("\n Yana davom etassizmi ? (Yes/No): ");
            string answer = Console.ReadLine().ToLower();
            if(answer == "No" || answer == "n")
            {
                s = false;
            }
            Console.WriteLine();
        }
    static double AddNumber( double x,double y)
        { 
            return Math.Abs(x) + Math.Abs(y);
        }
     static double DivideNumber( double x,double y)
        {
            return x / y;
        }
    static double CalculateGeron(double a,double b, double c)
        {
            
             if (a + b > c && a + c > b && b + c > a)
                {
                    double p = (a + b + c) / 2;
                    double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return result;
                            
                }
            else
                {
                    return 0;
                }
        }
    static int  EngKattaSon (int a,int b,int c)
        {
            return Math.Max(a,Math.Max(b,c));
        }
            
    }
    static long Factarial(int a)
    {
        long res = 1;
        for (int i = 1;i <= a; i++)
        {
            res *= i;
        }
        return res;
    }
    static long Yigindi(int a)
    {
        long res = 0;
        for (int i = 0;i <= a; i++)
        {
            res += i;
        }
        return res;
    }
    
}

