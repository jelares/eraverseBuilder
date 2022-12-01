using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMan : MonoBehaviour
{
    public int amtObjects = -1;
    public List<GameObject> prefabs = new List<GameObject>();


    public void SaveObjects()
    {
        SaveSystem.SaveObjects(prefabs);
    }

    public void LoadObjects()
    {
        ObjectData data = SaveSystem.LoadObjects();
        
        for (int i = 0; i < data.amt; i++)
        {
            Vector3 position;
            position.x = data.position[i,0];
            position.y = data.position[i,1];
            position.z = data.position[i,2];
            
            Instantiate(data.savedPrefabs[i], position, Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
