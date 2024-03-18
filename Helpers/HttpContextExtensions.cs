using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Helpers
{
    public static class HttpContextExtensions
    {
        public async static Task InsertParametersPaginationInHeader<T>(this HttpContext httpContext,
            IQueryable<T> queryable)
        {

            if (httpContext == null)
            {
                Console.WriteLine("HttpContext is null in InsertParametersPaginationInHeader");
                return;
                // throw new ArgumentException(nameof(httpContext));
            }

            double count = await queryable.CountAsync();
            httpContext.Response.Headers.Add("totalAmountOfRecords", count.ToString());
        }
    }
}
