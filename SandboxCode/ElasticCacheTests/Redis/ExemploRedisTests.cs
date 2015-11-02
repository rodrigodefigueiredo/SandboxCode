using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticCache.Redis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ElasticCache.Redis.Tests
{
    [TestClass()]
    public class ExemploRedisTests
    {
        [TestMethod()]
        public void Teste1Test()
        {
            new ElasticCache.Redis.ExemploRedis().TesteArmazenarChave();
        }
    }
}
