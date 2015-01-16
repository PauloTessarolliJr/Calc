﻿using System;

namespace YAMP
{
    class RightDivideAssignmentOperator : AssignmentPrefixOperator
    {
        public RightDivideAssignmentOperator() : base(new RightDivideOperator())
        {
        }

        public override Operator Create()
        {
            return new RightDivideAssignmentOperator();
        }
    }
}
