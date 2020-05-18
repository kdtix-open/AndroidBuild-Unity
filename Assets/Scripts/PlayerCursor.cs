using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCursor : MonoBehaviour
{
    // You will need to drag and drop (assign) this texture in Unity UI
    [SerializeField] public Texture2D cursorImg;
    // Which x and y position would you like your clickable area (pointer tip)
    [SerializeField] public float hotSpotX = 0f;
    [SerializeField] public float hotSpotY = 0f;
    // Toggle Hardware pointer to be visible or not
    [SerializeField] public bool showHardwarePointer = false;


    // Start is called before the first frame update
    void Start()
    {
        // Set Hardware pointer to not be visible
        Cursor.visible = showHardwarePointer;
        
        //Set the cursor origin to your desired position (default is upper left corner)
        // example centered crosshair image (middle, middle)
        // hotSpotX = cursorImg.width / 2;
        // hotSpotY = cursorImg.height / 2; 
        Vector2 cursorOffset = new Vector2(hotSpotX, hotSpotY);

        //Sets the cursor to the Crosshair sprite with given offset 
        //and automatic switching to hardware default if necessary
        Cursor.SetCursor(cursorImg, cursorOffset, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
