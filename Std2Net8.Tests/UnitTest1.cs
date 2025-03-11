namespace Std2.Tests;

using Std2Net8;
using System.Reflection;

public class Tests
{
    ///[SetUp]
    ///public void Setup()
    ///{
    ///}

    [Test]
    public void Test1()
    {
        bool success = false;

        bool? isStd2 = TargetFramework.IsNetStandard();
        string? assembly = Assembly.GetExecutingAssembly().GetName().Name;

        if (assembly == "Net8.Tests" && isStd2 == false)
        {
            success = true;
        }
        else if (assembly == "Std2.Tests" && isStd2 == true)
        {
            success = true;
        }

        Assert.That(success, Is.True);
    }

}