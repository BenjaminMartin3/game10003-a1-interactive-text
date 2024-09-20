using System.ComponentModel.Design;
// Get players name, age, and favorite object, sets isInjured to false
Console.WriteLine("Before we begin, I would like to ask for a few things...");
Console.WriteLine("First your name, please...");
string playerName = Console.ReadLine();
Console.WriteLine("Now your age, if you'd be so kind...");
int playerAge = int.Parse(Console.ReadLine());
Console.WriteLine("Finally, what is your favorite object?...");
string favoriteObject = Console.ReadLine();
Console.WriteLine("Perfect, now we can begin");
bool isInjured = false;

// Player entering the ruins
Console.WriteLine($"{playerName} had heard rumors of a strange and valuable artifact in some ancient ruins nearby,");
Console.WriteLine($"{playerName} packed up some tools and other survival items and headed out.");
Console.WriteLine($"{playerName} made their way to these ruins only to find that there seems to be no trace of an entrance,");
Console.WriteLine($"All {playerName} seem to see is two torches, one lit, one extinguished.");
Console.WriteLine($"{playerName} can do one of two things,");
Console.WriteLine($"{playerName} can either light the extinguished torch, or extinguish the lit torch.");
Console.WriteLine("What do you do? (light/extinguish)");

// Players choice to light or extinguish a torch
string choiceOne = Console.ReadLine();
if (choiceOne == "light")
{
    // Player lights the other torch
    Console.WriteLine($"{playerName} lit the other torch,");
    Console.WriteLine("Suddenly a bright glowy door appears between the two torches.");
    Console.WriteLine($"{playerName} entered the door to see a brightly lit corridor.");
    Console.WriteLine("Due to the fact that the corridor is brightly lit,");
    Console.WriteLine($"{playerName} noticed that there are plenty of traps around and can easily navigate around them.");
}
else
{
    // Player extinguishes the other torch, gets injured
    Console.WriteLine($"{playerName} extinguished the other torch,");
    Console.WriteLine("Suddenly a dark gloomy door appears between the two torches.");
    Console.WriteLine($"{playerName} entered to what seems to be a pitch-black corridor.");
    Console.WriteLine("Due to the fact that the corridor is super dark,");
    Console.WriteLine($"{playerName} failed to notice all the traps around you and barely make it the end alive.");
    isInjured = true;

}

// Player continues through ruins
Console.WriteLine($"{playerName} reached the end of the corridor,");
Console.WriteLine($"{playerName} are met with a door, the door seems to have a riddle on it.");
Console.WriteLine("The riddle is: I am tall when I'm young, and short when I'm old,");
Console.WriteLine("What am I?");

string riddleAnswer = Console.ReadLine();
if (riddleAnswer == "candle")
{
    Console.WriteLine("The door opens,");
    Console.WriteLine("It seems you answered the riddle correctly and are free to proceed");
}
else
{
    Console.WriteLine("A hammer suddenly swings down");
    Console.WriteLine($"{playerName} almost dodge it but their leg is hit and badly wounded");
    Console.WriteLine("The hammer hits the door smashing it open");
    Console.WriteLine("It seems its your lucky day today");
    Console.WriteLine("Regardless, you can proceed to the next room");
    isInjured = true;
}

// Player arrives at next room and is asked for their age again
Console.WriteLine($"{playerName} arrive at the next room,");
Console.WriteLine("Suddenly, a booming voice asked for your age");
Console.WriteLine("What is your response?");
int ageResponse = int.Parse(Console.ReadLine());

if (ageResponse == playerAge)
{
    Console.WriteLine("This was a test of your honesty,");
    Console.WriteLine("The booming voice said.");
    Console.WriteLine($"{playerName} is free to proceed");
}
else
{
    Console.WriteLine("What reason do you have to lie,");
    Console.WriteLine("The boomin voice said.");
    Console.WriteLine("Suddenly a lighting bolt shoots out of nowhere");
    Console.WriteLine($"{playerName} managed to dodge it and it explodes the door,");
    Console.WriteLine("However, you are damaged by the explosion.");
    Console.WriteLine($"No matter, somehow {playerName} is still able to proceed.");
    isInjured = true;
}

// Player reaches artifact room
Console.WriteLine($"{playerName} arrived at the artifact room");
Console.WriteLine($"{playerName} saw on top of a pedestal, a golden {favoriteObject}");
Console.WriteLine($"{playerName} makes their way up to the artifact");
Console.WriteLine($"With out a secodn thought {playerName} takes the artifact off the pedestal.);
Console.WriteLine("All of a sudden, the ruins start collapsing.");

if (isInjured == false)
{
    Console.WriteLine($"{playerName} ran as fast as they could out of the ruins");
    Console.WriteLine($"It was a close call but {playerName} made it out succesfully");
    Console.WriteLine($"{playerName} could go home and enjoy their newly accquired golden {favoriteObject}");
    Console.WriteLine("The End");
}
else
{
    Console.WriteLine($"{playerName} ran as fast as they could out of the ruins");
    Console.WriteLine($"Due do their injuries, they couldn't make it very far");
    Console.WriteLine($"It seems {playerName}'s luck finally ran out.");
    Console.WriteLine("Game Over");
}