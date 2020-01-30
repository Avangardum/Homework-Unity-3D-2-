using UnityEngine;
using UnityEditor;
using Debug = UnityEngine.Debug;

namespace Geekbrains.Editor
{
    public class BlockWindow : EditorWindow
    {
        private string _code;

        private void OnGUI()
        {
            GUILayout.TextArea("Шindows заблокирован. Для разблокировки отправьте 99999999999 рублей на номер [Данные удалены]. Из зарядного порта вашего телефона вылезет бумажка с кодом разблокировки");
            _code = GUILayout.TextField(_code);
            GUILayout.Button("Разблокировать Шindows");
        }
    }

}