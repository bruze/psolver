using System;
namespace Psolver.Model
{
	public class Restriccion
	{
		private String _nombre = "restriccion vacia";
		private object _valor = null;
		public String nombre()
		{
			return _nombre;
		}
		public object valor()
		{
			return _valor;
		}
		public Restriccion(String nombre, object valor)
		{
			_valor = valor;
			_nombre = nombre;
		}
	}
}

