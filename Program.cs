using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        
        do
        {
            Console.Clear();
            Console.WriteLine("Ushbu dastur orqali \n \t 1: AddNumber \n\t 2: DivideNumber \n\t 3:CalculateGeron \n\t 4 : Eng kat sonta  \n\t 5:Faktarial \n\t 6: Yigindi  ");
            string str = Console.ReadLine();
            int userInput = Convert.ToInt32(str);
            switch (userInput)
            {
                case 1:
                    {
                       
                        AddNumber();
                        break;
                    }
                case 2:
                    {
                        
                        DivideNumber();
                        break;
                    }
                case 3:
                    {   
                        
                        CalculateGeron();
                        break;   
                    }
                case 4:
                    {
                        
                        EngKattaSon();
                        break;
                    }
                case 5:
                    {
                        
                        Factarial();
                        break;
                    }
                case 6:
                    {
                       
                        Yigindi();
                        break;
                    }
            }

            Console.Write("\n Yana davom etassizmi ? (Yes/No): ");
            string answer = Console.ReadLine().ToLower();
            if(answer == "No" || answer == "n" || answer == "no")
            {
                s = false;
            }
            Console.WriteLine();
        } while(s);
    static void AddNumber( )
        { 
            Console.Write("A sonini kiriting : ");
            string str1 = Console.ReadLine();
            double a = Convert.ToDouble(str1);
            Console.Write("B sonini kiriting : ");
            string str2 = Console.ReadLine();
            double b = Convert.ToDouble(str2);
            Console.WriteLine($"Natija : {a+b}");
        }
     static void DivideNumber( )
        {
            Console.Write("A sonini kiriting : ");
            string str1 = Console.ReadLine();
            double a = Convert.ToDouble(str1);
            Console.Write("B sonini kiriting : ");
            string str2 = Console.ReadLine();
            double b = Convert.ToDouble(str2);
            Console.WriteLine($"Natija : {a/b}");
            
        }
    static void CalculateGeron()
        {
            Console.Write("A sonini kiriting : ");
            string str1 = Console.ReadLine();
            double a = Convert.ToDouble(str1);
            Console.Write("B sonini kiriting : ");
            string str2 = Console.ReadLine();
            double b = Convert.ToDouble(str2);
            string str3 = Console.ReadLine();
            double c = Convert.ToDouble(str3);
            
             if (a + b > c && a + c > b && b + c > a)
                {
                    double p = (a + b + c) / 2;
                    double result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"Natija : {result}");
                            
                }
            else
                {
                    Console.WriteLine($"Natija : {0}");
                }
        }
    static void  EngKattaSon ()
        {
            Console.Write("A sonini kiriting : ");
            string str1 = Console.ReadLine();
            int  a = Convert.ToInt32(str1);
            Console.Write("B sonini kiriting : ");
            string str2 = Console.ReadLine();
            int  b = Convert.ToInt32(str2);
            Console.Write("C sonini kiriting : ");
            string str3 = Console.ReadLine();
            int  c = Convert.ToInt32(str3);
            Console.WriteLine( Math.Max(a,Math.Max(b,c)));
        }
            
    }

    private static void AddNumber()
    {
        throw new NotImplementedException();
    }

    static void Factarial()
    {
        Console.Write("A sonini kiriting : ");
        string str1 = Console.ReadLine();
        int a = Convert.ToInt32(str1);
        long res = 1;
        for (int i = 1;i <= a; i++)
        {
            res *= i;
        }
        Console.WriteLine($"Natija {res}" );
    }
    static void Yigindi()
    {
        Console.Write("A sonini kiriting : ");
        string str1 = Console.ReadLine();
        int a = Convert.ToInt32(str1);
        long res = 0;
        for (int i = 0;i <= a; i++)
        {
            res += i;
        }
        Console.WriteLine($"Natija {res}" );
    }
    
}

