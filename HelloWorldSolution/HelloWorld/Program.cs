using HelloWorld;

Console.WriteLine("Take a break!");

Console.WriteLine("How many minutes? :");
string? minutes = Console.ReadLine();

if (minutes is not null)
{
    DateUtils utils = new DateUtils();

    int mins = int.Parse(minutes);
    DateTime timeAtEndOfBreak = utils.TakeABreak(mins);
    Console.WriteLine($"Ok, be back at {timeAtEndOfBreak:T}");

}
else
{
    Console.WriteLine("Enter some minutes, moron");
}