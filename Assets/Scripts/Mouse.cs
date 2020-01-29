using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Sprite cursorSprite;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    //void OnMouseEnter()
    //{
    //    Cursor.SetCursor(cursorSprite.texture, hotSpot, cursorMode);
    //}

    //void OnMouseExit()
    //{
    //    Cursor.SetCursor(null, Vector2.zero, cursorMode);
    //}
    //// Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorSprite.texture, hotSpot, cursorMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
