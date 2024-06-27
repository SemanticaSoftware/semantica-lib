using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Checks;

namespace Semantica.Lib.Tests.Core.Test.Checks;

public partial class ChkTest
{
    [TestClass]
    public class Pld
    {
        private const int leftIntPayload = 1;
        private const int rightIntPayload = 6;

        #region Operator &&

        [TestMethod]
        public void OperatorAnd_BothFail_Failed()
        {
            var result = Chk<int>.Fail && Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void OperatorAnd_BothPass_Passed()
        {
            var result = Chk<int>.Pass && Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorAnd_BothPass_LeftPayload()
        {
            var result = Chk<int>.Pass.Passes(leftIntPayload) && Chk<int>.Pass.Passes(rightIntPayload);
            //ASSERT
            Assert.AreEqual(leftIntPayload, result.Payload);
        }

        [TestMethod]
        public void OperatorAnd_BothPassLeftNoPayload_RightPayload()
        {
            var result = Chk<int>.Pass && Chk<int>.Pass.Passes(rightIntPayload);
            //ASSERT
            Assert.AreEqual(rightIntPayload, result.Payload);
        }

        [TestMethod]
        public void OperatorAnd_LeftError_RightEvalNotReached()
        {
            Detector detector = new();
            Detector rightDetector = new();
            try
            {
                var result = Chk.If<int>(detector.Error) && Chk.If<int>(rightDetector.Eval());
            }
            catch (IntentionalError) { };
            //ASSERT
            Assert.IsFalse(rightDetector.IsEvaluated);
        }

        [TestMethod]
        public void OperatorAnd_LeftFail_Failed()
        {
            var result = Chk<int>.Fail && Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void OperatorAnd_LeftFail_LeftIsEvaluated()
        {
            Detector detector = new(false);
            var result = Chk.If<int>(detector.Eval()) && Chk.If<int>(true);
            //ASSERT
            Assert.IsTrue(detector.IsEvaluated);
        }

        [TestMethod]
        public void OperatorAnd_LeftFail_LeftReason()
        {
            var result = Chk<int>.Fail.Fails(leftReason) && Chk<int>.Pass.Passes(rightReason);
            //ASSERT
            Assert.AreEqual(leftReason, result.Reason);
        }

        [TestMethod]
        public void OperatorAnd_LeftFail_RightShortCircuited()
        {
            Detector detector = new();
            var result = Chk<int>.Fail && Chk.If<int>(detector.Eval());
            //ASSERT
            Assert.IsFalse(detector.IsEvaluated, "detector.IsEvaluated");
        }

        [TestMethod]
        public void OperatorAnd_LeftFailRightPassPayload_NoPayload()
        {
            var result = Chk<int>.Fail && Chk.Pld.ForPass(rightIntPayload);
            //ASSERT
            Assert.That.IsDefault(result.Payload);
        }

        [TestMethod]
        public void OperatorAnd_LeftFailRightPassWithPayload_NoPayload()
        {
            var result = Chk<int>.Fail && Chk<int>.Pass.Passes(rightIntPayload);
            //ASSERT
            Assert.That.IsDefault(result.Payload);
        }

        [TestMethod]
        public void OperatorAnd_LeftPassRightUndeterminedPayload_RightPayload()
        {
            var result = Chk<int>.Pass && Chk.Pld.ForPass(rightIntPayload);
            //ASSERT
            Assert.AreEqual(rightIntPayload, result.Payload);
        }

        [TestMethod]
        public void OperatorAnd_LeftPassRightUndeterminedRsn_ResultIsDetermined()
        {
            var result = Chk<int>.Pass && Chk<int>.Rsn.Pass;
            //ASSERT
            Assert.IsTrue(result.Simplify().IsDetermined);
        }

        [TestMethod]
        public void OperatorAnd_LeftPassRightUndeterminedRsn_RightReason()
        {
            var result = Chk<int>.Pass && Chk.Rsn.ForPass<int>(rightReason);
            //ASSERT
            Assert.AreEqual(rightReason, result.Reason);
        }

        [TestMethod]
        public void OperatorAnd_RightFail_Failed()
        {
            var result = Chk<int>.Pass && Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void OperatorAnd_RightFail_RightReason()
        {
            var result = Chk<int>.Pass.Passes(leftReason) && Chk<int>.Fail.Fails(rightReason);
            //ASSERT
            Assert.AreEqual(rightReason, result.Reason);
        }

        #endregion
        #region Operator &

        [TestMethod]
        public void OperatorBitAnd_BothFail_Failed()
        {
            var result = Chk<int>.Fail & Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void OperatorBitAnd_BothPass_Passed()
        {
            var result = Chk<int>.Pass & Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorBitAnd_LeftFail_Failed()
        {
            var result = Chk<int>.Fail & Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void OperatorBitAnd_RightFail_Failed()
        {
            var result = Chk<int>.Pass & Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        #endregion
        #region Operator |

        [TestMethod]
        public void OperatorBitOr_BothFail_CombinedReason()
        {
            var result = Chk<int>.Fail.Fails(leftReason) | Chk<int>.Fail.Fails(rightReason);
            //ASSERT
            Assert.That.IsTrue(result.Reason?.Contains(leftReason));
            Assert.That.IsTrue(result.Reason?.Contains(rightReason));
        }

        [TestMethod]
        public void OperatorBitOr_BothFail_Failed()
        {
            var result = Chk<int>.Fail | Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void OperatorBitOr_BothPass_CombinedReason()
        {
            var result = Chk<int>.Pass.Passes(leftReason) | Chk<int>.Pass.Passes(rightReason);
            //ASSERT
            Assert.That.IsTrue(result.Reason?.Contains(leftReason));
            Assert.That.IsTrue(result.Reason?.Contains(rightReason));
        }

        [TestMethod]
        public void OperatorBitOr_BothPass_Passed()
        {
            var result = Chk<int>.Pass | Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorBitOr_LeftPass_Passed()
        {
            var result = Chk<int>.Pass | Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorBitOr_RightPass_Passed()
        {
            var result = Chk<int>.Fail | Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorBitOr_LeftFail_RightReason()
        {
            var result = Chk<int>.Fail.Fails(leftReason) | Chk<int>.Pass.Passes(rightReason);
            //ASSERT
            Assert.AreEqual(rightReason, result.Reason);
        }

        [TestMethod]
        public void OperatorBitOr_LeftPass_LeftReason()
        {
            var result = Chk<int>.Pass.Passes(leftReason) | Chk<int>.Fail.Fails(rightReason);
            //ASSERT
            Assert.AreEqual(leftReason, result.Reason);
        }

        #endregion
        #region Operator ||

        [TestMethod]
        public void OperatorOr_BothFail_Failed()
        {
            var result = Chk<int>.Fail || Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void OperatorOr_BothPass_Passed()
        {
            var result = Chk<int>.Pass || Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorOr_BothFail_BothReasons()
        {
            var result = Chk<int>.Fail.Fails(leftReason) || Chk<int>.Fail.Fails(rightReason);
            //ASSERT
            Assert.That.IsTrue(result.Reason?.Contains(leftReason));
            Assert.That.IsTrue(result.Reason?.Contains(rightReason));
        }

        [TestMethod]
        public void OperatorOr_BothPass_LeftReason()
        {
            var result = Chk<int>.Pass.Passes(leftReason) || Chk<int>.Pass.Passes(rightReason);
            //ASSERT
            Assert.AreEqual(leftReason, result.Reason);
        }

        [TestMethod]
        public void OperatorOr_BothPass_LeftPayload()
        {
            var result = Chk<int>.Pass.Passes(leftIntPayload) || Chk<int>.Pass.Passes(rightIntPayload);
            //ASSERT
            Assert.AreEqual(leftIntPayload, result.Payload);
        }

        [TestMethod]
        public void OperatorOr_LeftError_RightEvalNotReached()
        {
            Detector detector = new();
            Detector rightDetector = new();
            try
            {
                var result = Chk.If<int>(detector.Error) || Chk.If<int>(rightDetector.Eval());
            }
            catch (IntentionalError) { }

            //ASSERT
            Assert.IsFalse(rightDetector.IsEvaluated);
        }

        [TestMethod]
        public void OperatorOr_LeftFail_LeftIsEvaluated()
        {
            Detector detector = new(false);
            var result = Chk.If<int>(detector.Eval()) || Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(detector.IsEvaluated);
        }

        [TestMethod]
        public void OperatorOr_LeftFailFailPayload_HasPayload()
        {
            var result = Chk<int>.Fail || Chk.Pld.ForFail(rightIntPayload);
            //ASSERT
            Assert.AreEqual(rightIntPayload, result.Payload);
        }

        [TestMethod]
        public void OperatorOr_LeftFailRightRsn_ResultIsDetermined()
        {
            var result = Chk<int>.Fail || Chk<int>.Rsn.Fail;
            //ASSERT
            Assert.IsTrue(result.Simplify().IsDetermined);
        }

        [TestMethod]
        public void OperatorOr_LeftPass_LeftReason()
        {
            var result = Chk<int>.Pass.Passes(leftReason) || Chk<int>.Fail.Fails(rightReason);
            //ASSERT
            Assert.AreEqual(leftReason, result.Reason);
        }

        [TestMethod]
        public void OperatorOr_LeftPass_Passed()
        {
            var result = Chk<int>.Pass || Chk<int>.Fail;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorOr_LeftPass_RightShortCircuited()
        {
            Detector detector = new();
            var result = Chk<int>.Pass || Chk.If<int>(detector.Eval());
            //ASSERT
            Assert.IsFalse(detector.IsEvaluated);
        }

        [TestMethod]
        public void OperatorOr_RightFail_LeftReason()
        {
            var result = Chk<int>.Pass.Passes(leftReason) || Chk<int>.Fail.Fails(rightReason);
            //ASSERT
            Assert.AreEqual(leftReason, result.Reason);
        }

        [TestMethod]
        public void OperatorOr_RightPass_Passed()
        {
            var result = Chk<int>.Fail || Chk<int>.Pass;
            //ASSERT
            Assert.IsTrue(result.Passed);
        }

        [TestMethod]
        public void OperatorOr_RightPass_RightReason()
        {
            var result = Chk<int>.Fail.Fails(leftReason) || Chk<int>.Pass.Passes(rightReason);
            //ASSERT
            Assert.AreEqual(rightReason, result.Reason);
        }

        #endregion
    }

}
