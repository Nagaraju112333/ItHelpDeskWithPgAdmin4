using Microsoft.AspNetCore.Mvc;
using Ondc.Seller.Api.Extensions;
using Ondc.Seller.Api.Models.Response;
using Ondc.Seller.Domain.Entities;
using Ondc.Seller.Processor.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Ondc.Seller.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductProcessor _productProcessor;

        public ProductController(IProductProcessor productProcessor, ILogger<ProductController> logger)
        {
            _productProcessor = productProcessor;
        }

        [HttpGet("/Category/{sellerId}")]
        public async Task<ItemsResponse> GetProductCategories(string sellerId)
        {
            var response = new ItemsResponse();
            try
            {
                response.Items =  await _productProcessor.GetProductCategoriesAsync(sellerId);
                response.IsSuccess = true;
            }
            catch (OndcException ex)
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
        public async Task<ItemResponse> AddProduct([FromBody] Product product)
        {
            var response = new ItemResponse();
            try
            {
                response.Item = await _productProcessor.AddProductAsync(product);
                response.IsSuccess = true;
            }
            catch (OndcException ex)
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
}