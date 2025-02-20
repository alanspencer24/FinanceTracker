using System.ComponentModel.DataAnnotations.Schema;

namespace Finance.Models;

[Table("Account", Schema="dbo")]
public class Account
{
    public int AccountId { get; set; }
    public string? AccountName { get; set; }
    public string? AccountDescription { get; set; }
    public Decimal Balance { get; set; }
    public AccountType AccountType { get; set; }
    public Decimal InterestRate { get; set; }

    //public List<Transaction> Transactions { get; set; }
    
    //public DateTime DueDate { get; set; }

}