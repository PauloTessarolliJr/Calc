﻿using System;

namespace YAMP
{
    class GammaFunction : StandardFunction
    {
        protected override ScalarValue GetValue(ScalarValue value)
        {
            if (value.ImaginaryValue == 0.0 && value.Value == Math.Floor(value.Value))
                return (value - 1).Faculty();
            else if (value.ImaginaryValue == Math.Floor(value.ImaginaryValue) && value.Value == 0.0)
                return (value - ScalarValue.I).Faculty();

            return Math.Sqrt(2 * Math.PI) * (value.Power(value - 0.5) as ScalarValue) * (-value).Exp();
        }
    }
}
