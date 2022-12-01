using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData
{
    public float[,] position;
    public int amt = GameObject.Find("ObjectManager").GetComponent<ObjectMan>().amtObjects;

    public List<GameObject> savedPrefabs = new List<GameObject>();

    public ObjectData()
    {
        savedPrefabs = GameObject.Find("ObjectManager").GetComponent<ObjectMan>().prefabs;
        position = new float[amt,3];
        for (int i = 0; i < amt; i++)
        {
            position[i,0] = savedPrefabs[i].transform.position.x;
            position[i,1] = savedPrefabs[i].transform.position.y;
            position[i,2] = savedPrefabs[i].transform.position.z;
        }
    }
}
