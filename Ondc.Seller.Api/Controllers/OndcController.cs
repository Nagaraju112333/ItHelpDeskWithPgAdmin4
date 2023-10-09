using Microsoft.AspNetCore.Mvc;
using Ondc.Seller.Processor.Interfaces;

namespace Ondc.Seller.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OndcController : ControllerBase
{
    public OndcController(IProductProcessor productProcessor, ILogger<ProductController> logger)
    {
    }

    [HttpPost]
    public async Task Search()
    {
        // drop the message in the service bus
        // send the ack back
    }
}