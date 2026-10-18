using System;
using System.Security.Authentication;
using PaymentsApi.Model;

namespace PaymentsApi.Services;

public interface IPaymentServices
{
    //IEnumerable<List<Payment>> GetAll(); //current note to self
    List<Payment> GetAll(); //which of these 2 should i use. AND WHY


    Payment? GET(int id);
    Payment Add(Payment incomingPayment);
}
