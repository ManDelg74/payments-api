using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PaymentsApi.Model;

public class Payment
{
    //#Id, Amount, Currency, Status, CreatedAt
    public int Id { get; set; }

[Range(1.00, 60.00, ErrorMessage = "Amount must be between 1.00 and 60.00")]
    public decimal Amount { get; set; }
    [Required(ErrorMessage ="Currency is required")]
    [StringLength(3,MinimumLength =3, ErrorMessage = "Currency must be 3 characters")]
    public string? Currency { get; set; }

    public PaymentStatus Status   {get;set;}
    public enum PaymentStatus
    {
        Pending, 
        Completed, 
        Failed
    };

    
    public DateTime CreatedAt { get; set; }


}
