using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggablePoint : MonoBehaviour
{
    Vector2 mousePosition;

    private void OnMouseDrag()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = mousePosition;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
