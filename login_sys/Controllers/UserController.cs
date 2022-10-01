using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


using login_sys.Data;
using login_sys.Models;

namespace login_sys.Controllers
{
    internal class UserController
    {
        private Context _context;
        public UserController(Context context)
        {
            this._context = context;
        }

        public User GetLogin(string? user, string? pass)
        {
            var _users = _context.Users;
            if (_users != null)
            {
                return _users.AsNoTracking()
                .Where(x => user == x.Login)
                .Where(x => pass == x.Password).FirstOrDefault();

            }
            else
            {
                throw new Exception("No Users found");
            }
        }
    }
}
