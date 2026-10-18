using System;
using System.Security.Authentication;
using PaymentsApi.Model;

namespace PaymentsApi.Services;

public class PaymentServices : IPaymentServices
{
    // fake data
    static List<Payment> payment_example { get; }

    static PaymentServices()
    {
        payment_example = new List<Payment>
            {
                new Payment { Id = 1, Amount = 10.99M, Currency="usd", Status = Payment.PaymentStatus.Completed, CreatedAt = DateTime.Now },
                new Payment { Id = 2, Amount = 12.99M, Currency="usd", Status = Payment.PaymentStatus.Pending, CreatedAt = DateTime.Now },
                new Payment { Id = 3, Amount = 5.50M,  Currency="usd", Status = Payment.PaymentStatus.Pending ,CreatedAt=DateTime.Now}
            };
    }

    int nextId = 3;

    //public static List<Payment> GetAll() => payment_example;
    public List<Payment> GetAll()
    {
        var tempPayments = payment_example;
        return tempPayments;
    }
    
    //public static Payment? Get(int id) => payment_example.FirstOrDefault(p => p.Id == id);
     public Payment? GET(int id)
     {
         Payment? tempSinglePayment = payment_example.FirstOrDefault(p => p.Id == id);

         return tempSinglePayment;
     }
    // public static void Add(Payment incomingPayment)
    // {
    //     incomingPayment.Id = nextId++;
    //     incomingPayment.Status= Payment.PaymentStatus.Pending;
    //     payment_example.Add(incomingPayment);
    // }

     Payment IPaymentServices.Add(Payment incomingPayment)
     {
         var tempIncomingPayment = incomingPayment;

         tempIncomingPayment.Id = ++nextId;
         tempIncomingPayment.Status= Payment.PaymentStatus.Pending;
         tempIncomingPayment.CreatedAt=DateTime.Now;
         payment_example.Add(tempIncomingPayment);
         return tempIncomingPayment;
     }
}
