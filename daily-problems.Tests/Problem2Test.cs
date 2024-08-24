using System.Collections.Generic;
using System.Linq;
using daily_problems;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace daily_problems.Tests;

[TestClass]
[TestSubject(typeof(Problem2))]
public class Problem2Test
{

    [TestMethod]
    public void PASS()
    {
        Assert.IsTrue(new Problem2().ReturnProductOfAllExcept([10, 15, 3, 7]).SequenceEqual([315, 210, 1050, 450]));
        Assert.IsTrue(new Problem2().ReturnProductOfAllExcept([1, 2, 3, 4, 5]).SequenceEqual([120, 60, 40, 30, 24]));
    }
    [TestMethod]
    public void FAIL()
    {
        Assert.IsFalse(new Problem2().ReturnProductOfAllExcept([10, 15, 3, 7]).SequenceEqual([315, 211, 1050, 450]));
        Assert.IsFalse(new Problem2().ReturnProductOfAllExcept([1, 2, 3, 4, 5]).SequenceEqual([120, 61, 40, 30, 24]));
    }
}