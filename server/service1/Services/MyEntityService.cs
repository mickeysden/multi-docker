using System;
using System.Collections.Generic;
using service1.Models;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace service1.Services
{
    public interface IMyEntityService
    {
        Task<IList<MyEntity>> Get();
    }

    public class MyEntityService : IMyEntityService
    {
        private readonly IMongoCollection<MyEntity> _myEntitys;

        public MyEntityService()
        {
            _myEntitys = MongoContext.GetMongoContext();
            Console.WriteLine("connected to mongo");
            this.Seed().Wait();
        }
        public async Task<IList<MyEntity>> Get()
        {
            return await _myEntitys.Find(MyEntity => true).ToListAsync();
        }

        private void Create(MyEntity MyEntity)
        {
            _myEntitys.InsertOne(MyEntity);
        }

        private async Task Seed()
        {
            var list = await this.Get();
            if (list.Count == 0)
            {
                this.Create(new MyEntity() { Name = "Clark", Value = "Kent" });
                this.Create(new MyEntity() { Name = "Mickey", Value = "value" });
            }
        }
    }
}