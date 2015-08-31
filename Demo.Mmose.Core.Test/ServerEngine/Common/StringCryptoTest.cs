﻿using Demo.Mmose.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Mmose.Core.Test
{
    /// <summary>
    ///这是 StringCryptoTest 的测试类，旨在
    ///包含所有 StringCryptoTest 单元测试
    ///</summary>
    [TestClass()]
    public class StringCryptoTest
    {
        private TestContext testContextInstance;
        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        #region 附加测试属性
        // 
        //编写测试时，还可使用以下属性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///EncryptString 的测试
        ///</summary>
        [TestMethod()]
        public void EncryptStringTest()
        {
            string strBase64KEY = string.Empty; // TODO: 初始化为适当的值
            string strBase64IV = string.Empty; // TODO: 初始化为适当的值
            string strValue = string.Empty; // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = StringCrypto.EncryptString( strBase64KEY, strBase64IV, strValue );
            Assert.AreEqual( expected, actual );
            Assert.Inconclusive( "验证此测试方法的正确性。" );
        }

        /// <summary>
        ///Encrypt 的测试
        ///</summary>
        [TestMethod()]
        public void EncryptTest()
        {
            string strBase64KEY = string.Empty; // TODO: 初始化为适当的值
            string strBase64IV = string.Empty; // TODO: 初始化为适当的值
            StringCrypto target = new StringCrypto( strBase64KEY, strBase64IV ); // TODO: 初始化为适当的值
            string strValue = string.Empty; // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = target.Encrypt( strValue );
            Assert.AreEqual( expected, actual );
            Assert.Inconclusive( "验证此测试方法的正确性。" );
        }

        /// <summary>
        ///DecryptString 的测试
        ///</summary>
        [TestMethod()]
        public void DecryptStringTest()
        {
            string strBase64KEY = string.Empty; // TODO: 初始化为适当的值
            string strBase64IV = string.Empty; // TODO: 初始化为适当的值
            string strValue = string.Empty; // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = StringCrypto.DecryptString( strBase64KEY, strBase64IV, strValue );
            Assert.AreEqual( expected, actual );
            Assert.Inconclusive( "验证此测试方法的正确性。" );
        }

        /// <summary>
        ///Decrypt 的测试
        ///</summary>
        [TestMethod()]
        public void DecryptTest()
        {
            string strBase64KEY = string.Empty; // TODO: 初始化为适当的值
            string strBase64IV = string.Empty; // TODO: 初始化为适当的值
            StringCrypto target = new StringCrypto( strBase64KEY, strBase64IV ); // TODO: 初始化为适当的值
            string strValue = string.Empty; // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = target.Decrypt( strValue );
            Assert.AreEqual( expected, actual );
            Assert.Inconclusive( "验证此测试方法的正确性。" );
        }

        /// <summary>
        ///StringCrypto 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void StringCryptoConstructorTest()
        {
            string strBase64KEY = string.Empty; // TODO: 初始化为适当的值
            string strBase64IV = string.Empty; // TODO: 初始化为适当的值
            StringCrypto target = new StringCrypto( strBase64KEY, strBase64IV );
            Assert.Inconclusive( "TODO: 实现用来验证目标的代码" );
        }
    }
}
