using Pokekotas.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Pokekotas.Api.Extensions
{
    public static class BaseResponseExtension
    {
        public static ObjectResult ToHttpResult<T>(this BaseResponse<T> response)
        {
            if (!response.IsSuccess && response.ErrorCode is null)
                response.ErrorCode = StatusCodes.Status400BadRequest;

            return response.ErrorCode switch
            {
                StatusCodes.Status400BadRequest => new BadRequestObjectResult(response),
                StatusCodes.Status401Unauthorized => new UnauthorizedObjectResult(response),
                StatusCodes.Status404NotFound => new NotFoundObjectResult(response),
                StatusCodes.Status422UnprocessableEntity => new UnprocessableEntityObjectResult(response),
                _ => new OkObjectResult(response),
            };
        }
    }
}
