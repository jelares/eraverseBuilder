using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ResetIfFalls : MonoBehaviour
{
    public Vector3 spawnPoint;
    void Update()
    {
        if (transform.position.y < -10) {
            transform.gameObject.GetComponent<ThirdPersonController>().enabled = false;
            transform.position = spawnPoint;
            transform.gameObject.GetComponent<ThirdPersonController>().enabled = true;
        }      
    }
}
