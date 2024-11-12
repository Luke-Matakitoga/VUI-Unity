using UnityEditor;
using UnityEngine;

public class VUIHierarchyMenu : MonoBehaviour
{
    [MenuItem("GameObject/UI/VUI/Button", false, 0)]
    public static void AddVUIButton(MenuCommand menuCommand)
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/VUIButton");

        GameObject instance = GameObject.Instantiate(prefab);
        instance.name = instance.name.Replace("(Clone)", "");

        Undo.RegisterCreatedObjectUndo(instance, "Create " + instance.name);

        GameObjectUtility.SetParentAndAlign(instance, menuCommand.context as GameObject);

        Selection.activeObject = instance;
    }
    
    [MenuItem("GameObject/UI/VUI/Text Box", false, 0)]
    public static void AddVUITextBox(MenuCommand menuCommand)
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/VUITextBox");

        GameObject instance = GameObject.Instantiate(prefab);
        instance.name = instance.name.Replace("(Clone)", "");

        Undo.RegisterCreatedObjectUndo(instance, "Create " + instance.name);

        GameObjectUtility.SetParentAndAlign(instance, menuCommand.context as GameObject);

        Selection.activeObject = instance;
    }
}
