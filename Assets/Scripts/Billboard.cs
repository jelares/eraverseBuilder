using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Eraverse {
public class Billboard : MonoBehaviour
{
    public GameObject theCam;

    void LateUpdate() {
        StartCoroutine(Bill());
    }

    private IEnumerator Bill() {
        yield return new WaitForEndOfFrame();
        transform.rotation = theCam.transform.rotation;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
}
