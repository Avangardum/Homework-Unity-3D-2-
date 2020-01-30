using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class UniqueNamer
{
    [MenuItem("Geekbrains/Дать объектам уникальные имена")]
    static void GiveUniqueNames()
    {
        Dictionary<string, int> namesCount = new Dictionary<string, int>();
        var allGameObjects = Object.FindObjectsOfType<GameObject>();
        foreach (var gameObject in allGameObjects)
        {
            if (namesCount.ContainsKey(gameObject.name))
            {
                namesCount[gameObject.name]++;
            }
            else
            {
                namesCount.Add(gameObject.name, 1);
            }
        }

        foreach (var pair in namesCount)
        {
            if (pair.Value > 1)
            {
                var gameObjects = allGameObjects.Where(x => x.name == pair.Key);
                int number = 1;
                foreach (var gameObject in gameObjects)
                {
                    gameObject.name += $"({number})";
                    number++;
                }
            }
        }

        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
    }
}
