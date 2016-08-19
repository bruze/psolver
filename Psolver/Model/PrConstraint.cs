using System;
using System.Collections.Generic;
using Psolver.Model;
using KNFoundation;
using KNFoundation.KNKVC;
using Foundation.Presentation;
namespace Psolver
{
	using ConstraintOperator = Func<object, bool>;
	public class PrConstraint : KNKVOObserver
	{
		ConstraintOperator _operador = null;
		dynamic _valor = null;
		dynamic _llave = "";
		public PrConstraint(/*String llave, ConstraintOperator operador, dynamic esperado*/)
		{
			/*_llave = llave;
			_valor = esperado;
			_operador = operador;*/
			createAppointment();
		}
		public bool chequear()
		{
			return _operador(_valor);
		}
		protected void createAppointment()
		{
			SchAppointment app = new SchAppointment();
			app.AddObserverToKeyPathWithOptions(this, "key", KNKeyValueObservingOptions.KNKeyValueObservingOptionNew, null);
		}
		public void ObserveValueForKeyPathOfObject(String keyPath, Object obj, Dictionary<String, Object> change, Object context)
		{
			Console.WriteLine("OBSERVEEEE");
		}
	}
}

