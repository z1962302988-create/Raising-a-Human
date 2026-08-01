using System;

namespace RaisingAHuman.Quests
{
    [Serializable] public class QuestDefinition
    {
        public string id;
        public int day;
        public string title;
        public string locationId;
        public string humanId;
        public string designIntent;
        public QuestStage[] stages;
        public StatValue[] initialStats;
        public QuestObjective[] objectives;
        public QuestObjective[] hiddenObjectives;
        public ObservationPoint[] observationPoints;
        public QuestChoice[] interventions;
        public ShopItem[] shopItems;
        public string[] successConditions;
        public Reward[] completionRewards;
        public HiddenReward[] hiddenRewards;
        public string[] unlocks;
        public QuestChoice[] endingChoices;
        public string nextQuestPreview;
    }

    [Serializable] public class StatValue { public string id; public int value; }
    [Serializable] public class QuestStage { public string id; public string title; public string completionEvent; }
    [Serializable] public class QuestObjective { public string id; public string text; public int target; }
    [Serializable] public class ObservationPoint { public string id; public string text; public string clueId; }
    [Serializable] public class StatEffect { public string statId; public int amount; }
    [Serializable] public class QuestChoice { public string id; public string text; public StatEffect[] effects; public string clueId; }
    [Serializable] public class ShopItem { public string id; public string name; public int price; public bool recommended; }
    [Serializable] public class Reward { public string id; public int amount; }
    [Serializable] public class HiddenReward { public string objectiveId; public string rewardId; public int amount; }
}
