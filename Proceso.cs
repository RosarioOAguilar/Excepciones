using System;
using System.IO;
using System.Collections;
//using System;

namespace Excepciones
{

public class Proceso
	{	
		 private ArrayList Personas = new ArrayList();
		 private Registro persona = new Registro();
		 
		public Proceso()
		{
			this.persona = new Registro();
			this.Personas = new ArrayList();
		}
		public void Ejecutar()
		{
			lee();
		    IReg();
		}
		public void lee()
		{
		 string ubicacion;
			try
			{
				Console.WriteLine("Dame la ubicacion de el arcihvo");
				ubicacion = Console.ReadLine();
				//ubicacion = ("C:\\Users\\RosarioO\\Desktop\\Registro.txt");
				Console.Clear();
				Console.WriteLine("*******************************");
				
				StreamReader objReader = new StreamReader(ubicacion);
				
				string sLine= objReader.ReadLine();
				ArrayList arrText = new ArrayList();
	
					while (sLine != null)
					{
						ARes(sLine);
						sLine = objReader.ReadLine();	
					}
		             objReader.Close();
	
	
	               
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
		public void ARes(string sLine)
		{
			
				char[] delimiterChars = {'*'};
				string[] words = sLine.Split(delimiterChars);
				
				Registro persona = new Registro();
				persona.id = words[0];
				persona.nombre = words[1];
				persona.domicilio = words[2];
				persona.telefono = words [3];
			
				Personas.Add(persona);
				
	
	
		}
		public void IReg()
		{
			Console.WriteLine("Numero de registros: "+Personas.Count);
			foreach (object Registro in Personas)
	        {
				this.persona = (Registro) Registro;
				ITodo();
				
	        }

		}
		public void ITodo()
		{
			Console.WriteLine("*******************************");
			Console.Write("ID:");
			Console.WriteLine(this.persona.id);
			Console.Write("Nombre:");
			Console.WriteLine(this.persona.nombre);
			Console.Write("Telefono:");
			Console.WriteLine(this.persona.domicilio);
			Console.Write("Domicilio:");
			Console.WriteLine(this.persona.telefono);
		}
	}
}

