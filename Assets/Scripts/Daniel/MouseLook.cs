using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    float xRotation = 0f;
    public Vector2 turn;
    public float mouseSensitivity = 2500;
    public Vector3 deltaMove;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            turn.x += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            turn.y = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            xRotation -= turn.y;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0);
        }

      }
}
