﻿using Demo.Mmose.Core.Network;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Mmose.Core.Test
{
    /// <summary>
    ///这是 IPacketEncoderTest 的测试类，旨在
    ///包含所有 IPacketEncoderTest 单元测试
    ///</summary>
    [TestClass()]
    public class IPacketEncoderTest
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
        ///EncodeOutgoingPacket 的测试
        ///</summary>
        [TestMethod()]
        public void EncodeOutgoingPacketTest()
        {
            IPacketEncoder target = CreateIPacketEncoder(); // TODO: 初始化为适当的值
            NetState netStateTo = null; // TODO: 初始化为适当的值
            byte[] byteBuffer = null; // TODO: 初始化为适当的值
            byte[] byteBufferExpected = null; // TODO: 初始化为适当的值
            long iLength = 0; // TODO: 初始化为适当的值
            long iLengthExpected = 0; // TODO: 初始化为适当的值
            target.EncodeOutgoingPacket( netStateTo, ref byteBuffer, ref iLength );
            Assert.AreEqual( byteBufferExpected, byteBuffer );
            Assert.AreEqual( iLengthExpected, iLength );
            Assert.Inconclusive( "无法验证不返回值的方法。" );
        }

        internal virtual IPacketEncoder CreateIPacketEncoder()
        {
            // TODO: 实例化相应的具体类。
            IPacketEncoder target = null;
            return target;
        }

        /// <summary>
        ///DecodeIncomingPacket 的测试
        ///</summary>
        [TestMethod()]
        public void DecodeIncomingPacketTest()
        {
            IPacketEncoder target = CreateIPacketEncoder(); // TODO: 初始化为适当的值
            NetState netStateFrom = null; // TODO: 初始化为适当的值
            byte[] byteBuffer = null; // TODO: 初始化为适当的值
            byte[] byteBufferExpected = null; // TODO: 初始化为适当的值
            long iLength = 0; // TODO: 初始化为适当的值
            long iLengthExpected = 0; // TODO: 初始化为适当的值
            target.DecodeIncomingPacket( netStateFrom, ref byteBuffer, ref iLength );
            Assert.AreEqual( byteBufferExpected, byteBuffer );
            Assert.AreEqual( iLengthExpected, iLength );
            Assert.Inconclusive( "无法验证不返回值的方法。" );
        }
    }
}
