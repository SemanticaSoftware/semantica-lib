using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Extensions.Tokenizer;

// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class TokenizeExtensionsTest
{
    private const string _someInput = "xx1x-xx2x-xx3x!";

    [TestClass]
    public class Char
    {
        public const char _separator = '-';
        public const char _terminator = '!';
        public const char _wrongSeparator = '=';

        private CharTokenizer _tokenizer;

        #region Next

        ReadOnlySpan<char> DoNext(char? separator = default)
        {
            _tokenizer = separator.HasValue 
                ? TokenizeExtensions.Next(_tokenizer, separator.Value, out var token)
                : TokenizeExtensions.Next(_tokenizer, out token);
            return token;
        }

        [TestMethod]
        public void Next_CorrectSeparator_CorrectSecondToken()
        {
            DoTokenize();
            //ACT
            var actual = DoNext().ToString();
            //ASSERT
            Assert.AreEqual("xx2x", actual);
        }

        [TestMethod]
        public void Next_CorrectSeparator_CorrectRestIndex()
        {
            DoTokenize();
            //ACT
            DoNext();
            var actual = _tokenizer.RestIndex; 
            //ASSERT
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void Next_OtherSeparator_RestIndexNotZero()
        {
            DoTokenize();
            //ACT
            DoNext(_terminator);
            var actual = _tokenizer.RestIndex; 
            //ASSERT
            Assert.AreNotEqual(0, actual);
        }

        [TestMethod]
        public void Next_WrongSeparator_RestIndexZero()
        {
            DoTokenize();
            //ACT
            DoNext(_wrongSeparator);
            var actual = _tokenizer.RestIndex; 
            //ASSERT
            Assert.AreEqual(0, actual);
        }

        #endregion
        #region NextOptional

        ReadOnlySpan<char> DoNextOptional(char? separator = default)
        {
            _tokenizer = separator.HasValue 
                ? TokenizeExtensions.NextOptional(_tokenizer, separator.Value, out var token)
                : TokenizeExtensions.NextOptional(_tokenizer, out token);
            return token;
        }

        [TestMethod]
        public void NextOptional_CorrectSeparator_CorrectSecondToken()
        {
            DoTokenize();
            //ACT
            var actual = DoNextOptional().ToString();
            //ASSERT
            Assert.AreEqual("xx2x", actual);
        }

        [TestMethod]
        public void NextOptional_CorrectSeparator_CorrectRestIndex()
        {
            DoTokenize();
            //ACT
            DoNextOptional();
            //ASSERT
            Assert.AreEqual(10, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void NextOptional_OtherSeparator_RestIndexNotZero()
        {
            DoTokenize();
            //ACT
            DoNextOptional(_terminator);
            //ASSERT
            Assert.AreNotEqual(0, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void NextOptional_WrongSeparator_RestIndexUnchanged()
        {
            DoTokenize();
            //ACT
            DoNextOptional(_wrongSeparator);
            //ASSERT
            Assert.AreEqual(5, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void NextOptional_WrongSeparator_TokenEmpty()
        {
            DoTokenize();
            //ACT
            var actual = DoNextOptional(_wrongSeparator);
            //ASSERT
            Assert.IsTrue(actual.IsEmpty);
        }

        #endregion
        #region Rest

        ReadOnlySpan<char> DoRest()
        {
            _tokenizer = TokenizeExtensions.Rest(_tokenizer, out var token);
            return token;
        }

        [TestMethod]
        public void Rest_AfterNext_CorrectThirdToken()
        {
            DoTokenize();
            DoNext();
            //ACT
            var actual = DoRest().ToString();
            //ASSERT
            Assert.AreEqual("xx3x!", actual);
        }

        [TestMethod]
        public void Rest_AfterNext_RestIndexNotChanged()
        {
            DoTokenize();
            DoNext();
            //ACT
            DoRest();
            //ASSERT
            Assert.AreEqual(10, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void Rest_AfterTerminator_EmptyToken()
        {
            DoTokenize(_terminator);
            //ACT
            var actual = DoRest();
            //ASSERT
            Assert.IsTrue(actual.IsEmpty);
        }

        #endregion
        #region Tokenize

        ReadOnlySpan<char> DoTokenize(char? separator = default)
        {
            _tokenizer = TokenizeExtensions.Tokenize(_someInput, separator ?? _separator, out var token);
            return token;
        }

        [TestMethod]
        public void Tokenize_CorrectSeparator_CorrectFirstToken()
        {
            //ACT
            var actual = DoTokenize().ToString();
            //ASSERT
            Assert.AreEqual("xx1x", actual);
        }

        [TestMethod]
        public void Tokenize_CorrectSeparator_CorrectRestIndex()
        {
            //ACT
            DoTokenize();
            var actual = _tokenizer.RestIndex; 
            //ASSERT
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Tokenize_WrongSeparator_RestIndexZero()
        {
            //ACT
            DoTokenize(_wrongSeparator);
            //ASSERT
            Assert.AreEqual(0, _tokenizer.RestIndex);
        }

        #endregion
        #region Try
        
        [TestMethod]
        public void Try_AfterNext_True()
        {
            DoTokenize();
            DoNext();
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsTrue(actual);
        }
        
        [TestMethod]
        public void Try_AfterRest_True()
        {
            DoTokenize();
            DoNext();
            DoRest();
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsTrue(actual);
        }
        
        [TestMethod]
        public void Try_SeparatorRemaining_False()
        {
            DoTokenize();
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Try_WrongSeparatorOnNext_False()
        {
            DoTokenize();
            DoNext(_wrongSeparator);
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Try_WrongSeparatorOnTokenize_False()
        {
            DoTokenize(_wrongSeparator);
            DoNext(_separator);
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Try_WrongSeparatorOnNextOptional_True()
        {
            DoTokenize();
            DoNext();
            DoNext(_wrongSeparator);
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }
        
        #endregion
    }

    [TestClass]
    public class String
    {
        private static readonly string _separator = "x" + Char._separator;
        private static readonly string _wrongSeparator = "x" + Char._wrongSeparator;
        private static readonly string _terminator = Char._terminator.ToString();

        private StringTokenizer _tokenizer;

        #region Next

        ReadOnlySpan<char> DoNext(string? separator = null)
        {
            _tokenizer = separator != null 
                ? TokenizeExtensions.Next(_tokenizer, separator, out var token)
                : TokenizeExtensions.Next(_tokenizer, out token);
            return token;
        }

        [TestMethod]
        public void Next_CorrectSeparator_CorrectSecondToken()
        {
            DoTokenize();
            //ACT
            var actual = DoNext().ToString();
            //ASSERT
            Assert.AreEqual("xx2", actual);
        }

        [TestMethod]
        public void Next_CorrectSeparator_CorrectRestIndex()
        {
            DoTokenize();
            //ACT
            DoNext();
            var actual = _tokenizer.RestIndex; 
            //ASSERT
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void Next_OtherSeparator_RestIndexNotZero()
        {
            DoTokenize();
            //ACT
            DoNext(_terminator);
            //ASSERT
            Assert.AreNotEqual(0, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void Next_WrongSeparator_RestIndexZero()
        {
            DoTokenize();
            //ACT
            DoNext(_wrongSeparator);
            //ASSERT
            Assert.AreEqual(0, _tokenizer.RestIndex);
        }

        #endregion
        #region NextOptional

        ReadOnlySpan<char> DoNextOptional(string? separator = null)
        {
            _tokenizer = separator != null 
                ? TokenizeExtensions.NextOptional(_tokenizer, separator, out var token)
                : TokenizeExtensions.NextOptional(_tokenizer, out token);
            return token;
        }

        [TestMethod]
        public void NextOptional_CorrectSeparator_CorrectSecondToken()
        {
            DoTokenize();
            //ACT
            var actual = DoNextOptional().ToString();
            //ASSERT
            Assert.AreEqual("xx2", actual);
        }

        [TestMethod]
        public void NextOptional_CorrectSeparator_CorrectRestIndex()
        {
            DoTokenize();
            //ACT
            DoNextOptional();
            //ASSERT
            Assert.AreEqual(10, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void NextOptional_OtherSeparator_RestIndexNotZero()
        {
            DoTokenize();
            //ACT
            DoNextOptional(_terminator);
            //ASSERT
            Assert.AreNotEqual(0, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void NextOptional_WrongSeparator_RestIndexUnchanged()
        {
            DoTokenize();
            //ACT
            DoNextOptional(_wrongSeparator);
            //ASSERT
            Assert.AreEqual(5, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void NextOptional_WrongSeparator_TokenEmpty()
        {
            DoTokenize();
            //ACT
            var actual = DoNextOptional(_wrongSeparator);
            //ASSERT
            Assert.IsTrue(actual.IsEmpty);
        }

        #endregion
        #region Rest

        ReadOnlySpan<char> DoRest()
        {
            _tokenizer = TokenizeExtensions.Rest(_tokenizer, out var token);
            return token;
        }

        [TestMethod]
        public void Rest_AfterNext_CorrectThirdToken()
        {
            DoTokenize();
            DoNext();
            //ACT
            var actual = DoRest().ToString();
            //ASSERT
            Assert.AreEqual("xx3x!", actual);
        }

        [TestMethod]
        public void Rest_AfterNext_RestIndexNotChanged()
        {
            DoTokenize();
            DoNext();
            //ACT
            DoRest();
            //ASSERT
            Assert.AreEqual(10, _tokenizer.RestIndex);
        }

        [TestMethod]
        public void Rest_AfterTerminator_EmptyToken()
        {
            DoTokenize(_terminator);
            //ACT
            var actual = DoRest();
            //ASSERT
            Assert.IsTrue(actual.IsEmpty);
        }

        #endregion
        #region Tokenize

        ReadOnlySpan<char> DoTokenize(string? separator = null)
        {
            _tokenizer = TokenizeExtensions.Tokenize(_someInput, separator ?? _separator, out var token);
            return token;
        }

        [TestMethod]
        public void Tokenize_CorrectSeparator_CorrectFirstToken()
        {
            //ACT
            var actual = DoTokenize().ToString();
            //ASSERT
            Assert.AreEqual("xx1", actual);
        }

        [TestMethod]
        public void Tokenize_CorrectSeparator_CorrectRestIndex()
        {
            //ACT
            DoTokenize();
            var actual = _tokenizer.RestIndex; 
            //ASSERT
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Tokenize_WrongSeparator_RestIndexZero()
        {
            //ACT
            DoTokenize(_wrongSeparator);
            //ASSERT
            Assert.AreEqual(0, _tokenizer.RestIndex);
        }

        #endregion
        #region Try
        
        [TestMethod]
        public void Try_AfterNext_True()
        {
            DoTokenize();
            DoNext();
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsTrue(actual);
        }
        
        [TestMethod]
        public void Try_AfterRest_True()
        {
            DoTokenize();
            DoNext();
            DoRest();
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsTrue(actual);
        }
        
        [TestMethod]
        public void Try_SeparatorRemaining_False()
        {
            DoTokenize();
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Try_WrongSeparatorOnNext_False()
        {
            DoTokenize();
            DoNext(_wrongSeparator);
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Try_WrongSeparatorOnTokenize_False()
        {
            DoTokenize(_wrongSeparator);
            DoNext(_separator);
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Try_WrongSeparatorOnNextOptional_True()
        {
            DoTokenize();
            DoNext();
            DoNext(_wrongSeparator);
            //ACT
            var actual = _tokenizer.Try(); 
            //ASSERT
            Assert.IsFalse(actual);
        }
        
        #endregion
    }
}
