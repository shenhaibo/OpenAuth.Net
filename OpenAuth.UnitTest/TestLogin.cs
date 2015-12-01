﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenAuth.App;
using OpenAuth.Repository;

namespace OpenAuth.UnitTest
{
    /// <summary>
    /// TestLogin 的摘要说明
    /// </summary>
    [TestClass]
    public class TestLogin
    {
        

        [TestMethod]
        public void Test()
        {
            var login = new LoginApp(new UserRepository(), new ModuleRepository(),  new RelevanceRepository());
            var user = login.Login("admin", "admin");
            foreach (var module in user.Modules)
            {
                Console.WriteLine(module.Id +"\t" + module.Name);
            }
        }
    }
}
