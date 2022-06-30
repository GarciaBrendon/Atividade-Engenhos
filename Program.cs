using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Digite um número: ");
		int numero = int.Parse(Console.ReadLine());
        int soma =0;
		
		
		for(int i=0; i <= numero; i++)
		{
            if (i%3==0 || i%5==0){
         
                soma= soma + i;
            }
			
		}
        	Console.Write("A soma dos multiplos de 3 e 5 até o numero informado é "+soma);


    }

}