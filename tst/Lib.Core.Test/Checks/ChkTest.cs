using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Checks;

namespace Semantica.Lib.Tests.Core.Test.Checks;

[TestClass]
public partial class ChkTest
{
    private const string leftReason = nameof(leftReason);
    private const string rightReason = nameof(rightReason);

    #region Operator &&

    [TestMethod]
    public void OperatorAnd_BothFail_Failed()
    {
        var result = Chk.Fail && Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }
        
    [TestMethod]
    public void OperatorAnd_BothPass_Passed()
    {
        var result = Chk.Pass && Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorAnd_LeftFail_Failed()
    {
        var result = Chk.Fail && Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }
        
    [TestMethod]
    public void OperatorAnd_LeftFail_LeftReason()
    {
        var result = Chk.Fail.Fails(leftReason) && Chk.Pass.Passes(rightReason);
        //ASSERT
        Assert.AreEqual(leftReason, result.Reason);
    }
        
    [TestMethod]
    public void OperatorAnd_LeftFail_LeftIsEvaluated()
    {
        Detector detector = new(false);
        var result = Chk.If(detector.Eval()) && Chk.If(true);
        //ASSERT
        Assert.IsTrue(detector.IsEvaluated);
    }
        
    [TestMethod]
    public void OperatorAnd_LeftError_RightEvalNotReached()
    {
        Detector detector = new();
        Detector rightDetector = new();
        try
        {
            var result = Chk.If(detector.Error) && Chk.If(rightDetector.Eval());
        }
        catch (IntentionalError){} ;
        //ASSERT
        Assert.IsFalse(rightDetector.IsEvaluated);
    }
        
    [TestMethod]
    public void OperatorAnd_LeftFail_RightShortCircuited()
    {
        Detector detector = new();
        var result = Chk.Fail && Chk.If(detector.Eval());
        //ASSERT
        Assert.IsFalse(detector.IsEvaluated, "detector.IsEvaluated");
    }
        
    [TestMethod]
    public void OperatorAnd_LeftPassRightRsn_ResultIsDetermined()
    {
        var result = Chk.Pass && Chk.Rsn.Pass;
        //ASSERT
        Assert.IsTrue(result.IsDetermined);
    }
        
    [TestMethod]
    public void OperatorAnd_RightFail_Failed()
    {
        var result = Chk.Pass && Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }
        
    [TestMethod]
    public void OperatorAnd_RightFail_RightReason()
    {
        var result = Chk.Pass.Passes(leftReason) && Chk.Fail.Fails(rightReason);
        //ASSERT
        Assert.AreEqual(rightReason, result.Reason);
    }

    #endregion
    #region Operator &

    [TestMethod]
    public void OperatorBitAnd_BothFail_Failed()
    {
        var result = Chk.Fail & Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }
        
    [TestMethod]
    public void OperatorBitAnd_BothPass_Passed()
    {
        var result = Chk.Pass & Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorBitAnd_LeftFail_Failed()
    {
        var result = Chk.Fail & Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }
        
    [TestMethod]
    public void OperatorBitAnd_RightFail_Failed()
    {
        var result = Chk.Pass & Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }

    #endregion
    #region Operator |

    [TestMethod]
    public void OperatorBitOr_BothFail_CombinedReason()
    {
        var result = Chk.Fail.Fails(leftReason) | Chk.Fail.Fails(rightReason);
        //ASSERT
        Assert.That.IsTrue(result.Reason?.Contains(leftReason));
        Assert.That.IsTrue(result.Reason?.Contains(rightReason));
    }
        
    [TestMethod]
    public void OperatorBitOr_BothFail_Failed()
    {
        var result = Chk.Fail | Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }
        
    [TestMethod]
    public void OperatorBitOr_BothPass_CombinedReason()
    {
        var result = Chk.Pass.Passes(leftReason) | Chk.Pass.Passes(rightReason);
        //ASSERT
        Assert.That.IsTrue(result.Reason?.Contains(leftReason));
        Assert.That.IsTrue(result.Reason?.Contains(rightReason));
    }
        
    [TestMethod]
    public void OperatorBitOr_BothPass_Passed()
    {
        var result = Chk.Pass | Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorBitOr_LeftPass_Passed()
    {
        var result = Chk.Pass | Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorBitOr_RightPass_Passed()
    {
        var result = Chk.Fail | Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorBitOr_LeftFail_RightReason()
    {
        var result = Chk.Fail.Fails(leftReason) | Chk.Pass.Passes(rightReason);
        //ASSERT
        Assert.AreEqual(rightReason, result.Reason);
    }
        
    [TestMethod]
    public void OperatorBitOr_LeftPass_LeftReason()
    {
        var result = Chk.Pass.Passes(leftReason) | Chk.Fail.Fails(rightReason);
        //ASSERT
        Assert.AreEqual(leftReason, result.Reason);
    }

    #endregion
    #region Operator ||

    [TestMethod]
    public void OperatorOr_BothFail_Failed()
    {
        var result = Chk.Fail || Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Failed);
    }
        
    [TestMethod]
    public void OperatorOr_BothPass_Passed()
    {
        var result = Chk.Pass || Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorOr_BothFail_BothReasons()
    {
        var result = Chk.Fail.Fails(leftReason) || Chk.Fail.Fails(rightReason);
        //ASSERT
        Assert.That.IsTrue(result.Reason?.Contains(leftReason));
        Assert.That.IsTrue(result.Reason?.Contains(rightReason));
    }
        
    [TestMethod]
    public void OperatorOr_BothPass_LeftReason()
    {
        var result = Chk.Pass.Passes(leftReason) || Chk.Pass.Passes(rightReason);
        //ASSERT
        Assert.AreEqual(leftReason, result.Reason);
    }
        
    [TestMethod]
    public void OperatorOr_LeftError_RightEvalNotReached()
    {
        Detector detector = new();
        Detector rightDetector = new();
        try
        {
            var result = Chk.If(detector.Error) || Chk.If(rightDetector.Eval());
        }
        catch (IntentionalError){}
        //ASSERT
        Assert.IsFalse(rightDetector.IsEvaluated);
    }
        
    [TestMethod]
    public void OperatorOr_LeftFail_LeftIsEvaluated()
    {
        Detector detector = new(false);
        var result = Chk.If(detector.Eval()) || Chk.Pass;
        //ASSERT
        Assert.IsTrue(detector.IsEvaluated);
    }
        
    [TestMethod]
    public void OperatorOr_LeftFailRightRsn_ResultIsDetermined()
    {
        var result = Chk.Fail || Chk.Rsn.Fail;
        //ASSERT
        Assert.IsTrue(result.IsDetermined);
    }
        
    [TestMethod]
    public void OperatorOr_LeftPass_LeftReason()
    {
        var result = Chk.Pass.Passes(leftReason) || Chk.Fail.Fails(rightReason);
        //ASSERT
        Assert.AreEqual(leftReason, result.Reason);
    }
        
    [TestMethod]
    public void OperatorOr_LeftPass_Passed()
    {
        var result = Chk.Pass || Chk.Fail;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorOr_LeftPass_RightShortCircuited()
    {
        Detector detector = new();
        var result = Chk.Pass || Chk.If(detector.Eval());
        //ASSERT
        Assert.IsFalse(detector.IsEvaluated);
    }
        
    [TestMethod]
    public void OperatorOr_RightFail_LeftReason()
    {
        var result = Chk.Pass.Passes(leftReason) || Chk.Fail.Fails(rightReason);
        //ASSERT
        Assert.AreEqual(leftReason, result.Reason);
    }
        
    [TestMethod]
    public void OperatorOr_RightPass_Passed()
    {
        var result = Chk.Fail || Chk.Pass;
        //ASSERT
        Assert.IsTrue(result.Passed);
    }
        
    [TestMethod]
    public void OperatorOr_RightPass_RightReason()
    {
        var result = Chk.Fail.Fails(leftReason) || Chk.Pass.Passes(rightReason);
        //ASSERT
        Assert.AreEqual(rightReason, result.Reason);
    }

    #endregion

    private class Detector
    {
        private readonly bool _val;

        public Detector(bool val = true)
        {
            _val = val;
        }

        public bool IsEvaluated { get; private set; } = false;

        public bool Eval()
        {
            IsEvaluated = true;
            return _val;
        }

        public bool Error
        {
            get {
                IsEvaluated = true;
                throw new IntentionalError();
            }
                
        }
    }

    private class IntentionalError : Exception
    {
        public IntentionalError(string? message = null) : base(message ?? "intentional error")
        {
        }
    }

}
