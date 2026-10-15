using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PaymentsApi.Model;

public class Payment
{
    //#Id, Amount, Currency, Status, CreatedAt
    public long Id { get; set; }

[Range(1.00, 60.00, ErrorMessage = "Amount must be between 1.00 and 60.00")]
    public decimal Amount { get; set; }
    [Required(ErrorMessage ="Currency is required")]
    [StringLength(3, ErrorMessage = "Currency must be 4 characters")]
    public string? Currency { get; set; }
    [Required(ErrorMessage ="Status is required")]
    
    [StringLength(10,MinimumLength =1,  ErrorMessage = "Status must exist")]
    public string? Status { get; set; }
    public DateTime CreatedAt { get; set; }


}
