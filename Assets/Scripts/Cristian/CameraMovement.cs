using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 targetPos;
    public float increment;
    public float rotationSpeed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Upwards movement
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y + increment, transform.position.z);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y + increment, transform.position.z);

        }
        //Downwards movement
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y - increment, transform.position.z);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y - increment, transform.position.z);

        }
        //Rotate left
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0) * Time.deltaTime);
        }
        //Rotate right
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
        }
        //Move forward
        else if (Input.GetKey(KeyCode.W))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + increment);
        }
        //Move backward
        else if (Input.GetKey(KeyCode.S))
        {
            targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - increment);
        }
        //Move right
        else if (Input.GetKey(KeyCode.D))
        {
            targetPos = new Vector3(transform.position.x + increment, transform.position.y, transform.position.z);
        }
        //Move left
        else if (Input.GetKey(KeyCode.A))
        {
            targetPos = new Vector3(transform.position.x - increment, transform.position.y, transform.position.z);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);  
    }
}
