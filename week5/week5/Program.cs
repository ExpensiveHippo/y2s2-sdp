using week5.Weapon.Prefix;
using week5.Weapon.Suffix;
using week5.Weapon;


// TODO: Weapon can only have 1 suffix
Weapon w1 = new Dagger();
Console.WriteLine($"{w1.GetName()} deals {w1.Damage()} damage.");
w1 = new Burning(w1);
Console.WriteLine($"{w1.GetName()} deals {w1.Damage()} damage.");
w1 = new Pain(w1);
Console.WriteLine($"{w1.GetName()} deals {w1.Damage()} damage.");
w1 = new Icy(w1);
Console.WriteLine($"{w1.GetName()} deals {w1.Damage()} damage.");

