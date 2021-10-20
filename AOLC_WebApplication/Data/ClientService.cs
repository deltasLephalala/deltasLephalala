using AOLC_WebApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AOLCWebApplication.Data
{
    public class ClientService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public ClientService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Clients
        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _appDBContext.Clients.ToListAsync();
        }
        #endregion

        #region Insert Client
        public async Task<bool> InsertClientAsync(Client client)
        {
            await _appDBContext.Clients.AddAsync(client);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Client by Id
        public async Task<Client> GetClientAsync(int Id)
        {
            Client client = await _appDBContext.Clients.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return client;
        }
        #endregion

        #region Update Client
        public async Task<bool> UpdateClientAsync(Client client)
        {
            _appDBContext.Clients.Update(client);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteClient
        public async Task<bool> DeleteClientAsync(Client client)
        {
            _appDBContext.Remove(client);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}

