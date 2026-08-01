using System.IO;
using UnityEngine;

namespace RaisingAHuman.Quests
{
    public static class QuestLoader
    {
        public static QuestDefinition LoadDayOne()
        {
            return Load("main_day01_get_out_of_bed.json");
        }

        private static QuestDefinition Load(string fileName)
        {
            string path = Path.Combine(Application.streamingAssetsPath, "Quests", fileName);

            if (path.Contains("://"))
            {
                Debug.LogError($"StreamingAssets on this platform requires UnityWebRequest: {path}");
                return null;
            }

            if (!File.Exists(path))
            {
                Debug.LogError($"Quest file not found: {path}");
                return null;
            }

            return JsonUtility.FromJson<QuestDefinition>(File.ReadAllText(path));
        }
    }
}
