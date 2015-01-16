using System;

namespace YAMP
{
    class ClearFunction : ArgumentFunction
    {
        public Value Function()
        {
            var count = Tokens.Instance.Variables.Count;
            Tokens.Instance.Variables.Clear();
            return new StringValue(count + " objects cleared.");
        }
    }
}
