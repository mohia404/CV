using CV.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Services.Interfaces
{
    public interface IUserService
    {
        int AddUser(User user);

        List<User> GetAllUsers();

    }
}
