﻿namespace CinemaWorld.Services.Data.Common
{
    public static class ExceptionMessages
    {
        public const string MovieNotFound = "Movie with id {0} is not found.";

        public const string MovieAlreadyExists = "Movie with id {0} already exists";

        public const string DirectorNotFound = "Director with id {0} is not found.";

        public const string InvalidCinemaCategoryType = "Cinema category type {0} is invalid.";

        public const string GenreNotFound = "Genre with id {0} is not found.";

        public const string GenreAlreadyExists = "Genre with id {0} already exists";

        public const string MovieGenreNotFound = "Movie's genre with movie id {0} and genre id {1} is not found.";

        public const string DirectorAlreadyExists = "Director with id {0} already exists";

        public const string CountryAlreadyExists = "Country with id {0} already exists";

        public const string CountryNotFound = "Country with id {0} is not found.";

        public const string CinemaNotFound = "Cinema with id {0} is not found.";

        public const string CinemaAlreadyExists = "Cinema with id {0} already exists";

        public const string FaqNotFound = "Faq with id {0} is not found.";

        public const string FaqAlreadyExists = "Faq with id {0} already exists";

        public const string AlreadySentVote = "You cannot vote twice in the same day. To vote come back again tomorrow at";

        public const string UserShouldBeLoggedIn = "You have to log into your account in order to vote for a movie.";

        public const string AuthenticatedErrorMessage = "Please, login in order to vote.";

        public const string NewsAlreadyExists = "News with id {0} already exists";

        public const string NewsNotFound = "News with id {0} is not found.";

        public const string HallAlreadyExists = "Hall with id {0} already exists";

        public const string InvalidHallCategoryType = "Hall category type {0} is invalid.";

        public const string HallNotFound = "Hall with id {0} is not found.";

        public const string SeatAlreadyExists = "Seat with id {0} already exists";

        public const string InvalidSeatCategoryType = "Seat category type {0} is invalid.";

        public const string SeatNotFound = "Seat with id {0} is not found.";

        public const string InvalidHallCapacity = "Hall with id {0} has reached maximum {1} capacity";

        public const string MovieProjectionAlreadyExists = "Movie projection with id {0} already exists";

        public const string MovieProjectionNotFound = "Movie projection with id {0} is not found.";

        public const string InvalidTicketType = "Ticket type {0} is invalid.";

        public const string TicketAlreadyExists = "Ticket with id {0} already exists";

        public const string InvalidTimeSlot = "Time slot type {0} is invalid.";

        public const string TicketNotFound = "Ticket with id {0} is not found.";

        public const string SeatSoldError = "Seat with id {0} is sold.";
    }
}
