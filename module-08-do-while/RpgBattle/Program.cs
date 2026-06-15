// Module 8 - do-while and while
// Concepts: do-while (executes at least once), while (may not execute), continue vs break

Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

// do-while - battle continues while both have health
while ((heroHealth > 0) && (monsterHealth > 0))
{
    int heroAttack = random.Next(1, 11);
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

    if (monsterHealth > 0)
    {
        int monsterAttack = random.Next(1, 11);
        heroHealth -= monsterAttack;
        Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
    }
}

if (heroHealth <= 0)
    Console.WriteLine("Monster wins!");
else
    Console.WriteLine("Hero wins!");