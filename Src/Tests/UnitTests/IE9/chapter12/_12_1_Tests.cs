// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter12
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _12_1_Tests : IE9TestFixture
    {
        public _12_1_Tests() : base(@"chapter12\12.1") { }

        [Test(Description = "12.1 - block \'{ StatementListopt };\' is not allowed: try-catch")] public void _12_1__1() { RunFile(@"12.1-1.js"); }
        [Test(Description = "12.1 - block \'{ StatementListopt };\' is not allowed: try-catch-finally")] public void _12_1__2() { RunFile(@"12.1-2.js"); }
        [Test(Description = "12.1 - block \'{ StatementListopt };\' is not allowed: try-finally")] public void _12_1__3() { RunFile(@"12.1-3.js"); }
        [Test(Description = "12.1 - block \'{ StatementListopt };\' is not allowed: if-else")] public void _12_1__4() { RunFile(@"12.1-4.js"); }
        [Test(Description = "12.1 - block \'{ StatementListopt };\' is not allowed: if-else-if")] public void _12_1__5() { RunFile(@"12.1-5.js"); }
        [Test(Description = "12.1 - block \'{ StatementListopt };\' is not allowed: if-else-if-else")] public void _12_1__6() { RunFile(@"12.1-6.js"); }
        [Test(Description = "12.1 - block \'{ StatementListopt };\' is not allowed: do-while")] public void _12_1__7() { RunFile(@"12.1-7.js"); }
    }
}