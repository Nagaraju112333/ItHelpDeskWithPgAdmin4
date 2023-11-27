using Ondc.Seller.Api.Models.Response;
using Ondc.Seller.Domain.Entities;

namespace Ondc.Seller.Api.Extensions
{
    public static class ResponseExtensions
    {
        public static Error ToError(this ItHelpDeskException ex)
        {
            if (ex != null)
            {
                return new Error
                {
                    Code = ex.ErrorCode,
                    Message = ex.ErrorMessage,
                };
            }

            return null;
        }
    }
}
