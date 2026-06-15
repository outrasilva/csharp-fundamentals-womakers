// Module 4 - Decision Logic (if, else if, else)
// Concepts: Boolean expressions, if/else/else if, logical operators &&, ||, nested if

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Nested if - doubles and triples bonus (mutually exclusive)
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

// if, else if, else - prize selection
if (total >= 16)
    Console.WriteLine("You win a new car!");
else if (total >= 10)
    Console.WriteLine("You win a new laptop!");
else if (total == 7)
    Console.WriteLine("You win a trip for two!");
else
    Console.WriteLine("You win a kitten!");