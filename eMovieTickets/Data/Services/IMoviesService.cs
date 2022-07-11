using eMovieTickets.Data.Base;
using eMovieTickets.Data.ViewModels;
using eMovieTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovie(NewMovieVM data);
        Task UpdateMovie(NewMovieVM data);
    }
}
