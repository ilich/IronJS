// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter10._10_4
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _10_4_3_Tests : IE9TestFixture
    {
        public _10_4_3_Tests() : base(@"chapter10\10.4\10.4.3") { }

        [Test(Description = "this is not coerced to an object in strict mode (Number)")] public void _10_4_3__1__1__s() { RunFile(@"10.4.3-1-1-s.js"); }
        [Test(Description = "this is not coerced to an object in strict mode (string)")] public void _10_4_3__1__2__s() { RunFile(@"10.4.3-1-2-s.js"); }
        [Test(Description = "this is not coerced to an object in strict mode (undefined)")] public void _10_4_3__1__3__s() { RunFile(@"10.4.3-1-3-s.js"); }
        [Test(Description = "this is not coerced to an object in strict mode (boolean)")] public void _10_4_3__1__4__s() { RunFile(@"10.4.3-1-4-s.js"); }
        [Test(Description = "this is not coerced to an object in strict mode (function)")] public void _10_4_3__1__5__s() { RunFile(@"10.4.3-1-5-s.js"); }
    }
}