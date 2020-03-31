using System;

namespace HOME
{
    class Program
    {
        static void Main(string[] args)
        
             {
            {
               System.Console.WriteLine("Home Work 28-03");
            System.Console.WriteLine("exercise 2");
            Console.WriteLine("Please enter number A and B");
            int A,B,sum=0;
            A=Convert.ToInt32(Console.ReadLine());
            B=Convert.ToInt32(Console.ReadLine());
            for (int i=A; i<=B; i++)
            {
                sum+=i;
                if (i%2==0)
                Console.WriteLine("odds numbers= "+i);
            }
            Console.WriteLine("in sum A to B="+sum);
            Console.WriteLine("---------------------");
            Console.WriteLine("exercise 3");

            Console.WriteLine("Rectangle");
                
                for (int f=1; f<=15; f++)
                {
                    for (int d=1; d<=20; d++)
                    {
                        if ((d==1 || d==20)||(f==1 || f==15))
                        {
                            System.Console.Write("*");
                        }
                        else
                        {
                            System.Console.Write(" ");
                        }
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();

            Console.WriteLine("right-angle triangle");
                int b=20;
                for (int ie=1; ie<=b; ie++)
                {
                    for (int j=1; j<=b; j++)
                    {
                        if ((j==1 || ie==j || ie==b))
                        {
                            System.Console.Write("*");
                        }
                        else
                        {
                            System.Console.Write(" ");
                        }
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();


            Console.WriteLine("equilateral triangle");

               for (int i = 0; i <= 12; i++)
            {
                for (int k1 = 12 - i; k1 >= 0; k1--)
                {
                    Console.Write("  ");
                }
                if (i >= 2 && i < 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                Console.Write("\n");
            }

           Console.WriteLine("rhomb");
                for (int i = 0; i <= 12; i++)
            {
                for (int k1 = 12 - i; k1 >= 0; k1--)
                {
                    Console.Write("  ");
                }
                if (i >= 2 && i <= 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else if (i == 0 || i == 1)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                Console.Write("\n");
            }
            for (int i = 12; i >= 0; i--)
            {   if(i!=12)
                for (int k1 = -i + 12; k1 >= 0; k1--)
                {
                    Console.Write("  ");
                }
                if (i >= 2 && i < 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else if (i == 0 || i == 1)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                if(i!=12)Console.Write("\n");
            }
            Console.WriteLine("exercise 4");
            double P,sum1=1000;
            Console.Write("enter discount for every month=");
            P=Convert.ToDouble(Console.ReadLine());
            int k=0;
           while(sum1<=1100)
            {
                sum1+=sum1*(P/100);
                k++;
            Console.WriteLine("month="+k+" sum="+sum1);
            }
            Console.ReadKey();
        
           }
             }  
        }
    }

