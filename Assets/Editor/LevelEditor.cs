using UnityEditor;

[CustomEditor(typeof(Level))]
public class LevelEditor: Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        Level myTarget = (Level) target;
        EditorGUILayout.LabelField("Level:", myTarget.GetLevel.ToString());
        EditorGUILayout.HelpBox("A help box.", MessageType.Warning);
    }
}
