public class Movie {
    public string name;
    public string director;
    private string rating;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public Movie(string aName, string aDirector, string aRating) {
        name = aName;
        director = aDirector;
        Rating = aRating;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public string Rating {
        get { return rating; }
        set {
            if (value == "R") {
                rating = value;
            }else {
                rating = "NR";
            }
        }
    }
}
