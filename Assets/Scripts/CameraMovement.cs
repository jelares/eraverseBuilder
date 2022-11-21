using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 targetPos;
    public float increment;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y + increment, transform.position.z);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y - increment, transform.position.z);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + increment);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - increment);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            targetPos = new Vector3(transform.position.x + increment, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            targetPos = new Vector3(transform.position.x - increment, transform.position.y, transform.position.z);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);  
    }
}
