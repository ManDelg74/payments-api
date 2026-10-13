using Microsoft.AspNetCore.Mvc;

namespace PaymentsApi.Model;

public class Payment
{
    //#Id, Amount, Currency, Status, CreatedAt
    public long Id { get; set; }
    public decimal Amount { get; set; }
    public string? Currency { get; set; }
    public string? Status { get; set; }
    public DateTime CreatedAt { get; set; }


}
