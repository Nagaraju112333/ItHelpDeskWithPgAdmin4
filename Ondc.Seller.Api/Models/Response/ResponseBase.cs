﻿namespace Ondc.Seller.Api.Models.Response;

public class ResponseBase
{
    public ResponseBase()
    {
        Error = new Error();
    }

    public bool IsSuccess { get; set; }

    public Error Error { get; set; }
}
