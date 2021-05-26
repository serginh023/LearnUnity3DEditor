using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(Level))]
    public class LevelEditor: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            Level myTarget = (Level) target;
            EditorGUILayout.LabelField("Level:", myTarget.GetLevel.ToString());
            if (GUILayout.Button("Press to scream"))
            {
                myTarget.ObjectScream();
            }
            EditorGUILayout.HelpBox("A help box.", MessageType.Warning);
        }
    }
}
