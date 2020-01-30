using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace Geekbrains.Editor
{
    public static class SceneClearer 
    {
        [MenuItem("Geekbrains/Очистить сцену")]
        public static void ClearScene()
        {
            foreach (var gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
            {
                    Object.DestroyImmediate(gameObject);
            }
            EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        }
    }
}
