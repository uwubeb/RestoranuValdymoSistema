using System.Net;
using RestoranuValdymoSistema.Data.Exceptions;

namespace RestoranuValdymoSistema.Middleware;


public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            switch (error)
            {
                case AppException e:
                    // custom application error
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    await WriteErrorToResponse(response, error.Message);
                    break;
                case NotFoundException e:
                    // not found error
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    await WriteErrorToResponse(response, error.Message);
                    break;
              
                default:
                    // unhandled error
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    await WriteErrorToResponse(response, error.Message);
                    break;
            }
        }
    }

    private static async Task WriteErrorToResponse(HttpResponse response, string message)
    {
        await response.WriteAsJsonAsync(new { message });
    }
}
