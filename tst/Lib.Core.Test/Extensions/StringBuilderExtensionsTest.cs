using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class StringBuilderExtensionsTest
{
    [DataTestMethod]
    [DataRow("test\r\n\r\n", "test\r\n")]
    [DataRow("test\r\n", "test")]
    [DataRow("test\n", "test")]
    [DataRow("test\r", "test")]
    public void ToStringNoNewLine_StripsTrailingLineEnding(string value, string expected)
    {
        var stringBuilder = new StringBuilder(value);

        var result = stringBuilder.ToStringNoNewLine();

        Assert.AreEqual(expected, result);
    }
}
