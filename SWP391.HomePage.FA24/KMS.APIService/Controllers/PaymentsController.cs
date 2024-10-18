
using KMG.Repository.Models.Pay.Config;
using KMG.Repository.Models.Pay;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Options;
using System.Net;
using KMG.Repository.Models.Pay.Request;

namespace KMS.Repository.Controllers
{
    /// <summary>
    /// Payment api endpoints
    /// </summary>
    [Route("api/payment")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IMediator _mediator;
       
        private readonly VnPayConfig _vnPayConfig;
      
        /// <summary>
        /// Constructor
        /// </summary>
        public PaymentsController(IMediator mediator,
           
            IOptionsMonitor<VnPayConfig> monitor
            )
        {
            _mediator = mediator;
           
            _vnPayConfig = monitor.CurrentValue;
           
        }

        /// <summary>
        /// Create payment to get link
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultWithData<PaymentLinkResponse>), 200)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreatePayment([FromBody] CreatePaymentRequest request)
        {
            //// update course reservation payment status
            //await _courseReservationService.UpdateStatus(request.CourseReservationId,
            //    request.RequiredAmount);

            var reponse = new BaseResultWithData<PaymentLinkResponse>();
            reponse = await _mediator.Send(request);
            return Ok(reponse);
        }

     

        [HttpGet]
        [Route("notification-fail")]
        public async Task<IActionResult> FailPaymentNotification(int statusCode, string message)
        {
            if (statusCode == 200)
            {
                return Ok(new
                {
                    Success = true,
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = false,
                });
            }
        }

        [HttpGet]
        [Route("notification")]
        public async Task<IActionResult> PaymentNotification(int statusCode, string message)
        {
            if (statusCode == 200)
            {
                return Ok(new
                {
                    Success = true,
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = false,
                });
            }
        }
    }
}
