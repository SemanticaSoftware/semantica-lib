using Semantica.Checks;
using Semantica.Intervals;

namespace Semantica.Lib.Tests.Core.Test._Mocks;

internal class TestIntervalBuilder
{
    private bool _isLeftOpen;
    private bool _isRightOpen;
    private decimal? _leftValue;
    private decimal? _rightValue;
        
    public TestIntervalBuilder WithLeftOpen(decimal left)
    {
        Guard.State(!_leftValue.HasValue, "left bound can only be defined once");
        _leftValue = left;
        _isLeftOpen = true;
        return this;
    }
        
    public TestIntervalBuilder WithLeftClosed(decimal left)
    {
        Guard.State(!_leftValue.HasValue, "left bound can only be defined once");
        _leftValue = left;
        _isLeftOpen = false;
        return this;
    }

    public TestIntervalBuilder WithRightOpen(decimal right)
    {
        Guard.State(!_rightValue.HasValue, "right bound can only be defined once");
        _rightValue = right;
        _isRightOpen = true;
        return this;
    }
        
    public TestIntervalBuilder WithRightClosed(decimal right)
    {
        Guard.State(!_rightValue.HasValue, "right bound can only be defined once");
        _rightValue = right;
        _isRightOpen = false;
        return this;
    }

    public TestInterval Build()
    {
        return new TestInterval(
                _leftValue.GetValueOrDefault(),
                _rightValue.GetValueOrDefault(),
                Interval.DetermineOpenKind(
                    !_leftValue.HasValue || _isLeftOpen,
                    !_rightValue.HasValue || _isRightOpen),
                Interval.DetermineBoundKind(!_leftValue.HasValue, !_rightValue.HasValue));
    }
}