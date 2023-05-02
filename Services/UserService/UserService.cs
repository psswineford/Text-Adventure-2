using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Text_Adventure_2.Data;
using Text_Adventure_2.Models;

namespace Text_Adventure_2.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext context;

        public UserService(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await this.context.Users.ToListAsync();
        }

        //change to single
        public async Task<User> LoginUser(string username, string password)
        {
            foreach (var i in this.context.Users)
            {
                if (i.Username == username && i.Password == password)
                {

                    return await this.context.Users.FindAsync(i.Id);
                }
            }
            throw new Exception("User Not Found");

        }

        public async Task<User> AddUser(User user)
        {
            foreach(var i in this.context.Users.ToList())
            {
                if(i.Username == user.Username)
                {
                    throw new Exception("User Already Exists");
                }    
            }
            this.context.Users.Add(user);
            await this.context.SaveChangesAsync();
            return user; //Fix this line, only return this user
        }


    }
}
