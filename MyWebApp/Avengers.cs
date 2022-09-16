namespace MyWebApp
{
    public class Avengers
    {
        List<Character> characters = new List<Character>() {
            new Character() {Id = 1, Name = "Iron Man"},
            new Character() {Id = 2, Name = "Captain America"},
            new Character() {Id = 3, Name = "Black Widow"}
        };
        public List<Character> GetCharacters() => characters;

        public Character? GetCharacter(int id) => characters.Find(x => x.Id == id);
    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
