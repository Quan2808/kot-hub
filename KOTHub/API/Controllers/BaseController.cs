// namespace KOT_Hub.Controllers;
//
// using Microsoft.AspNetCore.Mvc;
// using System;
// using System.Net;
// using Microsoft.Extensions.Logging;
//
// /// <summary>
// /// Base controller providing common functionality for API controllers.
// /// </summary>
// [ApiController]
// [Route("[controller]")]
// public abstract class BaseController : ControllerBase
// {
//     private readonly ILogger<BaseController> _logger;
//
//     /// <summary>
//     /// Initializes a new instance of the <see cref="BaseController"/> class.
//     /// </summary>
//     /// <param name="logger">The logger instance for logging controller actions.</param>
//     protected BaseController(ILogger<BaseController> logger)
//     {
//         _logger = logger ?? throw new ArgumentNullException(nameof(logger));
//     }
//
//     /// <summary>
//     /// Returns a standardized success response.
//     /// </summary>
//     /// <typeparam name="T">The type of the data to return.</typeparam>
//     /// <param name="data">The data to include in the response.</param>
//     /// <param name="message">An optional message to include in the response.</param>
//     /// <returns>An IActionResult representing a successful response.</returns>
//     protected IActionResult Success<T>(T data, string message = "Request successful")
//     {
//         _logger.LogInformation("{Message}", message);
//         return Ok(new ApiResponse<T>
//         {
//             Success = true,
//             Data = data,
//             Message = message,
//             StatusCode = (int)HttpStatusCode.OK
//         });
//     }
//
//     /// <summary>
//     /// Returns a standardized created response with a location URI.
//     /// </summary>
//     /// <typeparam name="T">The type of the created resource.</typeparam>
//     /// <param name="data">The created resource data.</param>
//     /// <param name="location">The URI of the created resource.</param>
//     /// <param name="message">An optional message to include in the response.</param>
//     /// <returns>An IActionResult representing a created response.</returns>
//     protected IActionResult CreatedResponse<T>(T data, string location, string message = "Resource created")
//     {
//         _logger.LogInformation("{Message}", message);
//         return Created(location, new ApiResponse<T>
//         {
//             Success = true,
//             Data = data,
//             Message = message,
//             StatusCode = (int)HttpStatusCode.Created
//         });
//     }
//
//     /// <summary>
//     /// Returns a standardized error response.
//     /// </summary>
//     /// <param name="message">The error message to include in the response.</param>
//     /// <param name="statusCode">The HTTP status code for the error.</param>
//     /// <returns>An IActionResult representing an error response.</returns>
//     protected IActionResult Error(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
//     {
//         _logger.LogError("{Message} - StatusCode: {StatusCode}", message, statusCode);
//         return StatusCode((int)statusCode, new ApiResponse<object>
//         {
//             Success = false,
//             Message = message,
//             StatusCode = (int)statusCode
//         });
//     }
//
//     /// <summary>
//     /// Validates the model state and returns a bad request response if invalid.
//     /// </summary>
//     /// <returns>An IActionResult if the model state is invalid; otherwise, null.</returns>
//     protected IActionResult ValidateModel()
//     {
//         if (!ModelState.IsValid)
//         {
//             var errors = ModelState.Values
//                 .SelectMany(v => v.Errors)
//                 .Select(e => e.ErrorMessage)
//                 .ToList();
//             var errorMessage = string.Join("; ", errors);
//             _logger.LogWarning("Model validation failed: {ErrorMessage}", errorMessage);
//             return Error(errorMessage, HttpStatusCode.BadRequest);
//         }
//
//         return null!;
//     }
//
//     /// <summary>
//     /// Handles an exception and returns a standardized error response.
//     /// </summary>
//     /// <param name="ex">The exception to handle.</param>
//     /// <param name="message">An optional custom error message.</param>
//     /// <returns>An IActionResult representing the error response.</returns>
//     protected IActionResult HandleException(Exception ex, string message = "An unexpected error occurred")
//     {
//         _logger.LogError(ex, "{Message}", message);
//         return Error(message, HttpStatusCode.InternalServerError);
//     }
// }
//
// /// <summary>
// /// Represents a standardized API response.
// /// </summary>
// /// <typeparam name="T">The type of the data in the response.</typeparam>
// public class ApiResponse<T>
// {
//     /// <summary>
//     /// Gets or sets a value indicating whether the request was successful.
//     /// </summary>
//     public bool Success { get; set; }
//
//     /// <summary>
//     /// Gets or sets the data returned by the API.
//     /// </summary>
//     public T Data { get; set; }
//
//     /// <summary>
//     /// Gets or sets the message describing the result.
//     /// </summary>
//     public string Message { get; set; }
//
//     /// <summary>
//     /// Gets or sets the HTTP status code of the response.
//     /// </summary>
//     public int StatusCode { get; set; }
// }