namespace Ondc.Seller.Domain.Entities;

public class OndcException : Exception
{
	public OndcException(string errorCode, string errorMessage)
	{
		ErrorCode = errorCode;
		ErrorMessage = errorMessage;
	}

	public string ErrorCode { get; set; }

    public string ErrorMessage { get; set; }
}
