using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OpenNewBuilder ()
    {
        Debug.Log("Opening new builder scene");
        SceneManager.LoadScene("BuilderDemo");
    }
}
