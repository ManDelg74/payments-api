using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi;
using PaymentsApi.Model;
using PaymentsApi.Services;

namespace PaymentsApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentServices _paymentServices;
        public PaymentsController(IPaymentServices paymentServices)
        {
            _paymentServices = paymentServices;
        }        

        //#GET /payments, 
        // GET all action
        [HttpGet]
        public ActionResult<List<Payment>> GetAll() => _paymentServices.GetAll();


        //GET /payments/{id}, 
        [HttpGet("{id}")]
        public ActionResult<Payment> GET(int id){

            Payment? tempPayment = _paymentServices.GET(id);

            if (tempPayment == null)
            {
                return NotFound();
            }
            return tempPayment;
            
        }

        // POST /payments using an in-memory list
        [HttpPost]
        public IActionResult CREATE(Payment incomingPayment)
{
            _paymentServices.Add(incomingPayment);
            return CreatedAtAction(nameof(GET), new {Id = incomingPayment.Id, 
            Amount = incomingPayment.Amount, 
            Currency= incomingPayment.Currency,
            Status =   incomingPayment.Status, 
            CreatedAt = DateTime.Now }, incomingPayment);

        }

    }
}
