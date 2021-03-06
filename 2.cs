using System;
					
public class Program
{
	public static void Main()
	{
		int veces = 0;
            float[] numeros = new float[5];
            do
            {
                Console.WriteLine("Dame un Numero :");
                numeros[veces] = float.Parse(Console.ReadLine());
                veces++;
            }
            while (veces < 5);
            if (veces >= 5)
            {
                Array.Reverse(numeros);
                Console.WriteLine("Sus numeros en reversa son : ");
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
	}
}