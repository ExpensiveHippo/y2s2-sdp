using activity2.QuestGenerators;

QuestGenerator questGenerator = new RivendellQuestGenerator();
questGenerator.LaunchQuest("village");
questGenerator.LaunchQuest("city");

questGenerator = new MordorQuestGenerator();
questGenerator.LaunchQuest("village");
questGenerator.LaunchQuest("city");
