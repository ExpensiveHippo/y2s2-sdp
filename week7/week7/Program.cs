// Create player with 50 max HP, 10 max MP and 8 magic power
using week7.Commands;
using week7.Potions;
using week7.Spells;
using week7;

Player player = Player.GetInstance(50, 10, 8);

HealingPotion healing_potion = new HealingPotion(player, 10, 3);
ManaPotion mana_potion = new ManaPotion(player, 5, 3);
FireballSpell fireball_spell = new FireballSpell(player, 8);
HealingSpell healing_spell = new HealingSpell(player, 3);

Command drink_healing =
        new DrinkHealingPotionCommand(healing_potion);
Command drink_mana = new DrinkManaPotionCommand(mana_potion);
Command cast_fireball = new CastFireballCommand(fireball_spell);
Command cast_healing = new CastHealingCommand(healing_spell);

player.SetCommand(drink_healing, 0);
player.SetCommand(drink_mana, 1);
player.SetCommand(cast_fireball, 2);
player.SetCommand(cast_healing, 3);

player.Hp = 25;
player.Mp = 3;
Console.WriteLine($"Player has {player.Hp}/{player.MaxHp} HP and {player.Mp}/{player.MaxMp} MP.");

player.HotKeyPushed(0); // healing potion
player.HotKeyPushed(0); // healing potion
player.UndoKeyPushed(); // undo
player.HotKeyPushed(0); // healing potion
player.HotKeyPushed(0); // healing potion
player.HotKeyPushed(0); // healing potion

player.HotKeyPushed(1); // mana potion
player.HotKeyPushed(1); // mana potion

player.HotKeyPushed(2); // fireball
player.HotKeyPushed(2); // fireball
player.HotKeyPushed(1); // mana potion
player.HotKeyPushed(2); // fireball
player.HotKeyPushed(3); // healing spell
player.UndoKeyPushed(); // undo
