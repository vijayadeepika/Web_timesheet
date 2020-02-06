using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webtimesheet_practicing.models;

namespace webtimesheet_practice.Interface
{
    public interface IRegistration
    {
        bool CheckUserNameExists(string Username);
        int AddUser(Registration entity);
      //  IQueryable<Registration> ListofRegisteredUser(string sortColumn, string sortColumnDir, string Search);
      //  bool UpdatePassword(string RegistrationID, string Password);
    }
}
