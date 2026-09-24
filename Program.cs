Random random = new Random();
TypeEffects type = new TypeEffects();
int delay = 20;
long possibleCombinations;


string[] genre = new string[] { "Action", "Comedy", "Drama", "Horror", "Romance", "Sci-Fi", "Thriller", "Fantasy", "Mystery", "Adventure", "Crime", "Historical", "Musical", "Western", "War", "Documentary", "Animation", "Family", "Sports", "Biographical", "Fanfic", "Parody" };
string[] setting = new string[] { "Medieval", "Modern", "Futuristic", "Post-Apocalyptic", "Fantasy", "Space", "Underwater", "Urban", "Rural", "Desert", "Jungle", "Arctic", "Virtual Reality", "Steampunk", "Cyberpunk", "Noir", "Historical", "Mythical", "Supernatural", "Dystopian" };
string[] strings = new string[] { "A group of friends", "A lone hero", "An unlikely duo", "A family", "A team of misfits", "A secret society",("A mysterious stranger"),("An alien race"),("A talking animal"),("A time traveler"), "The worst friendgroup in existence"};
string[] protagonist = new string[] { "a 3D printer enthusiast", "an idiot","a single mother of five","an unfunny comedian","a ruthless dictator", "a brave warrior", "a clever detective", "a rebellious teenager", "a wise mentor", "a cunning villain", "a charming rogue", "a misunderstood genius", "a loyal companion", "a fearless leader", "a reluctant hero" };
string[] protagonistTrait = new string[] { "who only got the power of laughter on their side","who is haunted by their past", "who is seeking redemption", "who is on a quest for power", "who is trying to save their loved ones", "who is struggling with their identity", "who is determined to uncover the truth", "who is torn between duty and desire", "who is facing a moral dilemma", "who is driven by revenge", "who is searching for meaning in life", "who thinks they're the chosen one", "who is trying to prove themselves", "who is hiding a dark secret", "who is obsessed with justice", "who is trying to overcome their fears", "who is dealing with a traumatic past", "who is trying to find their place in the world", "who is seeking to right a wrong" };
string[] antagonist = new string[] { "a 3D printer enthusiast","a cannibal hobbyist","the city of Detroit","a republican","their own last braincell","God","a confused demon","a serial killer","Jeffery Dahmer","a ruthless dictator", "a literal baby", "some random guy", "a vengeful ghost", "a really nice but misunderstood person","a child","a corrupt politician", "a good person", "a cunning thief", "a powerful sorcerer", "a dangerous criminal", "a manipulative business tycoon", "a jealous rival", "a monstrous creature", "an evil mastermind", "the british", "the government", "the french", "Mark Zuckerberg", "a wannabe hacker" };
string[] antagonistTrait = new string[] { "that is going through a lot right now","that is not very nice","that is seeking revenge", "that is trying to take over the world",("that is hiding a dark secret"),("that is obsessed with power"),("that is manipulating others for their own gain"),("that is driven by jealousy"),("that is haunted by their past"),("that is trying to prove themselves"),("that is seeking redemption"),("that is determined to destroy their enemies"), ("that is trying to cover up their crimes"),("that is seeking to control others"),("that is trying to achieve immortality"),("that is driven by greed"),("that is trying to create chaos"),("that is seeking to dominate others"),("that is trying to fulfill a prophecy"),("that is obsessed with revenge"),("that is about to give birth to the antichrist"), ("that is trying to save the world"), "that is on a mission to kill all puppies", "that is about to make an awful reboot of Lord Of The Rings", "that is trying to revive the dead" };
string[] motivation = new string[] { "to finally get some sleep","to get their parents lost respect","to save the world",("to find true love"),("to uncover a hidden truth"),("to seek revenge"),("to protect their family"),("to achieve greatness"),("to escape their past"),("to discover a new world"),("to prove themselves"),("to fulfill a prophecy"), "to have fun again", "to have something to do", "to save all the puppies" };

possibleCombinations = (long)strings.Length * setting.Length * genre.Length * protagonist.Length * protagonistTrait.Length * antagonist.Length * antagonistTrait.Length * motivation.Length;
Console.Clear();
Console.WriteLine($"Total possible combinations: {possibleCombinations}");
Console.WriteLine("Press enter to generate a random story idea, or type 'exit' to quit.");
while (true)
{
    string input = Console.ReadLine() ?? string.Empty;
    if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (!string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Press enter to generate a story idea, or type 'exit' to quit.");
        continue;
    }

    //Console.WriteLine($"{strings[random.Next(strings.Length)]} in a {setting[random.Next(setting.Length)]} {genre[random.Next(genre.Length)]} story, featuring {protagonist[random.Next(protagonist.Length)]} {protagonistTrait[random.Next(protagonistTrait.Length)]}, who must face {antagonist[random.Next(antagonist.Length)]} {antagonistTrait[random.Next(antagonistTrait.Length)]}, in order {motivation[random.Next(motivation.Length)].ToLowerInvariant()}.");
    Console.ForegroundColor = ConsoleColor.Cyan;
    await type.TypeWrite(strings[random.Next(strings.Length)], delay);
    Console.ForegroundColor = ConsoleColor.Gray;
    await type.TypeWrite(" in a ", delay);
    Console.ForegroundColor = ConsoleColor.Green;
    await type.TypeWrite(setting[random.Next(setting.Length)], delay);
    Console.ForegroundColor = ConsoleColor.Yellow;
    await type.TypeWrite(" ", delay);
    await type.TypeWrite(genre[random.Next(genre.Length)], delay);
    Console.ForegroundColor = ConsoleColor.Gray;
    await type.TypeWrite(" story, featuring\n", delay);
    Console.ForegroundColor = ConsoleColor.Magenta;
    await type.TypeWrite(protagonist[random.Next(protagonist.Length)], delay);
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    await type.TypeWrite(" ", delay);
    await type.TypeWrite(protagonistTrait[random.Next(protagonistTrait.Length)], delay);
    Console.ForegroundColor = ConsoleColor.Gray;
    await type.TypeWrite(", who must in their journey face ", delay);
    Console.ForegroundColor = ConsoleColor.Red;
    await type.TypeWrite(antagonist[random.Next(antagonist.Length)], delay);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    await type.TypeWrite("\n", delay);
    await type.TypeWrite(antagonistTrait[random.Next(antagonistTrait.Length)], delay);
    Console.ForegroundColor = ConsoleColor.Gray;
    await type.TypeWrite(", in order ", delay);
    Console.ForegroundColor = ConsoleColor.Blue;
    await type.TypeWrite(motivation[random.Next(motivation.Length)].ToLowerInvariant(), delay);
    Console.ForegroundColor = ConsoleColor.Gray;
    await type.TypeWrite(".\n\n", delay);
    Console.WriteLine("Press enter to generate a new random story idea, or type 'exit' to quit.");

}

