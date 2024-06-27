namespace Semantica.Lib.Tests.Core.Test._Mocks;

public record TestClass<T>(T Value);

public record TestClass(int Value = 0) : TestClass<int>(Value);

public readonly record struct TestType<T>(T Value);

public readonly record struct TestStruct(int Value = 0);

