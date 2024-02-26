namespace Udemy.BankProject.Web.Data.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance{ get; set; }
        public int AccountNumber{ get; set; }
        public int ApplicationUserId{ get; set; }
        public ApplicationUser ApplicationUser{ get; set; }
    }
}
