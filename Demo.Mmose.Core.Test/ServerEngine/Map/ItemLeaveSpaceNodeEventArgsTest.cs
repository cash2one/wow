﻿using Demo.Mmose.Core.Map;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.Mmose.Core.Entity.Item;

namespace Demo.Mmose.Core.Test
{
    /// <summary>
    ///这是 ItemLeaveSpaceNodeEventArgsTest 的测试类，旨在
    ///包含所有 ItemLeaveSpaceNodeEventArgsTest 单元测试
    ///</summary>
    [TestClass()]
    public class ItemLeaveSpaceNodeEventArgsTest
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
        ///Item 的测试
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            BaseItem item = null; // TODO: 初始化为适当的值
            MapSpaceNode mapSpaceNode = null; // TODO: 初始化为适当的值
            ItemLeaveSpaceNodeEventArgs target = new ItemLeaveSpaceNodeEventArgs( item, mapSpaceNode ); // TODO: 初始化为适当的值
            BaseItem actual;
            actual = target.Item;
            Assert.Inconclusive( "验证此测试方法的正确性。" );
        }

        /// <summary>
        ///ItemLeaveSpaceNodeEventArgs 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void ItemLeaveSpaceNodeEventArgsConstructorTest()
        {
            BaseItem item = null; // TODO: 初始化为适当的值
            MapSpaceNode mapSpaceNode = null; // TODO: 初始化为适当的值
            ItemLeaveSpaceNodeEventArgs target = new ItemLeaveSpaceNodeEventArgs( item, mapSpaceNode );
            Assert.Inconclusive( "TODO: 实现用来验证目标的代码" );
        }
    }
}
