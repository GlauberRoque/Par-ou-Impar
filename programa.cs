using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite um número: ");
            var num = int.Parse(Console.ReadLine());
           
            if(num % 2 == 0){
                Console.WriteLine("O número é par!");
            }else{
                Console.WriteLine("O número é ímpar!");
            }
	}
}