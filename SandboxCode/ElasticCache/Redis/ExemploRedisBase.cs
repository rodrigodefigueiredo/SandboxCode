using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ElasticCache.Redis
{
    public abstract class ExemploRedisBase
    {
        public int _redisPortNumber { get { return 8000; }}
        public string _redisEndpoint { get { return "localhost"; }  }
        protected RedisClient _redisClient;

        public ExemploRedisBase()
        {
            if (_redisClient == null)
                _redisClient = new RedisClient(this._redisEndpoint, this._redisPortNumber);
        }

        protected string GenerateKey(Assembly assembly, string sufixName)
        {
            return assembly.FullName + "." + sufixName;
        }
    }
}
