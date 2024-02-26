using System.Collections.Generic;

namespace Udemy.BankProject.Web.Data.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public List<Account> Accounts{ get; set; }
    }
}
