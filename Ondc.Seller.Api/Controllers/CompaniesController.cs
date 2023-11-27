using Microsoft.AspNetCore.Mvc;
using Ondc.Seller.Api.Extensions;
using Ondc.Seller.Api.Models.Response;
using Ondc.Seller.Domain.Entities;


namespace Ondc.Seller.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompaniesController : ControllerBase
{
  /*  private readonly ICompaniesProcessor _productProcessor;*/

    public CompaniesController( ILogger<CompaniesController> logger)
    {
        //_productProcessor = productProcessor;
    }

    [HttpGet("/Category/{sellerId}")]
    public async Task<ItemsResponse> GetProductCategories(string sellerId)
    {
        var response = new ItemsResponse();
        try
        {
          //  response.Items =  await _productProcessor.GetProductCategoriesAsync(sellerId);
            response.IsSuccess = true;
        }
        catch (ItHelpDeskException ex)
        {
            response.Error = ex.ToError();
        }
        catch (Exception ex)
        {
            response.IsSuccess = false;
        }

        return response;
    }

    [HttpPost()]
    public async Task<ItemResponse> AddProduct([FromBody] Companies product)
    {
        var response = new ItemResponse();
        try
        {
           // response.Item = await _productProcessor.AddProductAsync(product);
            response.IsSuccess = true;
        }
        catch (ItHelpDeskException ex)
        {
            response.Error = ex.ToError();
        }
        catch (Exception ex)
        {
            response.IsSuccess = false;
        }

        return response;
    }
}