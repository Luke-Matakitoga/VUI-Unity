using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class VUIDropdown : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color BaseColour = Color.white;

    private VUICursors cursors;
    private TMP_Dropdown baseDropdown;

    private void Awake()
    {
        cursors = VUI.Cursors;
        baseDropdown = GetComponent<TMP_Dropdown>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        VUICursor cursor = baseDropdown.interactable ? cursors.Pointer : cursors.Default;

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
