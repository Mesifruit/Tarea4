using System;
					
public class Program
{
	public static void Main()
	{
int veces = 0;
            float[] alturas = new float[5];
            float media = 0;
            float r = 0;
            do
            {
                Console.WriteLine("Dame una Altura : ");
                alturas[veces] = float.Parse(Console.ReadLine());
                veces++;
            }
            while (veces < 5);
            if (veces >= 5)
            {
                for (int i = 0; i < alturas.Length; i++)
                {
                    media = media + alturas[i];
                    r = media / veces;
                    if (alturas[i] > r)
                    {
                        Console.WriteLine("Mayor que el promedio :" + alturas[i]);
                    }
                    if (alturas[i] < r)
                    {
                        Console.WriteLine("Menor que el promedio :" + alturas[i]);
                    }
                }

                Console.WriteLine("Promedio :" + r);
            }	}
}