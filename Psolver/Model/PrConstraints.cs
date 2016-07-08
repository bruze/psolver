using System;
using System.Collections;
namespace Psolver.Model
{
	public struct PrConstraints
	{
		static PrivPrConstraint createConstraint(ConstraintType type)
		{
			PrivPrConstraint newConstraint = new PrivPrConstraint();
			newConstraint.type = type;
			return newConstraint;
		}
		private struct PrivPrConstraint
		{
			internal ConstraintType type;
		}
		enum ConstraintType
		{
			hoursPerDays,
			overallDuration,
			weekTasksComplete
		}
		private ArrayList constraints;
		void addConstraint(PrivPrConstraint constraint)
		{
			constraints.Add(constraint);
		}
		void removeConstraint(PrivPrConstraint constraint)
		{
			constraints.Remove(constraint);
		}
	}
}

