using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class VUITextBox : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color BaseColour = Color.white;

    private VUICursors cursors;
    private TMP_InputField baseField;

    private void Awake()
    {
        cursors = VUI.Cursors;
        baseField = GetComponent<TMP_InputField>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        VUICursor cursor = baseField.interactable ? cursors.Type : cursors.Default;

        if (cursor != null)
        {
            VUI.SetCursor(cursor);
        }
        else
        {
            Debug.Log("Cursor null or non-accessible");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        VUICursor cursor = cursors.Default;
        
        if (cursor != null)
        {
            VUI.SetCursor(cursor);
        }
        else
        {
            Debug.Log("Cursor null or non-accessible");
        }
    }
}
