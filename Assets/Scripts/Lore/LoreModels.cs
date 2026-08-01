using System;

namespace RaisingAHuman.Lore
{
    [Serializable] public class WorldLore
    {
        public string gameTitle;
        public string era;
        public string premise;
        public CareRelationship careRelationship;
        public PlayerLore player;
        public EmotionEcology emotionEcology;
        public WellbeingLore wellbeing;
        public CityLore city;
        public CommunityLore community;
        public string mainConflict;
        public string[] themes;
        public string[] tone;
    }

    [Serializable] public class CareRelationship { public string officialName; public string commonName; public string legalPrinciple; }
    [Serializable] public class PlayerLore { public string role; public string[] startingResources; public string goal; }
    [Serializable] public class EmotionEcology { public string phenomenon; public string[] positiveEffects; public string negativeSubstance; public string[] negativeEffects; }
    [Serializable] public class WellbeingLore { public string displayName; public string worldTerm; public string[] dimensions; public string warning; }
    [Serializable] public class CityLore { public string name; public DistrictLore[] districts; }
    [Serializable] public class DistrictLore { public string id; public string name; public string purpose; }
    [Serializable] public class CommunityLore { public string network; public string forum; public string[] activities; public string[] sampleMisinformation; }

    [Serializable] public class HumanProfile
    {
        public HumanIdentity identity;
        public string[] initialBehaviors;
        public HumanHistory history;
        public string coreConflict;
        public MeterTrigger[] meterTriggers;
        public StoryClue[] clues;
        public FurniturePreferences furniturePreferences;
        public GrowthStage[] growthStages;
        public string finalTruth;
        public string playerLesson;
    }

    [Serializable] public class HumanIdentity { public string id; public string type; public string initialStatus; public string conditionName; }
    [Serializable] public class HumanHistory { public string formerEmployer; public string formerRole; public string responsibility; public string wound; }
    [Serializable] public class MeterTrigger { public int threshold; public string reaction; }
    [Serializable] public class StoryClue { public string id; public string name; public string meaning; }
    [Serializable] public class FurniturePreferences { public string[] stressTags; public string[] comfortTags; public string designRule; }
    [Serializable] public class GrowthStage { public int id; public string name; public string goal; }
}
