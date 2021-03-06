using System;
					
public class Program
{
	public static void Main()
	{
int[] diasEnMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;
            Console.WriteLine("Diga el mes : ");
            mes = int.Parse(Console.ReadLine());
            mes = mes - 1;
            Console.WriteLine("Este mes Tiene estos dias: " + diasEnMes[mes]);	}
}