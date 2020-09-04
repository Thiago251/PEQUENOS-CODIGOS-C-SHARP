/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 21/07/2020
 * Time: 13:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dividindo_dois_mumeros
{
	class Program
	{ 
		public static void Main(string[] args)
		{
			double divisao;
			Console.WriteLine("Digite o primeiro numero: ");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite o Segundo numero: ");
			double b = double.Parse(Console.ReadLine());
			divisao = a /b ;
			
			Console.WriteLine("resultado e " + divisao );
			
			
			
			
		}
	}
}