using week8;

GameEntity hero1 = new PC("Warren", "Warrior");
GameEntity hero2 = new PC("Wendy", "Wizard");
GameEntity mob1 = new NPC("Oscar", "Orc");
GameEntity mob2 = new NPC("Gary", "Goblin");

GameEntity arenaTeams = new Team("Arena");

GameEntity team1 = new Team("Awesome");
team1.Add(hero1);
GameEntity team2 = new Team("Killers");
team2.Add(hero2);
team2.Add(mob1);
GameEntity team3 = new Team("Lonely");
team3.Add(mob2);
arenaTeams.Add(team1);
arenaTeams.Add(team2);
arenaTeams.Add(team3);
    
Arena arena = new Arena(arenaTeams);
Console.WriteLine("--- Current Arena Teams ---");
arena.Print();
Console.WriteLine("---------------------------\n");

arena.RemoveEntity(team2);
team3.Add(team2);
Console.WriteLine("--- New Arena Teams ---");
arena.Print();
Console.WriteLine("-----------------------");

