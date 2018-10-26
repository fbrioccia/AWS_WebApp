using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MVC_Core.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            // var client = new MongoClient("mongodb://fab:esit@localhost:27017/?authSource=admin");
            var client = new MongoClient("mongodb://localhost:27017/");
            _db = client.GetDatabase("Devices");
        }


        public List<Device> GetDevices()
        {
            var col = _db.GetCollection<Device>("Device");
            List<Device> r = col.Find(_ => _.Id != null)
                .Project<Device>("{_id:1,device_id:1, model:1, description:1}").ToList();
            return r;
        }

        public List<Measurement> GetMeasurementByDates(string deviceId, string fromDate, string toDate)
        {

            var col = _db.GetCollection<Measurement>("Measurements");
            DateTime _fromDate = DateTime.ParseExact(fromDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime _toDate = DateTime.ParseExact(toDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var filter = Builders<Measurement>.Filter;
            var filter1 = filter.Eq(x => x.device_id, deviceId) & filter.Gte(x => x.timestamp, _fromDate) & filter.Lt(x => x.timestamp, _toDate);

            var f = col.Find(filter1).ToList();
            return f;
        }

        public Device GetDeviceById(string id)
        {
            var col = _db.GetCollection<Device>("Devices");
            List<Device> r = col.Find(_ => _.device_id == id).ToList();
            return r.First();
        }
    }
}