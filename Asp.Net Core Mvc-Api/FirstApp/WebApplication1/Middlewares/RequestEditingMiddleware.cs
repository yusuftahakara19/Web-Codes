using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FirstApp.Middlewares
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate _requestDelegate;

        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        // request response httpContext ile ele alınabiliyor.
        public async Task Invoke(HttpContext context)
        {
            // ytk.com.tr/yusuf
            if (context.Request.Path.ToString() == "/yusuf")
                await context.Response.WriteAsync("hoşgeldin yusuf");
            else 
                await _requestDelegate.Invoke(context); //başka bir middleware'e veya  sunucuya geçme
        }
    }
}
