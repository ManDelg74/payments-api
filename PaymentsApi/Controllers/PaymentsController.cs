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
        public PaymentsController()
        {            
        }        

        //#GET /payments, 
        // GET all action
        [HttpGet]
        public ActionResult<List<Payment>> GetAll() =>
        PaymentServices.GetAll();


        //GET /payments/{id}, 
        [HttpGet("{id}")]
        public ActionResult<Payment> Get(int id){
            var tempPayment = PaymentServices.Get(id);

            if (tempPayment ==null)
            {
                return NotFound();
            }
            return tempPayment;
            
        }

        // POST /payments using an in-memory list
        [HttpPost]
        public IActionResult CREATE(Payment incomingPayment)
{
            PaymentServices.Add(incomingPayment);
            return CreatedAtAction(nameof(Get), new {Id = incomingPayment.Id, 
            Amount = incomingPayment.Amount, 
            Currency= incomingPayment.Currency,
            Status =   incomingPayment.Status, 
            CreatedAt = DateTime.Now }, incomingPayment);

        }

    }
}
