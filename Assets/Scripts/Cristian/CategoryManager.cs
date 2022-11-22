using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CategoryManager : MonoBehaviour
{  
    public Button gameObject;
    public GameObject activeCat;
    public GameObject[] unactiveCats;

    
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.onClick.AddListener(ButtonPress);
    }

    void ButtonPress()
    {
        Debug.Log("category" + activeCat.name + "pressed");
        
        activeCat.SetActive(true);
        
        for (int i = 0; i < unactiveCats.Length; i++)
        {
            unactiveCats[i].SetActive(false);
        }

    }
}
