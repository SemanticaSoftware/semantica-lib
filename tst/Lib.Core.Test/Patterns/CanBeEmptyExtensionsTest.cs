using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Patterns;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Patterns;

[TestClass]
public class CanBeEmptyExtensionsTest
{
    private EmptyOrNot Empty { get; set; } = null!;
    private EmptyOrNot NotEmpty { get; set; } = null!;

    [TestInitialize]
    public void Init()
    {
        //Initialize data
        Empty = new EmptyOrNot(true);
        NotEmpty = new EmptyOrNot(false);
    }

    [TestMethod]
    public void FirstNonEmpty_ListWithOneNonEmpty_ReturnsThatItem()
    {
        IEnumerable<EmptyOrNot> enumerable = new List<EmptyOrNot> { Empty, Empty, NotEmpty, new EmptyOrNot(false) };
        //ACT
        var result = CanBeEmptyCollectionExtensions.FirstNonEmpty(enumerable);
        //ASSERT
        Assert.AreSame(NotEmpty, result);
    }

    [TestMethod]
    public void FirstNonEmpty_ListWithNoNonEmpty_ReturnsNull()
    {
        IEnumerable<EmptyOrNot> enumerable = new List<EmptyOrNot> { Empty, Empty, Empty };
        //ACT
        var result = CanBeEmptyCollectionExtensions.FirstNonEmpty(enumerable);
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void NullOnEmpty_Empty_ReturnsNull()
    {            
        //ACT
        var result = CanBeEmptyExtensions.NullOnEmpty(Empty, new{});
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void NullOnEmpty_NonEmpty_ReturnsObject()
    {
        var obj = new { };
        //ACT
        var result = CanBeEmptyExtensions.NullOnEmpty(NotEmpty, obj);
        //ASSERT
        Assert.AreSame(obj, result);
    }

    [TestMethod]
    public void NullOnEmpty_Nullable_Empty_ReturnsNull()
    {
        int? nullable = 1;
        //ACT
        var result = CanBeEmptyExtensions.NullOnEmpty(Empty, nullable);
        //ASSERT
        Assert.IsFalse(result.HasValue);
    }

    [TestMethod]
    public void NullOnEmpty_Nullable_NonEmpty_ReturnsObject()
    {
        int? nullable = 1;
        //ACT
        var result = CanBeEmptyExtensions.NullOnEmpty(NotEmpty, nullable);
        //ASSERT
        Assert.AreEqual(nullable, result);
    }

    [TestMethod]
    public void IsEmpty_EmptyGuid_ReturnsTrue()
    {
        var emptyGuid = Guid.Empty;
        //ACT
        var result = GuidExtensions.IsEmpty(emptyGuid);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsEmpty_ValidGuid_ReturnsFalse()
    {
        var validGuid = Guid.NewGuid();
        //ACT
        var result = GuidExtensions.IsEmpty(validGuid);
        //ASSERT
        Assert.IsFalse(result);
    }

    private class EmptyOrNot : ICanBeEmpty
    {
        public EmptyOrNot(bool empty)
        {
            Empty = empty;
        }

        public bool IsEmpty()
        {
            return Empty;
        }

        public bool Empty { get; }
    }
}