namespace csharp_design_patterns.behavioural.interpreter.implementation;

// Iterable collection class for Books
using System;

class AddExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;

    public AddExpression(IExpression leftExpression, IExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return _leftExpression.Interpret() + _rightExpression.Interpret();
    }
}

class SubtractExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;

    public SubtractExpression(IExpression leftExpression, IExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return _leftExpression.Interpret() - _rightExpression.Interpret();
    }
}
