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
using System.Reflection.PortableExecutable;

//Lists
List<string> notes = new List<string>();
List<string> characteristics = new List<string>();
List<string> rockpaperscissors = new List<string>();
List<string> umaGuesses = new List<string>();
List<string> umaHints = new List<String>();

//Random
Random characteristicsrnd = new Random();
Random rnd = new Random();

//Random bullsheep. Idk if I even use every one of em T-T
char UserChoice; 
int noteToDeleteInt;
char tempUserChoice;
string favPokemonGuess;
int hint = 0;
string characterName;
int randomnumber;
string guess;
int guessInt;
int rockpaperscissorsAI;
int rockpaperscissorsHuman = 0;
int rockpaperWin = 0;
int rockpaperLose = 0;
int umaHint = 0;
string guessUma;


//List's insides
characteristics = ["can't cook, like, at all.","strongly dislikes magnolia trees", "gets lost in malls", "oversleeps often", "loves spicy food", "is afraid of heights",
"really loves waterparks", "likes spiders", "is allergic to pollen", "constantly loses things, but only the unimportant ones", "has a vendetta against trains", "holds a pencil wrong",
"is very bad at skiing", "leaves their nightlamp on when they go to sleep", "could fall asleep at a party", "would love to throw tomato at someone one day", "always has an umbrella", "constantly broke",
"gets irritated if someone takes their place at the table", "really hates halloween", "still can't do math", "is amazing at biology trivia", "keeps loosing their left socks (or is something eating them 0-0)",
"always inserts USB on the wrong way 3 times", "keeps tripping over their own feet", "is really good at tennis", "has never been to a sleepover", "dislikes the color orange",
"doesn't have a favorite song"];

rockpaperscissors = ["rock", "paper", "scissors"];

umaHints = ["Long A", "Middle A", "Turf A", "Dirt A", "End closer A", "skill = Now We're Cruisin'! / Firelight", "Edo girl"];


#region Fav. Pokemon SPOILER!! TRY TO GUESS FIRT
int failedTries = 0;
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
    Console.WriteLine("3. Roll a random characteristic for a character");
    Console.WriteLine("4. Guess a random number");
    Console.WriteLine("5. Rock Paper Scissors");
    Console.WriteLine("6. Guess my favorite umamusume character");


    UserChoice = Console.ReadKey().KeyChar;
    //NotePad - that took too long T-T
    if (UserChoice == '1')
    
    {
        Console.Clear();
        PrintGreen("Welcome to this questionable note pad!");
        Console.WriteLine("This runs on a list, hopes and dreams. And if it works, it's a miracle");
        
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
    
    //Guess my favorite pokemon
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
                    Console.WriteLine($"You guessed wrong: {failedTries} times");
                    PrintRed("press any key to exit to menu");
                    tempUserChoice = Console.ReadKey().KeyChar;
                }

                else
                {
                    PrintRed("Nope");
                    Console.WriteLine("You can go get a hint");
                    failedTries++;
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
                    continue;

                }
            }
        }
    }

    //Random characteristic
    if (UserChoice == '3')
    {
        Console.Clear();
        PrintGreen("Insert the name of a character");
        Console.WriteLine("Name will not affect the outcome");
        characterName = Console.ReadLine();
        Console.WriteLine($"Character name you chose is: {characterName}");
        int characteristicInt = characteristicsrnd.Next(characteristics.Count - 1);
        Console.Clear();
        PrintGreen($"{characterName} {characteristics[characteristicInt]} ");
        Console.WriteLine("Want to add it into your notepad? [Y / N]");
        PrintRed("Pressing anything else will result in exiting");

        tempUserChoice = Console.ReadKey().KeyChar;
        if (tempUserChoice == 'Y' || tempUserChoice == 'y')
        {
            Console.Clear();
            notes.Add($"{characterName} {characteristics[characteristicInt]}");
            Console.WriteLine($"Note: {characterName} {characteristics[characteristicInt]} --was added");
            PrintRed("Press anything to continue");
            tempUserChoice = Console.ReadKey().KeyChar;
        }
        else
        {
            continue;
        
        }
    }

    if (UserChoice == '4')
    {
        Console.Clear();
        randomnumber = rnd.Next(1, 10001);
        PrintGreen("A random number has been chosen 1 - 10000");
        Console.WriteLine("Write your guess");
        PrintRed("Write exactly q to exit");

        while (true)
        {
            guess = Console.ReadLine();
            PrintGreen("Write your guess");
            bool result = int.TryParse(guess, out guessInt);

            if (result)
            {
                if (guessInt == randomnumber)
                {
                    PrintGreen($"YOU GUESSED IT!! IT INDEED WAS {randomnumber} ");
                    PrintRed("Press anything to exit");
                    tempUserChoice = Console.ReadKey().KeyChar;
                    break;
                }

                else if (guessInt > randomnumber)
                {
                    Console.WriteLine($"{guessInt} is > than the number you're searching for");
                }

                else if (guessInt < randomnumber)
                {
                    Console.WriteLine($"{guessInt} is < than the number you're searching for");
                }
                else
                {
                    PrintRed("Debug");
                }

            }


            if (!result)
            {

                if (guess == "q")
                {
                    break;
                }

                else
                {
                    PrintRed("Invalid imput - Not a number");
                    PrintGreen("Guess again");

                }
            }
        }
    }

    if (UserChoice == '5')
    {
        Console.Clear();
        PrintGreen("Welcome to rock paper scissors");
        PrintRed("Press q to exit");
        Console.WriteLine("Press anything else to play");
        tempUserChoice = Console.ReadKey().KeyChar;

        if (tempUserChoice == 'q')
        {
            continue;
        }

        else
        {
            while (true)
            {
                Console.Clear();
                rockpaperscissorsAI = rnd.Next(1, 4);

                PrintGreen("Choose 1, 2 or 3 or q to quit");
                Console.WriteLine("1 = rock, 2 = paper, 3 = scissors");
                Console.WriteLine($"You won {rockpaperWin} times");
                Console.WriteLine($"You lost {rockpaperLose} times");
                tempUserChoice = Console.ReadKey().KeyChar;

                if (tempUserChoice == 'q')
                {
                   break;
                }

                if (tempUserChoice == '1')
                {
                    rockpaperscissorsHuman = 1;
                }

                else if (tempUserChoice == '2')
                {
                    rockpaperscissorsHuman = 2;
                }

                else if (tempUserChoice == '3')
                {
                    rockpaperscissorsHuman = 3;
                }


                if (rockpaperscissorsHuman == rockpaperscissorsAI)
                {
                    Console.Clear();
                    PrintGreen($"It's a tie, you chose {rockpaperscissors[rockpaperscissorsHuman - 1]} and Pepa chose {rockpaperscissors[rockpaperscissorsAI - 1]}");
                    tempUserChoice = Console.ReadKey().KeyChar;
                    continue;
                }
                else if (rockpaperscissorsHuman == 1)
                {
                    if (rockpaperscissorsAI == 2)
                    {
                        Console.Clear();
                        PrintGreen($"You lost, you chose {rockpaperscissors[rockpaperscissorsHuman - 1]} and Pepa chose {rockpaperscissors[rockpaperscissorsAI - 1]}");
                        rockpaperLose++;
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        PrintGreen($"You won, you chose {rockpaperscissors[rockpaperscissorsHuman - 1]} and Pepa chose {rockpaperscissors[rockpaperscissorsAI - 1]}");
                        rockpaperWin++;
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                }

                else if (rockpaperscissorsHuman == 2)
                {
                    if (rockpaperscissorsAI == 3)
                    {
                        Console.Clear();
                        PrintGreen($"You lost, you chose {rockpaperscissors[rockpaperscissorsHuman - 1]} and Pepa chose {rockpaperscissors[rockpaperscissorsAI - 1]}");
                        rockpaperLose++;
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        PrintGreen($"You won, you chose {rockpaperscissors[rockpaperscissorsHuman - 1]} and Pepa chose {rockpaperscissors[rockpaperscissorsAI - 1]}");
                        rockpaperWin++;
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                }
                else if (rockpaperscissorsHuman == 3)
                {
                    if (rockpaperscissorsAI == 1)
                    {
                        Console.Clear();
                        PrintGreen($"You lost, you chose {rockpaperscissors[rockpaperscissorsHuman - 1]} and Pepa chose {rockpaperscissors[rockpaperscissorsAI - 1]}");
                        rockpaperLose++;
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        PrintGreen($"You won, you chose {rockpaperscissors[rockpaperscissorsHuman - 1]} and Pepa chose {rockpaperscissors[rockpaperscissorsAI - 1]}");
                        rockpaperWin++;
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                }

                else
                {
                    PrintRed("Choose either 1, 2 or 3");
                }
            }
        }
    }



    //I have no clueeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee what to dooooooooooooooooooooooooo
    //What am I gonna do the next 11 weeks T-T
    //Oh well, more guessing games ig, I really didn't know what more to do....
    //Guess my favorite Uma, I dare you.
    // if you didn't already get spoiled by the code -_-
    //Its kinda impossible to make this stuff without spoilers...
    if (UserChoice == '6')
    {
        while(true)
        {
            Console.Clear();
            PrintGreen("Trying to guess my favorite uma huh...");
            PrintGreen("Press 1 to guess");
            PrintGreen("Press 2 for hints");
            Console.WriteLine("Press 3 for list of your incorrect guesses");
            PrintRed("Press q for exit");

            tempUserChoice = Console.ReadKey().KeyChar;

            if (tempUserChoice == 'q')
            {
                break;
            }
            if (tempUserChoice == '1')
            {
                while (true)
                {
                    Console.Clear();
                    PrintGreen("Write your guess");
                    Console.WriteLine("if the character has 2 names - mejiro ryan - write both");
                    PrintRed("write q to exit");
                    guess = Console.ReadLine();
                    guessUma = guess.ToLower();

                    if (guessUma == "q")
                    {
                        break;
                    }
                    else if (guessUma == "inari one")
                    {
                        Console.Clear();
                        PrintGreen("Yep, you are correct :] My favorite uma is indeed Inari One - I LOVE HER GOLDEN DREAM OUTFIT AAAAA ");
                        PrintRed("Press anything to exit");
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                    else if (guessUma == "Kitasan Black")
                    {
                        Console.Clear();
                        Console.WriteLine("As much as I love Kitasan, she is not my fave");
                        PrintRed("Press anything to exit");
                        umaGuesses.Add(guessUma);
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                    else if (guessUma == "satono diamond")
                    {
                        Console.Clear();
                        Console.WriteLine("Not my fave but I like her. THO I WANT TO PULL A KITASAN, NOT A 4TH COPY OF HER??");
                        umaGuesses.Add(guessUma);
                        tempUserChoice= Console.ReadKey().KeyChar;
                        continue;
                    }
                    else if (guessUma == "rice shower")
                    {
                        Console.Clear();
                        Console.WriteLine("Not my fave, but she's a cutieeee");
                        umaGuesses.Add(guessUma);
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }
                    else if (guessUma == "mejiro mcqueen")
                    {
                        Console.Clear();
                        Console.WriteLine("Not my fave, but I like her attitude towards Rice in the story");
                        umaGuesses.Add(guessUma);
                        tempUserChoice = Console.ReadKey().KeyChar;
                        continue;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("nope, try again");
                        PrintRed("Press anything to exit");
                        tempUserChoice = Console.ReadKey().KeyChar;
                        umaGuesses.Add(guess);
                        continue;
                    }
                }
            }

            if (tempUserChoice == '2')
            {
                if (umaHint < umaHints.Count)
                {
                    Console.Clear();
                PrintGreen("A new hint for ya");
                for (int i = 0; i <= umaHint; i++) 
                {
                    Console.WriteLine(umaHints[i]);
                }
                umaHint++;
                PrintRed("Press anything to exit");
                tempUserChoice = Console.ReadKey().KeyChar;
                continue;
                }

                else
                {
                    Console.Clear();
                    PrintGreen("No new hints");
                    for (int i = 0; i < umaHints.Count; i++)
                    {
                        Console.WriteLine(umaHints[i]);
                    }
                    PrintRed("Press anything to exit");
                    tempUserChoice = Console.ReadKey().KeyChar;
                    continue;
                }
            }

            if (tempUserChoice == '3')
            {
                if (umaGuesses.Count > 0)
                {
                    Console.Clear();
                    for (int i = 0; i < umaGuesses.Count; i++)
                    {
                        PrintRed(umaGuesses[i]);
                    }

                    Console.WriteLine("-----------------");
                    PrintRed("Press anything to exit");
                    tempUserChoice = Console.ReadKey().KeyChar;
                    continue;
                }
                else
                {
                    Console.Clear();
                    PrintRed("You haven't guessed wrong yet");
                    Console.WriteLine("---------------");
                    PrintRed("Press anything to exit");
                    tempUserChoice = Console.ReadKey().KeyChar;
                    continue;
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
static void PrintBlue(string message)
    {
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.WriteLine(message);
    Console.ResetColor();
    }