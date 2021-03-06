﻿using NUnit.Framework;
using Seal.Fody;

[TestFixture]
public class SealSample
{
    [Test]
    public void Run()
    {
        Assert.IsTrue(typeof(Sealed).IsSealed);
        Assert.IsFalse(typeof(NonSealed).IsSealed);
    }
}

class Sealed
{
}

[LeaveUnsealed]
class NonSealed
{
}