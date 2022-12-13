using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace WebApiAutores.Utilidades
{
    public static class HttpContextExtensions
    {
        public async static Task InsertarParametrosPaginacionEnCabezar<T>(this HttpContext httpContext,
            IQueryable<T> queryable)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }
            double cantidad = await queryable.CountAsync();
        }
    }
}
