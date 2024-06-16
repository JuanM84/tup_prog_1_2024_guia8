using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
	internal class Program
	{
		static int[] arreglo = new int[100];
		static int contador = 0;

		#region Lógica
		static void CargarValor(int valor)
		{
			arreglo[contador++] = valor;
		}
		static void OrdenarValores()
		{
			int aux = 0;
			for (int i = 0; i < contador -1; i++)
			{
				for(int j = i + 1; j < contador; j++)
				{
					if (arreglo[i] > arreglo[j])
					{
						aux = arreglo[i];
						arreglo[i] = arreglo[j];
						arreglo[j] = aux;
					}
				}
			}
		}
		static int BusquedaValor(int valor) 
		{
			int indice=-1;
			int n = 0;
			
			while(n<contador && indice == -1)
			{
				if (arreglo[n] ==valor) indice = n;
				n++;
			}
			return indice;
		}
		#endregion

		#region Vistas
		static int Menu()
		{
			int opcion = 0;

			Console.Clear();
			Console.WriteLine("Selecione una opción:");
			Console.WriteLine("1 - Ingresar un valor.");
			Console.WriteLine("2 - Ordenar los valores ingresados.");
			Console.WriteLine("3 - Buscar un valor.");
			opcion = Convert.ToInt32(Console.ReadLine());

			return opcion; 

		}
		static void MenuCargarValor() 
		{
			int valor = 0;
			Console.Clear();
			Console.WriteLine("Ingrese el número a agregar:");
			valor = Convert.ToInt32(Console.ReadLine());
			CargarValor(valor);
			MostrarArreglo();
			Console.WriteLine("Presione cualquier tecla para volver al menú principal");
			Console.ReadKey();
		}
		static void MenuOrdenarArreglo()
		{
			Console.Clear();
			OrdenarValores();
			MostrarArreglo();
			Console.WriteLine("Presione cualquier tecla para volver al menú principal");
			Console.ReadKey();
		}
		static void MostrarArreglo() 
		{
			Console.Clear();
			Console.WriteLine("Listado de Valores");
			for (int i = 0; i < contador; i++) 
			{
				Console.Write("{0} ", arreglo[i]);
			}
			Console.WriteLine(" ");
		}
		static void MenuBuscarValor()
		{
			int valor = 0, posicion = -1;
			Console.Clear();
			Console.WriteLine("Ingrese el número a buscar:");
			valor = Convert.ToInt32(Console.ReadLine());
			posicion = BusquedaValor(valor);

			if(posicion != -1)
			{
				Console.WriteLine("El valor se encuentra en la posicion {0} del arreglo", posicion);
			}
			else
			{
				Console.WriteLine("El valor no se encuentra en el arreglo");
			}
			Console.WriteLine("");
			Console.WriteLine("Presione cualquier tecla para volver al menú principal");
			Console.ReadKey();
		}
		#endregion

		static void Main(string[] args)
		{
			int opcion;
			
			opcion = Menu();

			while (opcion != 0) 
			{
				switch (opcion) 
				{
					case 1: 
						{
							MenuCargarValor();
						} break;
					case 2: 
						{
							MenuOrdenarArreglo();
						} break;
					case 3: 
						{
							MenuBuscarValor();
						} break;
					default: { opcion = 0; break; }
				}
				opcion = Menu();
			}

			Console.ReadKey();
		}
	}
}
