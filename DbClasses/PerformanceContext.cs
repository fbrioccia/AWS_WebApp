using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Linq;

namespace MVC_Core.DbClasses
{
public class PerformanceContext
{
    private readonly IMongoDatabase _db;

    public PerformanceContext(IOptions<DbSettings> options)
    {
        var client = new MongoClient(options.Value.ConnectionString);
        _db = client.GetDatabase(options.Value.Database);
    }

    public PerformanceContext()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _db =  client.GetDatabase("test");
    }
    public IMongoCollection<Performance> GetPerformances()
    {
        var col = _db.GetCollection<Performance>("Performance");
        Performance r = col.Find(_ => _.Id != null).First();
        return col;
    }
}
}