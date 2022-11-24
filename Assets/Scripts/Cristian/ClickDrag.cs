using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]

public class ClickDrag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    
    public bool selected = false;
    
    public int clicks = 0;
    public float timeBtwClick;
    public float startTimeBtwClick = 1.5f;
    public bool clicked = false;
    
    void Start()
    {

    }

    void OnMouseDown()
    { 
        clicked = true;
        clicks += 1;
        
        if (clicks >= 2)
        {
            Debug.Log("double click");
            if (selected == true)
            {
                Debug.Log("object de-selected");
                selected = false;
            }
        }
        
        if (selected == false && clicks < 2)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            Debug.Log("object selected");
            selected = true;
            clicks = 0;
        }
    }

    void Update()
    {
        if (clicked == true && timeBtwClick <= 0)
        {
            clicks = 0;
            clicked = false;
            timeBtwClick = startTimeBtwClick;
        }
        else if (timeBtwClick > 0)
        {
            timeBtwClick -= Time.deltaTime;
        }
        else if (clicked == false)
        {
            timeBtwClick = startTimeBtwClick;
        }
        if (selected == true)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            Debug.Log("object moving");
            transform.position = curPosition;
        }
    }
}
