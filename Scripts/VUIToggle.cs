using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VUIToggle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color BaseColour = Color.white;

    private VUICursors cursors;
    private Toggle baseToggle;

    private void Awake()
    {
        cursors = VUI.Cursors;
        baseToggle = GetComponent<Toggle>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        VUICursor cursor = baseToggle.interactable ? cursors.Pointer : cursors.Default;

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
