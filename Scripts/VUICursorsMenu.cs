using UnityEditor;
using UnityEngine;

public class VUICursorsMenu
{
    [MenuItem("Assets/Create/VUI/Create Cursors")]
    public static void CreateAsset()
    {
        VUICursors asset = ScriptableObject.CreateInstance<VUICursors>();

        AssetDatabase.CreateAsset(asset, "Assets/Resources/VUI Cursors.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
}