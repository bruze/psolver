using System;
using System.Collections;
using Psolver.Model;
namespace Psolver
{
	public class ProjectsManager
	{
		private static ProjectsManager instance;
		ArrayList projects = new ArrayList();
		public static ProjectsManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ProjectsManager();
				}
				return instance;
			}
		}
		private ProjectsManager()
		{
		}
	}
}

