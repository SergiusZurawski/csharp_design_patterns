namespace csharp_design_patterns.behavioural.interpreter.implementation;
using System;

class NumberExpression : IExpression
{
    private int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public int Interpret()
    {
        return _number;
    }
}

