using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Player))]
public class PlayerEditor : Editor
{
    private SerializedProperty levelProperty;
    private Player targetPlayer;

    private void OnEnable()
    {
        levelProperty = serializedObject.FindProperty("level");
        targetPlayer = (Player)target;
    }

    public override void OnInspectorGUI()
    {
        using var check = new EditorGUI.ChangeCheckScope();
        
        serializedObject.Update();
        EditorGUILayout.PropertyField(levelProperty);
        
        if (check.changed)
        {
            serializedObject.ApplyModifiedProperties();
            targetPlayer.LevelSprite();
        }
    }
}
