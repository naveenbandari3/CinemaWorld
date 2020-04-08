﻿namespace CinemaWorld.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using CinemaWorld.Models.ViewModels;
    using CinemaWorld.Models.ViewModels.Movies;
    using CinemaWorld.Services.Data.Contracts;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private const decimal RatingInSlider = 6;
        private const int TopMoviesInHeaderSliderCount = 6;
        private const int RecentlyAddedMoviesCount = 12;

        private readonly IMoviesService moviesService;

        public HomeController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        public async Task<IActionResult> Index(string email)
        {
            if (email != null)
            {
                return this.RedirectToAction("ThankYouSubscription", new { email = email });
            }

            var allMovies = await this.moviesService
                .GetAllMoviesAsync<TopRatingMovieDetailsViewModel>();
            var topMoviesInSlider = await this.moviesService
                .GetTopMoviesAsync<SliderMovieDetailsViewModel>(RatingInSlider);
            var topRatingMovies = await this.moviesService
                .GetTopMoviesAsync<TopRatingMovieDetailsViewModel>();
            var recentlyAddedMovies = await this.moviesService
                .GetRecentlyAddedMoviesAsync<RecentlyAddedMovieDetailsViewModel>(RecentlyAddedMoviesCount);

            var viewModel = new MoviesHomePageListingViewModel
            {
                AllMovies = allMovies
                    .OrderByDescending(x => x.StarRatingsSum)
                    .ThenByDescending(x => x.DateOfRelease.Year)
                    .ToList(),
                TopMoviesInSlider = topMoviesInSlider
                    .Take(TopMoviesInHeaderSliderCount)
                    .ToList(),
                TopRatingMovies = topRatingMovies
                    .OrderByDescending(x => x.StarRatingsSum)
                    .ThenByDescending(x => x.DateOfRelease.Year)
                    .ToList(),
                RecentlyAddedMovies = recentlyAddedMovies,
            };

            return this.View(viewModel);
        }

        public IActionResult ThankYouSubscription(string email)
        {
            return this.View("SuccessfullySubscribed", email);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        public IActionResult HttpError(HttpErrorViewModel errorViewModel)
        {
            if (errorViewModel.StatusCode == 404)
            {
                return this.View(errorViewModel);
            }

            return this.View(
                "Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
