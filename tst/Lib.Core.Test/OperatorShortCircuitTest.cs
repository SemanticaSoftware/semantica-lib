using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantica.Lib.Tests.Core.Test;

[TestClass]
public class OperatorShortCircuitTest
{

    //False && False
    [TestMethod]
    public void OperatorAnd_LeftFalseRightFalse_LeftEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.False;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftFalseRightFalse_OperatorNotEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.False;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsFalse(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftFalseRightFalse_RightNotEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.False;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsFalse(right.IsBooleanEvaluated);
    }

    //False && True
    [TestMethod]
    public void OperatorAnd_LeftFalseRightTrue_LeftEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.True;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftFalseRightTrue_OperatorNotEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.True;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsFalse(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftFalseRightTrue_RightNotEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.True;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsFalse(right.IsBooleanEvaluated);
    }

    //True && False
    [TestMethod]
    public void OperatorAnd_LeftTrueRightFalse_LeftEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.False;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftTrueRightFalse_OperatorEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.False;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftTrueRightFalse_RightEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.False;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(right.IsBooleanEvaluated);
    }

    //True && True
    [TestMethod]
    public void OperatorAnd_LeftTrueRightTrue_LeftEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.True;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftTrueRightTrue_OperatorEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.True;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorAnd_LeftTrueRightTrue_RightEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.True;
        //ACT
        var result = ActAnd(left, right);
        //ASSERT
        Assert.IsTrue(right.IsBooleanEvaluated);
    }

    //False || False
    [TestMethod]
    public void OperatorOr_LeftFalseRightFalse_LeftEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.False;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftFalseRightFalse_OperatorEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.False;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftFalseRightFalse_RightEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.False;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(right.IsBooleanEvaluated);
    }

    //False || True
    [TestMethod]
    public void OperatorOr_LeftFalseRightTrue_LeftEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.True;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftFalseRightTrue_OperatorEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.True;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftFalseRightTrue_RightEvaluated()
    {
        var left = Feeler.False;
        var right = Feeler.True;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(right.IsBooleanEvaluated);
    }

    //True || False
    [TestMethod]
    public void OperatorOr_LeftTrueRightFalse_LeftEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.False;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftTrueRightFalse_OperatorNotEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.False;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsFalse(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftTrueRightFalse_RightNotEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.False;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsFalse(right.IsBooleanEvaluated);
    }

    //True || True
    [TestMethod]
    public void OperatorOr_LeftTrueRightTrue_LeftEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.True;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsTrue(left.IsBooleanEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftTrueRightTrue_OperatorNotEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.True;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsFalse(result.IsOperatorEvaluated);
    }

    [TestMethod]
    public void OperatorOr_LeftTrueRightTrue_RightNotEvaluated()
    {
        var left = Feeler.True;
        var right = Feeler.True;
        //ACT
        var result = ActOr(left, right);
        //ASSERT
        Assert.IsFalse(right.IsBooleanEvaluated);
    } 
    
    //Feel internal tests
    [TestMethod]
    public void Stop_OperatorCalled_NotIsBooleanEvaluated()
    {
        //ACT
        var result = Feeler.True.Stop();
        //ASSERT
        var evalResult = ! result;
        Assert.IsFalse(result.IsBooleanEvaluated);
    }

    [TestMethod]
    public void StopNotCalled_OperatorCalled_IsBooleanEvaluated()
    {
        //ACT
        var result = Feeler.True;
        var evalResult = ! result;
        //ASSERT
        Assert.IsTrue(result.IsBooleanEvaluated);
    }

    private static Feeler ActAnd(Feeler left, Feeler right)
    {
        var result = left && right;
        left.Stop();
        right.Stop();
        return result;
    }

    private static Feeler ActOr(Feeler left, Feeler right)
    {
        var result = left || right;
        left.Stop();
        right.Stop();
        return result;
    }

    private class Feeler
    {
        public Feeler(bool chk) : this(chk, false)
        {
        }
        
        private Feeler(bool chk, bool isOperatorEvaluated = false)
        {
            Chk = chk;
            IsOperatorEvaluated = isOperatorEvaluated;
            IsBooleanEvaluated = false;
            IsStopped = false;
        }

        public bool Chk { get; }

        public Feeler Stop()
        {
            IsStopped = true;
            return this;
        }

        public bool IsBooleanEvaluated { get; private set; }

        public bool IsOperatorEvaluated { get; }
        
        public bool IsStopped { get; private set; }

        public static Feeler operator &(Feeler left, Feeler right)
        {
            if (! left.IsStopped)
            {
                left.IsBooleanEvaluated = true;
            }
            if (! right.IsStopped)
            {
                right.IsBooleanEvaluated = true;
            }
            return new Feeler(left.Chk && right.Chk, true);
        }
        
        public static Feeler operator |(Feeler left, Feeler right)
        {
            if (! left.IsStopped)
            {
                left.IsBooleanEvaluated = true;
            }
            if (! right.IsStopped)
            {
                right.IsBooleanEvaluated = true;
            }
            return new Feeler(left.Chk || right.Chk, true);
        }

        public static bool operator !(Feeler chk)
        {
            if (! chk.IsStopped)
            {
                chk.IsBooleanEvaluated = true;
            }
            return ! chk.Chk;
        }

        public static bool operator true(Feeler chk)
        {
            if (! chk.IsStopped)
            {
                chk.IsBooleanEvaluated = true;
            }
            return chk.Chk;
        }

        public static bool operator false(Feeler chk)
        {
            if (! chk.IsStopped)
            {
                chk.IsBooleanEvaluated = true;
            }
            return ! chk.Chk;
        }

        public static Feeler False => new Feeler(false);
        public static Feeler True => new Feeler(true);
    }
}
