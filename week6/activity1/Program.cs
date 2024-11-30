using week6.QuestGenerators;
using activity1.QuestGenerators;

QuestGenerator questGenerator = new RivendellQuestGenerator();
questGenerator.LaunchQuest("village");
questGenerator.LaunchQuest("city");

questGenerator = new MordorQuestGenerator();
questGenerator.LaunchQuest("village");
questGenerator.LaunchQuest("city");
