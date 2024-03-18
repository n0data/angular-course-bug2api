using MoviesAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Helpers
{
    public static class IQueryableExtension
    {


        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, PaginationDTO paginationDTO)
        {
            if (paginationDTO.Page < 1)
            {
                paginationDTO.Page = 1; // Default to the first page if page number is invalid
            }

            if (paginationDTO.RecordsPerPage < 1)
            {
                paginationDTO.RecordsPerPage = 10; // Default to 10 records per page if invalid
            }
            return queryable
                .Skip((paginationDTO.Page - 1) * paginationDTO.RecordsPerPage)
                .Take(paginationDTO.RecordsPerPage);
        }


    }
}
