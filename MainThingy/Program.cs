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
Char UserChoice;
int noteToDeleteInt;
char tempUserChoice;



//Copy paste of this
//---------------------------------------------------------------------------------------------------------------------------
/*
UserChoice = Console.ReadKey().KeyChar;
                if (UserChoice == 'q')
                {
                    break;
                }
 */


//Da main loop - The most abused thing here
while (true)
{
    Console.Clear();
    PrintGreen("Welcome to this... Thing... That I have created.");
    Console.WriteLine("Why use AI when you have me to make random bull*** nobody asked for >:]");

    PrintGreen("Click the number key of which... program... you want to try");
    Console.WriteLine("1. Note Pad");

    UserChoice = Console.ReadKey().KeyChar;

    if (UserChoice == '1')
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
