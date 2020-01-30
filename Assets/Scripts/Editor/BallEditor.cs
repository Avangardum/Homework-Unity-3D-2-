using UnityEngine;
using UnityEditor;

namespace Geekbrains.Editor
{
    [CustomEditor(typeof(Ball))]
    public class BallEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            Ball ballTarget = (Ball)target;

            bool moveLeft = GUILayout.Button("Влево");
            bool moveRight = GUILayout.Button("Вправо");
            bool moveUp = GUILayout.Button("Вверх");
            bool moveDown = GUILayout.Button("Вниз");
            bool moveForward = GUILayout.Button("Вперёд");
            bool moveBack = GUILayout.Button("Назад");

            Vector3 movement = Vector3.zero;
            if(moveLeft) movement = Vector3.left;
            if (moveRight) movement = Vector3.right;
            if (moveUp) movement = Vector3.up;
            if (moveDown) movement = Vector3.down;
            if (moveForward) movement = Vector3.forward;
            if (moveBack) movement = Vector3.back;

            if(movement != Vector3.zero)
                ballTarget.transform.Translate(movement);
        }
    }
}
