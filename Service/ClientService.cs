using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public class ClientService
    {
        private List<Client> _clients = new List<Client>
        {
            new Client {  Id = "1" , Name = "Omar"},
            new Client {  Id = "2" , Name = "Marco"},
            new Client {  Id = "3" , Name = "Luca"},
            new Client {  Id = "4" , Name = "Andrea"},
            new Client {  Id = "5" , Name = "Jonny"}
        };

        public IEnumerable<Client> GetClients()
        {
            return _clients;
        }
        public Client GetClient(string id)
        {
            return _clients.FirstOrDefault(x => x.Id == id);
        }

        public void AddClient(Client client)
        {
            _clients.Add(client);
        }

        public bool RemoveClient(string id)
        {
            return _clients.RemoveAll(x => x.Id == id) > 0;
        }
    }
}
