using Plaats;

Console.WriteLine("which place are you looking for?");
var searchPlace = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(searchPlace))
{
    var placeDatabase = new PlaceDatabase("geo");
    foreach (var place in placeDatabase.Search(searchPlace))
    {
        Console.WriteLine(place.Naam_2);
    }
}   