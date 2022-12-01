using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectData
{
    public float[,] position;
    public int amt = GameObject.Find("ObjectManager").GetComponent<ObjectMan>().amtObjects;

    public List<GameObject> savedPrefabs = GameObject.Find("ObjectManager").GetComponent<ObjectMan>().prefabs;

    public ObjectData(List<GameObject> objects)
    {
        position = new float[amt,3];
        for (int i = 0; i < amt; i++)
        {
            position[i,0] = objects[i].transform.position.x;
            position[i,1] = objects[i].transform.position.y;
            position[i,2] = objects[i].transform.position.z;
        }
    }
}
