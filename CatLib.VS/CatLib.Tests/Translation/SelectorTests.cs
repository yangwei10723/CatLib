﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 * 
 * Document: http://catlib.io/
 */

using CatLib.API.Translation;
using CatLib.Translation;
#if UNITY_EDITOR || NUNIT
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Category = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;
#endif

namespace CatLib.Tests.Translation
{
    [TestClass]
    public class SelectorTests
    {
        [TestMethod]
        public void TestBaseSelect()
        {
            var selector = new Selector();
            Assert.AreEqual("hello this is test", selector.Choose("hello this is test", 10, Language.Chinese));
        }

        [TestMethod]
        public void TestRangSelect()
        {
            var selector = new Selector();
            Assert.AreEqual("world", selector.Choose("[*,9]hello|[10,20]world", 10, Language.Chinese));
        }
    }
}