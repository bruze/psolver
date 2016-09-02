using System;
using System.Collections;
using System.Collections.Generic;
using KNFoundation.KNKVC;
namespace Psolver.Model
{
	public class Project
	{
		private String _nombre = "";
		Dictionary<String, Restriccion> restricciones = new Dictionary<String, Restriccion>();
		public Project(String nombre)
		{
			_nombre = nombre;
		}
		public void añadeRestriccion(Restriccion restriccion)
		{
			var nombre = restriccion.nombre();
			restricciones.SetNullValueForKey(nombre);
			restricciones.SetValueForKey(restriccion, nombre);
		}
		public object valorRestriccion(String nombre)
		{
			if (restricciones.ContainsKey(nombre))
			{
				var restriccion = (Restriccion)restricciones.ValueForKey(nombre);
				return restriccion.valor();
			}
			return null;
		}
		public void removeConstraint(String nombre)
		{
			restricciones.SetNullValueForKey(nombre);
			restricciones.Remove(nombre);
		}
		public String nombre
		{
			get
			{
				return _nombre;
			}
		}
	}
}

