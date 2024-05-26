using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{

    Vector3 mousePositionOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMousePosition();
        //Note: to see what this does,  mousePositionOffset = gameObject.transform.position - new Vector3(1, 1, 0);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePosition() + mousePositionOffset;
    }
}
