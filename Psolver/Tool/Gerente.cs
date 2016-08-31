using System;
using System.Collections;
using System.Collections.Generic;
using Psolver.Model;
namespace Psolver
{
	public class Gerente
	{
		Dictionary<String, Project> _proyectos = new Dictionary<string, Project>();
		static private Gerente _instancia = null;
		static public Gerente instancia()
		{
			if (_instancia == null) {
				_instancia = new Gerente();	
			}
			return _instancia;
		}
		static public Project crearProyecto(String nombre)
		{
			var proyecto = new Project(nombre);
			_instancia._proyectos.Add(nombre, proyecto);
			return proyecto;
		}
		private Gerente()
		{
		}
	}
}

