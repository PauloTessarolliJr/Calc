﻿using System;
using System.Collections;

namespace YAMP
{
    abstract class AssignmentPrefixOperator : AssignmentOperator
    {        
        BinaryOperator _child;

        public AssignmentPrefixOperator(BinaryOperator child) : base(child.Op)
        {
            _child = child;
        }

        public override Value Handle(Expression left, Expression right, Hashtable symbols)
        {
            var bottom = _child.Handle(left, right, symbols);
            return Assign(left, bottom, symbols);
        }
    }
}
