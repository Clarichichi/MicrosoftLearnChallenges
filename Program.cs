﻿Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
if ((roll1 == roll2) && (roll2 ==roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
else{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;

}
}
Console.WriteLine($"Your total including Bonuses: {total}");


if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new Laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip!");
}
else
{
    Console.WriteLine("You win a Kitten!");
}

/*if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry,you loose.");
}*/