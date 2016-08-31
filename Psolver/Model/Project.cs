using System;
using System.Collections;
using System.Collections.Generic;
using KNFoundation.KNKVC;
namespace Psolver.Model
{
	public class Project
	{
		String _nombre = "";
		Dictionary<String, object> restricciones = new Dictionary<string, object>();
		public Project(String nombre)
		{
			_nombre = nombre;
		}
		public void añadeRestriccion(String nombre, object valor)
		{
			restricciones.SetNullValueForKey(nombre);
			restricciones.SetValueForKey(valor, nombre);
		}
		public void removeConstraint(String nombre)
		{
			restricciones.SetNullValueForKey(nombre);
			restricciones.Remove(nombre);
		}
	}
}

