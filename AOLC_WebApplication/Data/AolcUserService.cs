using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AOLC_WebApplication.Data
{
    public class AolcUserService
    {
        private readonly UserManager<AolcUser> userManager1;
        #region Property
        private readonly ApplicationDbContext _appDBContext;

        public string chosenRole { get; set; }
        #endregion

        #region Constructor
        public AolcUserService(ApplicationDbContext appDBContext, UserManager<AolcUser> userManager)
        {
            _appDBContext = appDBContext;
            userManager1 = userManager;
            chosenRole = "";
        }
        #endregion

        #region Get List of Users
        public async Task<List<AolcUser>> GetAllUsersAsync()
        {
            return await _appDBContext.AolcUsers.ToListAsync();
        }


        #endregion


        #region Get List of Users based on their roles
        public async Task<IList<AolcUser>> GetUsersInRoleAsync(string role)
        {
            IList<AolcUser> users = await userManager1.GetUsersInRoleAsync("Administrator");
            return users;

            IList<AolcUser> users1 = await userManager1.GetUsersInRoleAsync("Client");
            return users;

            IList<AolcUser> users2 = await userManager1.GetUsersInRoleAsync("Staff");
            return users;
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
        public async Task<AolcUser> GetUserAsync(string Id)
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
   
