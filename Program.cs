using System;

class WatchExactlyTwoMovies {
    public static void Main(string[] args) {
        
        // initializing variables

        int flightLength = 160;
        List<int> moviesLength = new List<int>() {60, 80, 90, 100, 120, 70};

        bool watchMovies = WatchTwoMovies(flightLength, moviesLength);
        Console.WriteLine($"I can watch exactly two movies: {watchMovies}");

    }

    public static bool WatchTwoMovies(int flightLength, List<int> movieLengths) {
        Dictionary<int, bool> viewLength = new Dictionary<int, bool>();
        foreach(int length in movieLengths) {
            int timeLeft = flightLength - length;
            if(viewLength.ContainsKey(timeLeft) && viewLength[timeLeft]) {
                return true;
            }
            viewLength[length] = true;
        }

        return false;
    }

}

 

 





/*
Users on longer flights like to start a second movie right when their first one ends, but
    they complain that the plane usually lands before they can see the ending. So you're building
    a feature for choosing two movies whose total runtimes will equal the exact flight length.
 
    Write a function that takes an integer flight_length(in minutes) and a list of integers
    movie_lengths(in minutes) and returns a boolean indicating whether there are two movies in
    movie_length whose sum equals flight_length.
 
    When building your function:
    1. Assume your users will watch exactly two movies
    2. Don't make your users watch the same movie twice

*/
