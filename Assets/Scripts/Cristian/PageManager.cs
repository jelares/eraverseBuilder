using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button leftArrow;
    public Button rightArrow;
    public GameObject MainCamera;

    public float distanceFromCamera;
    private Vector3 prefabPosition;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(But1);
        button2.onClick.AddListener(But2);
        button3.onClick.AddListener(But3);
        button4.onClick.AddListener(But4);
        button5.onClick.AddListener(But5);
        button6.onClick.AddListener(But6);
        leftArrow.onClick.AddListener(PrevPage);
        rightArrow.onClick.AddListener(NextPage);

    }
    
    public GameObject prefabButton1;
    public GameObject prefabButton2;
    public GameObject prefabButton3;
    public GameObject prefabButton4;
    public GameObject prefabButton5;
    public GameObject prefabButton6;
    public GameObject prevPage;
    public GameObject nextPage;

    void Update()
    {
        prefabPosition = new Vector3 (MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z + distanceFromCamera);
    }
    void But1()
    {
        Debug.Log("Button 1 pressed");
        Instantiate(prefabButton1, prefabPosition, Quaternion.identity);
    }
    void But2()
    {
        Debug.Log("Button 2 pressed");
        Instantiate(prefabButton2, prefabPosition, Quaternion.identity);
    }
    void But3()
    {
        Debug.Log("Button 3 pressed");
        Instantiate(prefabButton3, prefabPosition, Quaternion.identity);
    }
    void But4()
    {
        Debug.Log("Button 4 pressed");
        Instantiate(prefabButton4, prefabPosition, Quaternion.identity);
    }
    void But5()
    {
        Debug.Log("Button 5 pressed");
        Instantiate(prefabButton5, prefabPosition, Quaternion.identity);
    }
    void But6()
    {
        Debug.Log("Button 6 pressed");
        Instantiate(prefabButton6, prefabPosition, Quaternion.identity);
    }
    void PrevPage()
    {
        Debug.Log("prev page");
        gameObject.SetActive(false);
        prevPage.SetActive(true);
        
    }
    void NextPage()
    {
        Debug.Log("next page");
        gameObject.SetActive(false);
        nextPage.SetActive(true);
    }
    // Update is called once per frame
    
}
