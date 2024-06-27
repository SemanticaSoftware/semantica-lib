using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Checks;

namespace Semantica.Lib.Tests.Core.Test.Checks;

public partial class ChkTest
{
    [TestClass]
    public class Rsn
    {
        [TestMethod]
        public void RsnForFail_OperatorAnd_BothFail_LeftReason()
        {
            var result = Chk.Fail.Fails(leftReason) && (Chk.Fail || Chk.Rsn.ForFail(rightReason));

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.AreEqual((object)leftReason, result.Reason);
        }

        [TestMethod]
        public void RsnForFail_OperatorAnd_BothPass_LeftReason()
        {
            var result = Chk.Pass.Passes(leftReason) && (Chk.Pass || Chk.Rsn.ForFail(rightReason));

            //ASSERT
            Assert.IsTrue(result.Passed);
            Assert.AreEqual((object)leftReason, result.Reason);
        }

        [TestMethod]
        public void RsnForFail_OperatorAnd_BothPass_RightNotEvaluated()
        {
            var detector = new Detector();
            var result = Chk.Pass && (Chk.Pass || Chk.Rsn.ForFail(detector.Eval() ? rightReason : null));

            //ASSERT
            Assert.IsTrue(result.Passed);
            Assert.IsFalse(detector.IsEvaluated);
        }

        [TestMethod]
        public void RsnForFail_OperatorAnd_RightFail_RightReason()
        {
            var result = Chk.Pass.Passes(leftReason) && (Chk.Fail || Chk.Rsn.ForFail(rightReason));

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.AreEqual((object)rightReason, result.Reason);
        }

        [TestMethod]
        public void RsnForFail_OperatorAnd_RightPass_LeftReason()
        {
            var result = Chk.Fail.Fails(leftReason) && (Chk.Pass || Chk.Rsn.ForFail(rightReason));

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.AreEqual((object)leftReason, result.Reason);
        }

        [TestMethod]
        public void RsnForFail_OperatorAnd_LeftFail_RightNotEvaluated()
        {
            var detector = new Detector();
            var result = Chk.Fail && (Chk.Pass || Chk.Rsn.ForFail(detector.Eval() ? rightReason : null));

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.IsFalse(detector.IsEvaluated);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RsnForFail_WrongOperator_ThrowsException()
        {
            var result = Chk.Pass & Chk.Rsn.ForFail(rightReason);
        }

        [TestMethod]
        public void RsnForPass_OperatorAnd_BothFail_LeftReason()
        {
            var result = Chk.Fail.Fails(leftReason) && Chk.Fail && Chk.Rsn.ForPass(rightReason);

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.AreEqual((object)leftReason, result.Reason);
        }

        [TestMethod]
        public void RsnForPass_OperatorAnd_BothFail_RightNotEvaluated()
        {
            var detector = new Detector();
            var result = Chk.Fail && Chk.Fail && Chk.Rsn.ForPass(detector.Eval() ? rightReason : null);

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.IsFalse(detector.IsEvaluated);
        }

        [TestMethod]
        public void RsnForPass_OperatorAnd_BothPass_BothReason()
        {
            var result = Chk.Pass.Passes(leftReason) && Chk.Pass && Chk.Rsn.ForPass(rightReason);

            //ASSERT
            Assert.IsTrue(result.Passed);
            Assert.That.IsTrue(result.Reason?.Contains(leftReason));
            Assert.That.IsTrue(result.Reason?.Contains(rightReason));
        }

        [TestMethod]
        public void RsnForPass_OperatorAnd_LeftFail_LeftReason()
        {
            var result = Chk.Fail.Fails(leftReason) && Chk.Pass && Chk.Rsn.ForPass(rightReason);

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.AreEqual((object)leftReason, result.Reason);
        }

        [TestMethod]
        public void RsnForPass_OperatorAnd_LeftFail_RightNotEvaluated()
        {
            var detector = new Detector();
            var result = Chk.Fail && Chk.Pass && Chk.Rsn.ForPass(detector.Eval() ? rightReason : null);

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.IsFalse(detector.IsEvaluated);
        }

        [TestMethod]
        public void RsnForPass_OperatorAnd_RightFail_NoReason()
        {
            var result = Chk.Pass.Passes(leftReason) && Chk.Fail && Chk.Rsn.ForPass(rightReason);

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.IsNull(result.Reason);
        }

        [TestMethod]
        public void RsnForPass_OperatorOr_BothFail_RightNotEvaluated()
        {
            var detector = new Detector();
            var result = Chk.Fail || Chk.Fail && Chk.Rsn.ForPass(detector.Eval() ? rightReason : null);

            //ASSERT
            Assert.IsTrue(result.Failed);
            Assert.IsFalse(detector.IsEvaluated);
        }

        [TestMethod]
        public void RsnForPass_OperatorOr_LeftPass_RightNotEvaluated()
        {
            var detector = new Detector();
            var result = Chk.Pass || Chk.Fail && Chk.Rsn.ForPass(detector.Eval() ? rightReason : null);

            //ASSERT
            Assert.IsTrue(result.Passed);
            Assert.IsFalse(detector.IsEvaluated);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RsnForPass_WrongOperator_ThrowsException()
        {
            var result = Chk.Fail | Chk.Rsn.ForPass(rightReason);
        }
    }
}
