using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Primitives.Lib.CustomObjectResults;

/// <summary>
/// Кастомный объект ObjectResult представляющий ошибку InternalServerError
/// </summary>
public class InternalServerErrorObjectResult : ObjectResult
{
    public InternalServerErrorObjectResult(object? value) : base(value)
    {
        StatusCode = StatusCodes.Status500InternalServerError;
    }
}
