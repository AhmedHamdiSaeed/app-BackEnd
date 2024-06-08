using Microsoft.AspNetCore.Http;

namespace app.Extentions
{
    public record ApiResponse(int StatusCode,string Message,object Data);
}
