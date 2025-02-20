using System.Transactions;

namespace Finance.Models;

public class Transaction
{
    public int TransactionId { get; set; }
    public Decimal Amount { get; set; }
    public TransactionStatus TransactionStatus { get ;set; }
    public Account? Account { get; set; }

}