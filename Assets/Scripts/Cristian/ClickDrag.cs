using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]

public class ClickDrag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    bool selected = false;
    void Start()
    {

    }

    void OnMouseDown()
    {
        if (selected == false)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            Debug.Log("object selected");
            selected = true;
        }
        else
        {
            Debug.Log("object de-selected");
            selected = false;
        }
    }

    void Update()
    {
        if (selected == true)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            Debug.Log("object moving");
            transform.position = curPosition;
        }
    }
}
