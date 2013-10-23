
using System;

namespace Excepciones
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				Proceso fun =  new Proceso();
				fun.Ejecutar();
				Console.ReadLine();
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally 
			{
				Console.WriteLine("Cerrando la lectura.");
			}
			
		
		}
	}
}