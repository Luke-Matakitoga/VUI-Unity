using UnityEditor;
using UnityEngine;

public class VUIHierarchyMenu : MonoBehaviour
{
    [MenuItem("GameObject/UI/VUI/Button", false, 0)]
    public static void AddVUIButton(MenuCommand menuCommand)
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/VUIButton");

        GameObject instance = GameObject.Instantiate(prefab);
        instance.name = "VUI Button";

        Undo.RegisterCreatedObjectUndo(instance, "Create " + instance.name);

        GameObjectUtility.SetParentAndAlign(instance, menuCommand.context as GameObject);

        Selection.activeObject = instance;
    }
    
    [MenuItem("GameObject/UI/VUI/Text Box", false, 0)]
    public static void AddVUITextBox(MenuCommand menuCommand)
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/VUITextBox");

        GameObject instance = GameObject.Instantiate(prefab);
        instance.name = "VUI TextBox";

        Undo.RegisterCreatedObjectUndo(instance, "Create " + instance.name);

        GameObjectUtility.SetParentAndAlign(instance, menuCommand.context as GameObject);

        Selection.activeObject = instance;
    }
    
    [MenuItem("GameObject/UI/VUI/Dropdown", false, 0)]
    public static void AddVUIDropdown(MenuCommand menuCommand)
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/VUIDropdown");

        GameObject instance = GameObject.Instantiate(prefab);
        instance.name = "VUI Dropdown";

        Undo.RegisterCreatedObjectUndo(instance, "Create " + instance.name);

        GameObjectUtility.SetParentAndAlign(instance, menuCommand.context as GameObject);

        Selection.activeObject = instance;
    }
    
    [MenuItem("GameObject/UI/VUI/Panel", false, 0)]
    public static void AddVUIPanel(MenuCommand menuCommand)
    {
        GameObject prefab = Resources.Load<GameObject>("Prefabs/VUIPanel");

        GameObject instance = GameObject.Instantiate(prefab);
        instance.name = "VUI Panel";

        int panelId = EditorPrefs.GetInt("VUI_PanelIDCount", 0);
        instance.GetComponent<VUIPanel>().PanelId = $"panel_{panelId}";
        EditorPrefs.SetInt("VUI_PanelIDCount", panelId+1);

        Undo.RegisterCreatedObjectUndo(instance, "Create " + instance.name);

        GameObjectUtility.SetParentAndAlign(instance, menuCommand.context as GameObject);

        Selection.activeObject = instance;
    }
}
