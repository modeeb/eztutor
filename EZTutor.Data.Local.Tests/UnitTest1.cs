using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EZTutor.Data.Local.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using EZTutor.Data.Local.Domain;

namespace EZTutor.Data.Local.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Provider provider = new Provider();
            provider.SQLiteSessionFactory.OpenSession();
        }
    }
}
