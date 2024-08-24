using System.Collections.Generic;
using daily_problems;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace daily_problems.Tests;

[TestClass]
[TestSubject(typeof(Problem1))]
public class Problem1Test
{

    [TestMethod]
    public void METHOD()
    {
        Assert.AreEqual(false,Problem1.CheckForPair(new List<int>(){3,4,7},5));
        Assert.AreEqual(false,Problem1.CheckForPair(new List<int>(){5,32,6},54));
        Assert.AreEqual(false,Problem1.CheckForPair(new List<int>(){6,1,15},23));
        
        Assert.AreEqual(true,Problem1.CheckForPair(new List<int>(){3,4,7},11));
        Assert.AreEqual(true,Problem1.CheckForPair(new List<int>(){5,32,6},38));
        Assert.AreEqual(true,Problem1.CheckForPair(new List<int>(){6,1,15},7));
    }
}