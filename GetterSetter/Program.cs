public class Program {
    public static void Main(string[] args) {
        Movie avenger = new Movie("Avengers", "Somebody", "PG");
        Movie grudge = new Movie("The Grudge", "Anybody", "D");

        avenger.Rating = "E";
        Console.WriteLine(avenger.Rating);
        
    }
}