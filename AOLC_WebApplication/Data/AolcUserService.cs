using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AOLC_WebApplication.Data
{
    public class AolcUserService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public AolcUserService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Users
        public async Task<List<AolcUser>> GetAllUsersAsync()
        {
            return await _appDBContext.AolcUsers.ToListAsync();
        }
        #endregion

        #region Create User
        public async Task<bool> CreateUserAsync(AolcUser aolcUser)
        {
            await _appDBContext.AolcUsers.AddAsync(aolcUser);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get User by Id
        public async Task<AolcUser> GetUserAsync(int Id)
        {
            AolcUser aolcUser = await _appDBContext.AolcUsers.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return aolcUser;
        }
        #endregion

        #region Update User
        public async Task<bool> UpdateUserAsync(AolcUser aolcUser)
        {
            _appDBContext.AolcUsers.Update(aolcUser);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteUser
        public async Task<bool> DeleteUserAsync(AolcUser aolcUser)
        {
            _appDBContext.Remove(aolcUser);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
   
