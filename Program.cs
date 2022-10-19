

//Griffin Parker
//September 11, 2022
//Minichallenge #5 - Madlibs
//This program takes the user's inouts and adds them to one of three stories. An attempt at humor was made, and hopefully succeeded. 
//Peer reviewed by

int repeat = 1;
int words = 1;
int lib = 0;

//In order to allow the user to choose whether or not they want to reinput the words, I had to initalize the variables first, before their input. 
string exc = "";
string person = "";
string adjest ="";
string bodypart = "";
string animal = "";
string principal = "";
string noise = "" ;
string verbs = "";
string verb = "";
string adjective = "";

bool loop = true;

while (repeat == 1){

loop = true;

if (words == 1){
Console.Clear();
Console.WriteLine("Welcome to my Madlib! Please begin by giving me your best Exclamation!");
exc = Console.ReadLine();
Console.Clear();
Console.WriteLine("Well done! Now give me the name of a person, any person.");
person = Console.ReadLine();
Console.Clear();
Console.WriteLine("Now I need an adjective that ends with -est.");
adjest = Console.ReadLine();
Console.Clear();
Console.WriteLine("This time I need a species of animal.");
animal = Console.ReadLine();
Console.Clear();
Console.WriteLine("For this line, I will need the name of a bodypart.");
bodypart = Console.ReadLine();
Console.Clear();
Console.WriteLine("Give me a verb in the present tense, any verb will do!");
verb = Console.ReadLine();
Console.Clear();
Console.WriteLine("Now I need the name of a character from an animated movie.");
principal = Console.ReadLine();
Console.Clear();
Console.WriteLine("How about an adjective?");
adjective = Console.ReadLine();
Console.Clear();
Console.WriteLine("This time, I want you to give me a noise. Please type it in, don't make it!");
noise = Console.ReadLine();
Console.Clear();
Console.WriteLine("For my last request, how about a verb ending in -s. You've been a very good helper!");
verbs = Console.ReadLine();
Console.Clear();
words = 0;
}

repeat --;
lib = 0;
while (lib != 1 && lib != 2 && lib != 3 && lib != 4)
{
Console.Clear();
Console.WriteLine("Now which Mad do you want to Lib? 1, 2, or 3?");
Console.WriteLine("1. Sent to the Principal's Office");
Console.WriteLine("2. Dragon hunting with Braven the Craven");
Console.WriteLine("3. The best morning ever");
Console.WriteLine("4. Choose a new set of words");

string choice = Console.ReadLine();

if (choice == "1" || choice== "2" || choice == "3" || choice == "4")
{ 
lib = Convert.ToInt32(choice);
}
Console.Clear();

if (lib == 0){
    Console.WriteLine("Please input a '1', '2', or '3' ");
}
if (lib == 1){

Console.WriteLine(exc + "!! You've been sent to the principal's office!! You've never seen them yourself, but your best friend "+ person); 
Console.WriteLine("says that they're the " + adjest +  " principal in the whole world!! You didn't think that dropping a live " + animal);
Console.WriteLine("into Billy Hinger's pants was going to cause all this trouble... how would you have known that it was going to bite clean through");
Console.WriteLine("his " + bodypart +"? On your way through the halls, you stop at the bathroom, " + verb + " some cold water on your face and say a quick"); 
Console.WriteLine("prayer to " + principal +" to help you get through this trying time."); 
Console.WriteLine();
Console.WriteLine("You've arrived at the principals office and the office lady is staring at you with a " + adjective + " look on her face the whole time you're waiting.");
Console.WriteLine("Finally, the door swings open seemingly on its own, and a " + noise +" " + verbs +" out at you from the inky blackness beyond. You tremulously take");
Console.WriteLine("a few steps in to the black void of the office when the lights flicker on. You can't believe your eyes... " + principal + " is behind the desk! They kick their feet up,");
Console.WriteLine("chuckle to themselves, and look at you with a grin on their face 'So what's all this I hear about a " + animal + " and Billy Hinger's " + bodypart + "?'");
loop = true;
}

if (lib == 2){
Console.WriteLine($"The townspeople are all worried! People have been disapearing left and right! Just last night {person} never returned after taking a trip to the outhouse.");
Console.WriteLine($"Someone heard a loud {noise} after {person} went outside and they never came back. A meeting was called for the remaining villagers, and we all ");
Console.WriteLine($"gathered around in the local tavern to make a plan. As soon as everyone was gathered, the doors burst open and a man {verbs} through. He had");
Console.WriteLine($"a {adjective} face and the {bodypart} of a {animal}. 'I am Braven, legendary dragon hunter and the answer to your problems!' He cried out. 'To take care");
Console.WriteLine($"of this dragon, all I will need is the {adjest} person in the village!' My heart sank as all eyes immediately turned towards me. 'This one will do nicely!'");
Console.WriteLine($"Braven crowed, sweeping me outside. 'We ride posthaste for the beast's lair! I have a magic scroll that will summon the legendary warrior {principal}");
Console.WriteLine($"who will easily best the vile lizard! All you have to do is momentarily distract it and summon them!' It isn't long before we reached the charred");
Console.WriteLine($"landcape the dragon was residing in. Braven looks at me, nods, and heads towards the dragon's lair with a large sack. Sticking to the plan, I wait until");
Console.WriteLine($"I hear a thundering roar, pull out the scroll and begin reading as loud as I can '{exc}! {exc}! I am Braven, legendary treasure thief!");
Console.WriteLine($"I have the tastiest {bodypart} in all the kingdom and I'm going to steal all your treasure!' As I look around for {principal} to appear, I only see a dragon");
Console.WriteLine($"wheeling around to make a beeline towards me. Just before I am swallowed in a single gulp, I see Braven {verb} away quickly, overloaded with treasure.");
loop = true;
}

if (lib == 3){
Console.WriteLine($"If you're like me, you know that every {adjective} day starts with an even more {adjective} morning! Here are some tips on how to have the best");
Console.WriteLine($"morning possible. Set your alarm to continually {noise} at max volume, and don't turn it off until you {verb} around your room at least");
Console.WriteLine($"ten times; this really gets the blood flowing. As soon as that's done, jump into the shower ASAP, without waiting for it to heat up. Try not to repeatedly");
Console.WriteLine($"yell '{exc}' as the frigid water slowly gets warmer. It's ok to fail this one part, I know I still do from time to time! Be sure to really scrub");
Console.WriteLine($"your {bodypart} while you're in the shower, as most people don't know that 78% of human stink originates there!");
Console.WriteLine($"When dressing yourself, try to think about the most stylish person you know. I usually try to emulate {person}, as they always are lookin real good.");
Console.WriteLine($"Before you leave your house, make sure to give your stuffed {principal} at least five hugs, the minimum amount of hugs a person");
Console.WriteLine($"needs everyday, according to the WHO. After leaving your house, make sure to put out food for the family of {animal}s that");
Console.WriteLine($"live under your porch. They get bitey when they're hungry! A wise man once said, 'He who wakes in the morning, also {verbs} the morning.' I'm not sure");
Console.WriteLine($"who that guy outside of the 7/11 was, or even what he meant, but he had the {adjest} beard I've ever seen, so he must be pretty wise!");
loop = true;
}

if (lib == 4)
{
loop = false;
words = 1;
repeat = 1;
}
}

Console.WriteLine();

while (loop == true)
{
Console.WriteLine("Do you want to try another Madlib? \"Yes\" or \"No\"");
string cont = Console.ReadLine();
cont = cont.ToLower();
 if (cont == "yes")
 {
    loop = false;
    repeat ++;
Console.WriteLine("Do you want to choose a new set of words? \"Yes\" or \"No\"");
string set = Console.ReadLine();
set = set.ToLower();
if (set == "yes")
 {
    words = 1;
 }
 if (set == "no")
 {
    words = 0;
 }
 }
 if (cont == "no")
 {
    loop = false;
 }
}

    Console.WriteLine("Goodbye! I hope you enjoyed creating some stories with me!");
}
