using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VUIButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color BaseColour = Color.white;
    
    [Range(0f, 1f)]
    public float HighlightDarken = 0.9f;
    
    [Range(0f, 1f)]
    public float PressDarken = 0.5f;

    private VUICursors cursors;
    private Button baseButton;

    private void Awake()
    {
        cursors = VUI.Cursors;
        baseButton = GetComponent<Button>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        VUICursor cursor = baseButton.interactable ? cursors.Pointer : cursors.Default;

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
