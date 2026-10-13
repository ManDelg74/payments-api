using System;
using System.Security.Authentication;
using PaymentsApi.Model;

namespace PaymentsApi.Services;

public class PaymentServices
{
    // fake data
    static List<Payment> payment_example { get; }

    static PaymentServices()
    {
        payment_example = new List<Payment>
            {
                new Payment { Id = 1, Amount = 10.99M, Currency="usd", Status="Start", CreatedAt = DateTime.Now },
                new Payment { Id = 2, Amount = 12.99M, Currency="usd", Status="Start", CreatedAt = DateTime.Now }
            };
    }

    static int nextId = 3;

    public static List<Payment> GetAll() => payment_example;

    public static Payment? Get(int id) => payment_example.FirstOrDefault(p => p.Id == id);

    public static void Add(Payment incomingPayment)
    {
        incomingPayment.Id = nextId++;
        payment_example.Add(incomingPayment);
    }
}
