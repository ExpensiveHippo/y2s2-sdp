using week3.activity1;
using week3.activity2;

// Activity 1
Console.WriteLine("Activity 1:\n\n");
Character character = new Barbarian();

Weapon sword = new Sword();
Weapon axe = new Axe();

character.weapon = sword;
character.fight();
character.weapon = axe;
character.fight();

Console.WriteLine("--------------------------------------------");

// Activity 2
Console.WriteLine("Activity 2:\n\n");
Property prop1 = new Property();
Buyer buyer = new Buyer("m");

prop1.Offer(buyer);
prop1.BuyerPullout();
prop1.SignContract(buyer);
prop1.VendorPullout();
prop1.Offer(buyer);

Console.WriteLine();
Property prop2 = new Property();
prop2.Offer(buyer);
prop2.PayPrice();
prop2.SignContract(buyer);
prop2.BuyerPullout();
prop2.PayPrice();
prop2.VendorPullout();
Console.WriteLine("--------------------------------------------");
