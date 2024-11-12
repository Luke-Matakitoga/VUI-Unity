using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "VUI Cursors", menuName = "VUI/Cursors", order = 1)]
public class VUICursors : ScriptableObject
{
    public VUICursor Default;
    public VUICursor Pointer;
    public VUICursor Type;
}
