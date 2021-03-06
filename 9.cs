using System;
					
public class Program
{
	public static void Main()
	{
int num = 0;
            do
            {
                Console.WriteLine("Deme un numero : ");
                num = int.Parse(Console.ReadLine());
                for (int i = 0; i <= 12; i++)
                {
                    Console.WriteLine(num + "x" + i + "=" + (i * num));
                }
            }
            while (num > -1);	}
}