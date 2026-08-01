using System.IO;
using UnityEngine;

namespace RaisingAHuman.Lore
{
    public static class LoreLoader
    {
        public static WorldLore LoadWorld()
        {
            return Load<WorldLore>("world_lore.json");
        }

        public static HumanProfile LoadHuman()
        {
            return Load<HumanProfile>("human_h071.json");
        }

        private static T Load<T>(string fileName)
        {
            string path = Path.Combine(Application.streamingAssetsPath, "Lore", fileName);

            // File.ReadAllText works in the Unity Editor and desktop builds.
            // Android/WebGL require UnityWebRequest because StreamingAssets may be packed or URL-based.
            if (path.Contains("://"))
            {
                Debug.LogError($"StreamingAssets on this platform requires UnityWebRequest: {path}");
                return default;
            }

            if (!File.Exists(path))
            {
                Debug.LogError($"Lore file not found: {path}");
                return default;
            }

            return JsonUtility.FromJson<T>(File.ReadAllText(path));
        }
    }
}
