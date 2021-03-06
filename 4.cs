using System;
					
public class Program
{
	public static void Main()
	{
int veces = 0;
            int[] numeros = new int[10];
            int mayor = numeros[0];
            do
            {
                Console.WriteLine("Dame un Numero :");
                numeros[veces] = Convert.ToInt32(Console.ReadLine());
                veces++;
            }
            while (veces < 10);
            if (veces >= 10)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                    }
                }
                Console.WriteLine("Mayor :" + mayor);
            }	}
}