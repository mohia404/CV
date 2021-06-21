using CV.Core.Services.Interfaces;
using CV.DataLayer.Context;
using CV.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Services
{
    public class UserService : IUserService
    {
        private CvContext _context;

        public UserService(CvContext context)
        {
            _context = context;
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }
    }
}
