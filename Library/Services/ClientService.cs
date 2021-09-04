using Library.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services
{
    public class ClientService
    {
        private readonly IMongoCollection<Client> _clients;

        public ClientService(ILibraryDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseString);

            _clients = database.GetCollection<Client>("Client");
        }

        public List<Client> Get() =>
            _clients.Find(client => true).ToList();

        public Client Get(string id) =>
            _clients.Find<Client>(client => client.Id == id).FirstOrDefault();
    }
}

