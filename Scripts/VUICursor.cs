using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VUICursor
{
    public Texture2D Texture;
    public Vector2 Offset = Vector2.zero;
    public Vector2 PixelOffset => new Vector2(1+(Offset.x * Texture.width), 1+(Offset.y *  Texture.height));
}
