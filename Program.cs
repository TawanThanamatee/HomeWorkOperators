using System;

namespace FBI_CIA_NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Affiliate : ");
            a = Console.ReadLine();
            int n, c1, c2, c4, f3, f5, f6,n1,n3,nnn;
            Console.Write("Password : ");
            n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <= 999999)
            {
                if (a == "CIA")
                {
                    c1 = n % 10;
                    if (c1 % 3 == 0)
                    {
                        c2 = n / 10;
                        if (c2 % 10 != 1 && c2 % 10 != 3 && c2 % 10 != 5)
                        {
                            c4 = n / 1000;
                            if (c4 % 10 >= 6 && c4 % 10 != 8)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                if (a == "FBI")
                {
                    f6 = n / 100000;
                    if (f6 >= 4 && f6 <= 7)
                    {
                        f3 = n / 100;
                        if (f3 % 10 == 2 || f3 % 10 == 4 || f3 % 10 == 8 )
                        {
                            f5 = n / 10000;
                            if (f5 % 2 == 1)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                if(a=="NSA")
                {
                    n1 = n % 10;
                    if (n1 == 1 || n1 == 2 || n1 == 3 || n1 == 5 || n == 6) 
                    {
                        n3 = n / 100;
                        if(n3 % 3 == 0 || n3 % 2 != 0)
                        {
                            bool check7 = n.ToString().Contains(7.ToString());
                            if (check7)
                            {
                                Console.WriteLine("True");
                            }
                            else
                                Console.WriteLine("False");
                        }
                        else
                        Console.WriteLine("False");
                    }
                    else 
                    Console.WriteLine("False");
                }
                else
                Console.WriteLine("False");
            }
            else
                Console.WriteLine("ERROR");
        }
    }
}
