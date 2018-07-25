using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Core.DbClasses
{
    public class DeviceContext
    {
        private readonly IMongoDatabase _db;

        public DeviceContext(IOptions<DbSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public DeviceContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _db = client.GetDatabase("test");
        }

        public List<Device> GetDevices()
        {
            var col = _db.GetCollection<Device>("Devices");
            List<Device> r = col.Find(_ => _.Id != null)
                .Project<Device>("{_id:1,device_id:1, model:1, description:1}").ToList();
            return r;
        }
    }
}