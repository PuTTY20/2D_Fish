using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Player))]
public class PlayerEditor : Editor
{
    private SerializedProperty levelProperty;

    void OnEnable()
    {
        levelProperty = serializedObject.FindProperty("level");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(levelProperty);

        if (serializedObject.ApplyModifiedProperties())
        {
            // 레벨이 변경되었을 때 자동으로 스프라이트 업데이트
            ((Player)target).LevelSprite();
        }
    }
}
