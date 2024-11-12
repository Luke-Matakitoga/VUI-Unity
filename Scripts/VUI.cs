using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VUI
{
    public static VUICursors Cursors => Resources.Load<VUICursors>("VUI Cursors");
    public static void SetCursor(VUICursor cursor)
    {
        Cursor.SetCursor(cursor.Texture, cursor.PixelOffset, CursorMode.Auto);
    }
}
