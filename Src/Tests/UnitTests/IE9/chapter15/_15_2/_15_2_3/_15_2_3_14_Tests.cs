// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_2._15_2_3
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_2_3_14_Tests : IE9TestFixture
    {
        public _15_2_3_14_Tests() : base(@"chapter15\15.2\15.2.3\15.2.3.14") { }

        [Test(Description = "Object.keys must exist as a function")] public void _15_2_3_14__0__1() { RunFile(@"15.2.3.14-0-1.js"); }
        [Test(Description = "Object.keys must exist as a function taking 1 parameter")] public void _15_2_3_14__0__2() { RunFile(@"15.2.3.14-0-2.js"); }
        [Test(Description = "Object.keys throws TypeError if type of first param is not Object")] public void _15_2_3_14__1__1() { RunFile(@"15.2.3.14-1-1.js"); }
        [Test(Description = "Object.keys throws TypeError if type of first param is not Object (boolean)")] public void _15_2_3_14__1__2() { RunFile(@"15.2.3.14-1-2.js"); }
        [Test(Description = "Object.keys throws TypeError if type of first param is not Object (string)")] public void _15_2_3_14__1__3() { RunFile(@"15.2.3.14-1-3.js"); }
        [Test(Description = "Object.keys throws TypeError if type of first param is not Object (null)")] public void _15_2_3_14__1__4() { RunFile(@"15.2.3.14-1-4.js"); }
        [Test(Description = "Object.keys throws TypeError if type of first param is not Object (undefined)")] public void _15_2_3_14__1__5() { RunFile(@"15.2.3.14-1-5.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array")] public void _15_2_3_14__2__1() { RunFile(@"15.2.3.14-2-1.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array (check [[Class]]")] public void _15_2_3_14__2__2() { RunFile(@"15.2.3.14-2-2.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array (Array overridden)")] public void _15_2_3_14__2__3() { RunFile(@"15.2.3.14-2-3.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array that is extensible")] public void _15_2_3_14__2__4() { RunFile(@"15.2.3.14-2-4.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array that is not sealed")] public void _15_2_3_14__2__5() { RunFile(@"15.2.3.14-2-5.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array that is not frozen")] public void _15_2_3_14__2__6() { RunFile(@"15.2.3.14-2-6.js"); }
        [Test(Description = "Object.keys - \'n\' is 0 when \'O\' doesn\'t contain own enumerable data or accessor properties")] public void _15_2_3_14__2__7() { RunFile(@"15.2.3.14-2-7.js"); }
        [Test(Description = "Object.keys - \'n\' is the correct value when enumerable properties exist in \'O\'")] public void _15_2_3_14__2__8() { RunFile(@"15.2.3.14-2-8.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array containing own enumerable properties")] public void _15_2_3_14__3__1() { RunFile(@"15.2.3.14-3-1.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array containing own enumerable properties (function)")] public void _15_2_3_14__3__2() { RunFile(@"15.2.3.14-3-2.js"); }
        [Test(Description = "Object.keys returns the standard built-in Array containing own enumerable properties (array)")] public void _15_2_3_14__3__3() { RunFile(@"15.2.3.14-3-3.js"); }
        [Test(Description = "Object.keys of an arguments object returns the indices of the given arguments")] public void _15_2_3_14__3__4() { RunFile(@"15.2.3.14-3-4.js"); }
        [Test(Description = "Object.keys must return a fresh array on each invocation")] public void _15_2_3_14__3__5() { RunFile(@"15.2.3.14-3-5.js"); }
        [Test(Description = "Object.keys - returns the standard built-in Array (instanceof Array)")] public void _15_2_3_14__3__6() { RunFile(@"15.2.3.14-3-6.js"); }
        [Test(Description = "Object.keys - length of the returned array equals the number of own enumerable properties of \'O\'")] public void _15_2_3_14__3__7() { RunFile(@"15.2.3.14-3-7.js"); }
        [Test(Description = "Object.keys - elements of the returned array start from index 0")] public void _15_2_3_14__4__1() { RunFile(@"15.2.3.14-4-1.js"); }
        [Test(Description = "Object.keys - own enumerable data property of \'O\' is defined in returned array")] public void _15_2_3_14__5__1() { RunFile(@"15.2.3.14-5-1.js"); }
        [Test(Description = "Object.keys - inherted enumerable accessor property that is over-ridden by non-enumerable own accessor property is not defined in returned array")] public void _15_2_3_14__5__10() { RunFile(@"15.2.3.14-5-10.js"); }
        [Test(Description = "Object.keys - own enumerable indexed data property of dense array \'O\' is defined in returned array")] public void _15_2_3_14__5__11() { RunFile(@"15.2.3.14-5-11.js"); }
        [Test(Description = "Object.keys - own enumerable indexed accessor property of dense array \'O\' is defined in returned array")] public void _15_2_3_14__5__12() { RunFile(@"15.2.3.14-5-12.js"); }
        [Test(Description = "Object.keys - own enumerable indexed data property of sparse array \'O\' is defined in returned array")] public void _15_2_3_14__5__13() { RunFile(@"15.2.3.14-5-13.js"); }
        [Test(Description = "Object.keys - own enumerable indexed accessor property of sparse array \'O\' is defined in returned array")] public void _15_2_3_14__5__14() { RunFile(@"15.2.3.14-5-14.js"); }
        [Test(Description = "Object.keys - own enumerable indexed data property of String object \'O\' is defined in returned array")] public void _15_2_3_14__5__15() { RunFile(@"15.2.3.14-5-15.js"); }
        [Test(Description = "Object.keys - own enumerable indexed accessor property of String object \'O\' is defined in returned array")] public void _15_2_3_14__5__16() { RunFile(@"15.2.3.14-5-16.js"); }
        [Test(Description = "Object.keys - own enumerable accessor property of \'O\' is defined in returned array")] public void _15_2_3_14__5__2() { RunFile(@"15.2.3.14-5-2.js"); }
        [Test(Description = "Object.keys - non-enumerable own data property of \'O\' is not defined in returned array")] public void _15_2_3_14__5__3() { RunFile(@"15.2.3.14-5-3.js"); }
        [Test(Description = "Object.keys - non-enumerable own accessor property of \'O\' is not defined in returned array")] public void _15_2_3_14__5__4() { RunFile(@"15.2.3.14-5-4.js"); }
        [Test(Description = "Object.keys - inherited enumerable data property of \'O\' is not defined in returned array")] public void _15_2_3_14__5__5() { RunFile(@"15.2.3.14-5-5.js"); }
        [Test(Description = "Object.keys - inherited enumerable accessor property of \'O\' is not defined in returned array")] public void _15_2_3_14__5__6() { RunFile(@"15.2.3.14-5-6.js"); }
        [Test(Description = "Object.keys - inherted enumerable data property that is over-ridden by non-enumerable own data property is not defined in returned array")] public void _15_2_3_14__5__7() { RunFile(@"15.2.3.14-5-7.js"); }
        [Test(Description = "Object.keys - inherted enumerable data property that is over-ridden by non-enumerable own accessor property is not defined in returned array")] public void _15_2_3_14__5__8() { RunFile(@"15.2.3.14-5-8.js"); }
        [Test(Description = "Object.keys - inherted enumerable accessor property that is over-ridden by non-enumerable own data property is not defined in returned array")] public void _15_2_3_14__5__9() { RunFile(@"15.2.3.14-5-9.js"); }
        [Test(Description = "Object.keys - \'value\' attribute of element in returned array is correct.")] public void _15_2_3_14__5__a__1() { RunFile(@"15.2.3.14-5-a-1.js"); }
        [Test(Description = "Object.keys - \'writable\' attribute of element of returned array is correct")] public void _15_2_3_14__5__a__2() { RunFile(@"15.2.3.14-5-a-2.js"); }
        [Test(Description = "Object.keys - \'enumerable\' attribute of element of returned array is correct")] public void _15_2_3_14__5__a__3() { RunFile(@"15.2.3.14-5-a-3.js"); }
        [Test(Description = "Object.keys - Verify that \'configurable\' attribute of element of returned array is correct")] public void _15_2_3_14__5__a__4() { RunFile(@"15.2.3.14-5-a-4.js"); }
        [Test(Description = "Object.keys - Verify that \'index\' of returned array is ascend by 1")] public void _15_2_3_14__5__b__1() { RunFile(@"15.2.3.14-5-b-1.js"); }
        [Test(Description = "Object.keys - the order of elements in returned array is the same with the order of properties in \'O\' (dense array)")] public void _15_2_3_14__6__1() { RunFile(@"15.2.3.14-6-1.js"); }
        [Test(Description = "Object.keys - the order of elements in returned array is the same with the order of properties in \'O\' (sparse array)")] public void _15_2_3_14__6__2() { RunFile(@"15.2.3.14-6-2.js"); }
        [Test(Description = "Object.keys - the order of elements in returned array is the same with the order of properties in \'O\' (String object)")] public void _15_2_3_14__6__3() { RunFile(@"15.2.3.14-6-3.js"); }
        [Test(Description = "Object.keys - the order of elements in returned array is the same with the order of properties in \'O\' (Arguments object)")] public void _15_2_3_14__6__4() { RunFile(@"15.2.3.14-6-4.js"); }
        [Test(Description = "Object.keys - the order of elements in returned array is the same with the order of properties in \'O\' (any other built-in object)")] public void _15_2_3_14__6__5() { RunFile(@"15.2.3.14-6-5.js"); }
        [Test(Description = "Object.keys - the order of elements in returned array is the same with the order of properties in \'O\' (global Object)")] public void _15_2_3_14__6__6() { RunFile(@"15.2.3.14-6-6.js"); }
    }
}