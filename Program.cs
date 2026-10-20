//THE BEGINNING OF HELL
// HERE LIES SPAGETTI!
//Imma comment on stuff. This will be as human made as my patience will go. If anything is AI assisted
//- By that I don't mean the AI finishing something I was already writing! I will NEVER use a purely ai code. The only option
// for AI to be included is if what I wrote didn't work and I still haven't figured it out in an hour, I will ask for ASSISTANCE, NOT
//THE FULL CODE!!
//Anyway, this is quite a rant- welcome to this jumble of spagetti code. It will run on my limited knowledge of C# and hopes and dreams
// :]

/* Idea No1;
 * NOTE PAD
 * 
 * You may ask why a note pad... WELL I DONT HAVE WHERE TO WRITE OTHER IDEAS
 */

//Here be setup
char UserChoice;
int noteToDeleteInt;
char tempUserChoice;
string favPokemonGuess;
int hint = 0;

#region Fav. Pokemon SPOILER!! TRY TO GUESS FIRT
string favpokemon = "Hisuian Zorua";
string favPokemonLowercase = "hisuian zorua";
string favPokemon3 = "Hisuian zoruak";
string favPokemon4 = "hisuian Zorua";
List<string> pokemonhints = new List<string>();
pokemonhints = ["2 types", "Ghost type", "basic pokemon (Not an evolution)", "Has an evolution", "Species: Spiteful Fox Pokémon", "National variant"];
//hints
#endregion


//Da main loop - The most abused thing here
while (true)
{
    Console.Clear();
    PrintGreen("Welcome to this... Thing... That I have created.");
    Console.WriteLine("Why use AI when you have me to make random bull*** nobody asked for >:]");

    PrintGreen("Click the number key of which... program... you want to try");
    Console.WriteLine("1. Note Pad");
    Console.WriteLine("2. Guess my favorite pokemon :]");

    UserChoice = Console.ReadKey().KeyChar;


    if (UserChoice == '1')
    #region NotePad
    {
        Console.Clear();
        PrintGreen("Welcome to this questionable note pad!");
        Console.WriteLine("This runs on a list, hopes and dreams. And if it works, it's a miracle");
        List<string> notes = new List<string>();
        PrintRed("press anything to continue");
        tempUserChoice = Console.ReadKey().KeyChar;

        while (true)
        {
            Console.Clear();
            PrintGreen("What would you like to do?");
            Console.WriteLine("a. Add a note");
            Console.WriteLine("b. Read all notes");
            Console.WriteLine("c. Delete a note");
            PrintRed("press q to exit to menu");


            tempUserChoice = Console.ReadKey().KeyChar;


            if (tempUserChoice == 'q')
            {
                break;
            }
            //=========================================================================Break bcuz I have trouble reading it all together :/
            if (tempUserChoice == 'a')
            {
                Console.Clear();
                PrintGreen("Type your note:");
                notes.Add(Console.ReadLine());
                PrintGreen($"Note {notes[notes.Count - 1]} added successfully.");
                PrintRed("press q to exit to menu");
                tempUserChoice = Console.ReadKey().KeyChar;

                if (tempUserChoice == 'q')
                {
                    continue;
                }
            }

            //=========================================================================More breaks
            else if (tempUserChoice == 'b')
            {
                Console.Clear();
                for (int i = 0; i < notes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {notes[i]}");
                }
                PrintRed("press q to exit to menu");
                tempUserChoice = Console.ReadKey().KeyChar;
                if (tempUserChoice == 'q')
                {
                    continue;
                }
            }
            //=========================================================================You'll see a lot of those, ima stop commenting on em
            else if (tempUserChoice == 'c')
            {
                Console.Clear();
                for (int i = 0; i < notes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {notes[i]}");
                }

                PrintGreen("Which note would you like to delete? (Enter the number)");

                try
                {
                    noteToDeleteInt = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    PrintRed("Not a number >:[");
                    continue;
                }

                if (noteToDeleteInt == 0 || noteToDeleteInt > notes.Count)
                {

                    PrintRed("Invalid note number. Please try again :[");
                    tempUserChoice = Console.ReadKey().KeyChar;
                    if (tempUserChoice == 'q')
                    {
                        continue;
                    }
                }
                else
                {
                    PrintGreen($"Note {notes[noteToDeleteInt - 1]} deleted successfully.");
                    notes.RemoveAt(noteToDeleteInt - 1);
                    PrintRed("press q to exit to menu");
                    tempUserChoice = Console.ReadKey().KeyChar;
                    if (tempUserChoice == 'q')
                    {
                        continue;
                    }
                }
            }
        }
    }
    #endregion

    if (UserChoice == '2')
    {
        while (true)
        {
            Console.Clear();
            PrintGreen("Hmmm, you want to try to guess my favorite pokemon huh?");
            Console.WriteLine("Press 1 to try to guess");
            Console.WriteLine("Press 2 to get a hint");
            PrintRed("Press q to go to menu");

            tempUserChoice = Console.ReadKey().KeyChar;
            if (tempUserChoice == 'q')
            {
                break;
            }

            else if (tempUserChoice == '1')
            {
                Console.Clear();
                PrintGreen("Try to guess");
                Console.WriteLine("Don't worry about Capital or lowercase letters but ALL CAPS won't count [won't brick the code-just your guess will never be correct]");
                favPokemonGuess = Console.ReadLine();
                if (favPokemonGuess == favpokemon || favPokemonGuess == favPokemonLowercase || favPokemonGuess == favPokemon3 || favPokemonGuess == favPokemon4)
                {
                    PrintGreen("YOU GUESSED CORRECTLY!!");
                    Console.WriteLine("It was indeed hisuian Zorua :]");
                    Console.WriteLine("I luv em, they're so cuteeeeeee");
                    PrintRed("press any key to exit to menu");
                    tempUserChoice = Console.ReadKey().KeyChar;
                }

                else
                {
                    PrintRed("Nope");
                    Console.WriteLine("You can go get a hint");
                    tempUserChoice = Console.ReadKey().KeyChar;
                }
            }

            else if (tempUserChoice == '2')
            {
                Console.Clear();


                if (hint < pokemonhints.Count)
                {
                    PrintGreen("New hint for you");
                    for (int i = 0; i <= hint; i++)
                    {
                        Console.WriteLine(pokemonhints[i]);
                    }
                    hint++;
                    PrintRed("Press anything to exit");
                    tempUserChoice = Console.ReadKey().KeyChar;
                }

                else
                {

                    PrintGreen("No more new hints for ya");
                    for (int i = 0; i < pokemonhints.Count; i++)
                    {
                        Console.WriteLine(pokemonhints[i]);
                    }

                    PrintRed("Press anything to exit");
                    tempUserChoice = Console.ReadKey().KeyChar;

                }
            }
        }
    }
}



//These make the code look more clean, and it looks better in the console
// Win Win
static void PrintGreen(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ResetColor();
}
static void PrintRed(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}
