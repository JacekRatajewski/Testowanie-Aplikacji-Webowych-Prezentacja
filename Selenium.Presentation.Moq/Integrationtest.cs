using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace Selenium.Presentation.Moq
{
    [TestFixture]
    public class IntegrationTest
    {
        private TransactionScope tarnsaction;

        [SetUp]
        public void SetUp()
        {
            tarnsaction = new TransactionScope(TransactionScopeOption.Required);
        }

        [TearDown]
        public void TearDown()
        {
            tarnsaction?.Dispose();
        }

        [Test]
        public void Test()
        //{
        //    var connectionString = "SERVER = (local); Initial Catalog = TS; Integrated Security = SSPI; ";
        //    Func<IDbConnection> dbConnectionFactory = () => new SqlConnection(connectionString);
        //    var repo = new Repo(dbConnectionFactory);

        //    repo.Get();
        }
    }
}
