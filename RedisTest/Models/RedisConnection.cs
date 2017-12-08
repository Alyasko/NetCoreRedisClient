using System;
using System.Net.NetworkInformation;
using Microsoft.IdentityModel.Protocols;
using StackExchange.Redis;

namespace RedisTest.Models
{
    public class RedisConnection
    {
        private static Lazy<ConnectionMultiplexer> _connectionMultiplexer = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect("alyasko.redis.cache.windows.net:6380,password=vi7gmNWkwnnZRUnAAO2H8YPegWvEMsA/PG5CHyFzYBY=,ssl=True,abortConnect=False"));
        
        public static ConnectionMultiplexer ConnectionMultiplexer => _connectionMultiplexer.Value;
        public static IDatabase RedixDatabase = ConnectionMultiplexer.GetDatabase();
    }
}