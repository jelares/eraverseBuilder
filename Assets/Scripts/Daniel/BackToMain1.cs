using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain1 : MonoBehaviour
{
    public void OpenMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
}
