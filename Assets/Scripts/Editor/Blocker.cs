using UnityEditor;

namespace Geekbrains.Editor
{
    public static class Blocker
    {
        [MenuItem("Geekbrains/Block")]
        private static void Block()
        {
            EditorWindow.GetWindow<BlockWindow>(true, "Шindows заблокирован");
        }
    }
}