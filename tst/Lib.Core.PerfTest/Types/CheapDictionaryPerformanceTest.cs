using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Collections;
using Semantica.Mvc.Types;

namespace Semantica.Lib.Tests.Core.Test.Types;

[TestClass]
public class CheapDictionaryPerformanceTest
{
    [TestMethod]
    public void PerformanceTest_ConstructAndEnumerate_100000Elements_CompareToDictionary()
    {
        const int repeats = 100;
        var data = GetData(100000).ToArray();
        var elapsedTimeCheap = GetExecutionTime(ExecuteMakeAndEnumerateCheapDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for cheap dictionary: {elapsedTimeCheap}");
        var elapsedTimeArray = GetExecutionTime(ExecuteMakeAndEnumerateArrayDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for array dictionary: {elapsedTimeArray}");
        var elapsedTimeNormal = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary: {elapsedTimeNormal}");
        var elapsedTimeNormalNoSize = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionaryNoInitialSize, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary without initial size: {elapsedTimeNormalNoSize}");
        Assert.Fail();
    }
        
    [TestMethod]
    public void PerformanceTest_ConstructAndEnumerate_10000Elements_CompareToDictionary()
    {
        const int repeats = 1000;
        var data = GetData(10000).ToArray();
        var elapsedTimeCheap = GetExecutionTime(ExecuteMakeAndEnumerateCheapDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for cheap dictionary: {elapsedTimeCheap}");
        var elapsedTimeArray = GetExecutionTime(ExecuteMakeAndEnumerateArrayDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for array dictionary: {elapsedTimeArray}");
        var elapsedTimeNormal = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary: {elapsedTimeNormal}");
        var elapsedTimeNormalNoSize = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionaryNoInitialSize, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary without initial size: {elapsedTimeNormalNoSize}");
        Assert.Fail();
    }
        
    [TestMethod]
    public void PerformanceTest_ConstructAndEnumerate_1000Elements_CompareToDictionary()
    {
        const int repeats = 10000;
        var data = GetData(1000).ToArray();
        var elapsedTimeCheap = GetExecutionTime(ExecuteMakeAndEnumerateCheapDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for cheap dictionary: {elapsedTimeCheap}");
        var elapsedTimeArray = GetExecutionTime(ExecuteMakeAndEnumerateArrayDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for array dictionary: {elapsedTimeArray}");
        var elapsedTimeNormal = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary: {elapsedTimeNormal}");
        var elapsedTimeNormalNoSize = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionaryNoInitialSize, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary without initial size: {elapsedTimeNormalNoSize}");
        Assert.Fail();
    }
        
    [TestMethod]
    public void PerformanceTest_ConstructAndEnumerate_100Elements_CompareToDictionary()
    {
        const int repeats = 100000;
        var data = GetData(100).ToArray();
        var elapsedTimeCheap = GetExecutionTime(ExecuteMakeAndEnumerateCheapDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for cheap dictionary: {elapsedTimeCheap}");
        var elapsedTimeArray = GetExecutionTime(ExecuteMakeAndEnumerateArrayDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for array dictionary: {elapsedTimeArray}");
        var elapsedTimeNormal = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary: {elapsedTimeNormal}");
        var elapsedTimeNormalNoSize = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionaryNoInitialSize, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary without initial size: {elapsedTimeNormalNoSize}");
        Assert.Fail();
    }

    [TestMethod]
    public void PerformanceTest_ConstructAndEnumerate_10Elements_CompareToDictionary()
    {
        const int repeats = 1000000;
        var data = GetData(10).ToArray();
        var elapsedTimeCheap = GetExecutionTime(ExecuteMakeAndEnumerateCheapDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for cheap dictionary: {elapsedTimeCheap}");
        var elapsedTimeArray = GetExecutionTime(ExecuteMakeAndEnumerateArrayDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for array dictionary: {elapsedTimeArray}");
        var elapsedTimeNormal = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionary, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary: {elapsedTimeNormal}");
        var elapsedTimeNormalNoSize = GetExecutionTime(ExecuteMakeAndEnumerateNormalDictionaryNoInitialSize, data, repeats);
        Console.WriteLine($"Elapsed time for normal dictionary without initial size: {elapsedTimeNormalNoSize}");
        Assert.Fail();
    }

    private static long GetExecutionTime(Action<KeyValuePair<string, object>[]> action, KeyValuePair<string, object>[] data, int repeats)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (var i = 0; i < repeats; i++)
        {
            action(data);
        }
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    private void ExecuteMakeAndEnumerateArrayDictionary(KeyValuePair<string, object>[] data)
    {
        var dictionary = new ArrayDictionary<string, object>(data);
        EnumerateAllElements(dictionary);
    }

    private void ExecuteMakeAndEnumerateNormalDictionaryNoInitialSize(KeyValuePair<string, object>[] data)
    {
        var dictionary = new Dictionary<string, object>();
        foreach (var pair in data)
        {
            dictionary.Add(pair.Key, pair.Value);
        }
        EnumerateAllElements(dictionary);
    }

    private void ExecuteMakeAndEnumerateNormalDictionary(KeyValuePair<string, object>[] data)
    {
        var dictionary = new Dictionary<string, object>(data.Length);
        foreach (var pair in data)
        {
            dictionary.Add(pair.Key, pair.Value);
        }
        EnumerateAllElements(dictionary);
    }

    private void ExecuteMakeAndEnumerateCheapDictionary(KeyValuePair<string, object>[] data)
    {
        var cheap = new CheapDictionary(data);
        EnumerateAllElements(cheap);
    }

    private void EnumerateAllElements(IDictionary<string, object> dictionary)
    {
        if (dictionary.Any(pair => pair.Value == null))
        {
            throw new Exception();
        }
    }

    private IEnumerable<KeyValuePair<string, object>> GetData(int numOfElements)
    {
        var random = new Random();
        var stringLength = 16;
        var array = new char[stringLength];
        for (var i = 0; i < numOfElements; i++)
        {
            for (var j = 0; j < stringLength; j++)
            {
                array[j] = (char)random.Next('a', 'z');
            }
            yield return new KeyValuePair<string, object>(new string(array), new{});
        }
    }
}
