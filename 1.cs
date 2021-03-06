using System;
					
public class Program
{
	public static void Main()
	{
		int veces = 0;
            int media = 0;
            int[] numeros = new int[4];
            do
            {
                Console.WriteLine("Dame un Numero :");
                numeros[veces] = Convert.ToInt32(Console.ReadLine());
                veces++;
            }
            while (veces < 4);
            if (veces >= 4)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    media = media + Convert.ToInt32(numeros[i]);
                }
                double r = media / veces;
                Console.WriteLine("Media es : " + r);
            }
	}
}