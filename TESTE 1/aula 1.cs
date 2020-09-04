/*
 * Created by SharpDevelop.
 * User: Thiago Oliveira
 * Date: 21/07/2020
 * Time: 10:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace aula_1
{
	class Program
	{
		 static void Main(string[] args)
		{
			
		 	Console.Write(" Digite um numero: " );
		 		double x = double.Parse(Console.ReadLine());
		 		
		 		while (x >=0.0){
		 	    		 		
		 	    double raiz = Math.Sqrt(x);
		 	    Console.WriteLine(raiz.ToString("F0"));
		 	    Console.Write(" Digite outro numero: " );
		 	    x = double.Parse(Console.ReadLine());
		 	
		 	
		 	
		}
	}
 }
}