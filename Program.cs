/*Purpose: To calcualte the cost of sponsering a cute unicorn. 
 * Input: Sponser's Name, Unicorn's name, type of donation, pen wall widths, gate width, height, choice for gate material,
 * Choice to change gate paint; if yes, pick from 3 choices, choice to upgrade meals. 
 * Output: Donor name, Unicorn name, donation amount, wall cost, gate cost, gate paint cost, meal upgrade
 */
//variables
string sponser,
                unicorn;
char donation,
    gatematerial,
    paintchoice,
    answer;
double donateamount,
    months,
    monthlyamount,
    wallwidth,
    backwallwidth,
    gatesa,
    
    gatewidth,
    gateheight,
    wallcost,
    gatecost,
    paintedgate;

//banner
Console.WriteLine("***Welcome to the Unicorn Rescue Society Cost Estimator****");
Console.WriteLine("What is your name?");
sponser = Console.ReadLine();
Console.WriteLine("What would you name your unicorn?");
unicorn = Console.ReadLine();

Console.WriteLine($" Donor {sponser}");
Console.WriteLine($" Unicorn Name {unicorn}");

Console.WriteLine("All Sponsers must make a donation");
Console.WriteLine("What kind of donation are you going to make today?");
Console.WriteLine("\tU - Unlimited");
Console.WriteLine("\tM - Montly");
Console.WriteLine("\tO - Onetime");
donation = char.Parse(Console.ReadLine().ToUpper());

if (donation == 'U')
{
    Console.WriteLine("How much will you pay per month, forever?");
    donateamount = double.Parse(Console.ReadLine());
}
else if (donation == 'M')
{
    Console.WriteLine("How much will you pay per month?");
    monthlyamount = double.Parse(Console.ReadLine());
    Console.WriteLine("How many months?");
    months = double.Parse(Console.ReadLine());
    donateamount = months * monthlyamount;
}
else
{
    Console.WriteLine("How much will you donate this one time?");
    donateamount = double.Parse(Console.ReadLine());
}

Console.WriteLine($"{donateamount:c}");

//another banner
Console.WriteLine("****************** Pen Accomodations ****************************");

Console.WriteLine("What is the width of the two walls?");
wallwidth = double.Parse(Console.ReadLine());
Console.WriteLine("What is the width of the back wall");
backwallwidth = double.Parse(Console.ReadLine());

Console.WriteLine("What is the width of the gate?");
gatewidth = double.Parse(Console.ReadLine());
Console.WriteLine("What is the height of the two gate?");
gateheight = double.Parse(Console.ReadLine());

gatesa = wallwidth * backwallwidth;
wallcost = ((2 * (12 * wallwidth)) + (12 * backwallwidth)) * 4;

Console.WriteLine("****************** Gate Material ****************************");
Console.WriteLine("Available gate materials (cost is per square foot)");
Console.WriteLine("\tW - Wooden");
Console.WriteLine("\tS - Silver");
Console.WriteLine("\tG - Gold");
Console.WriteLine("What is your choice?");
gatematerial = char.Parse(Console.ReadLine());

Console.WriteLine($"Gate Material  {gatematerial}");

switch (gatematerial)
{
    case 'W':
        gatecost = gatesa * 3;
        break;

    case 'S':
        gatecost = gatesa * 8;
        break;

    case 'G':
        gatecost = gatesa * 12;
        break;

}

Console.WriteLine("Would you like to change the gate paint? (Y/N)");
answer = char.Parse(Console.ReadLine());

if (answer == 'Y')
{
    Console.WriteLine("Choose one of the following:");
    Console.WriteLine("\tM - Mood Paint, changes color based on {unicorn}'s mood, costs $200");
    Console.WriteLine("\tA - Magic Paint, changes color several times a day, costs $300");
    Console.WriteLine("\tR - Reflective, acts like a mirror, costs $150");
    paintchoice = char.Parse(Console.ReadLine()):
        
            if (paintchoice == 'M')
    {
        paintedgate = gatecost + 200;
    }
    else if (paintchoice == 'A')
    {
        paintedgate = gatecost + 300;
    }
    else
    {
        paintedgate = gatecost + 150
            }
}
else;
paintedgate == Origianl

Console.WriteLine($"Gate Cost {gatecost:c}");
Console.WriteLine($"Wall Cost {wallcost::c}");
Console.WriteLine($" Donor {sponser}");
Console.WriteLine($" Unicorn Name {unicorn}");
Console.WriteLine($" Donation Amount {donateamount:c}");
