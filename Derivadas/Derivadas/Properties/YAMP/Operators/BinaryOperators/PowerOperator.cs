using System;

namespace YAMP
{
	class PowerOperator : BinaryOperator
	{
		public PowerOperator () : base("^", 100)
		{
		}

        public override Operator Create()
        {
            return new PowerOperator();
        }
		
		public override Value Perform (Value left, Value right)
		{
			return left.Power(right);
		}
	}
}

