using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveSystem : MonoBehaviour
{
    private ObjectData objectData;
    private string path;
    private string persistentPath;

    public Button saveButton;
    public Button loadButton;

    private void CreateObjectData()
    {
        objectData = new ObjectData();
    }

    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";

    }
    
    public void SaveData()
    {
        string savePath = persistentPath;
        Debug.Log("Saving data at" + savePath);
        string json = JsonUtility.ToJson(objectData);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
    }

    public ObjectData LoadData()
    {
        using StreamReader reader = new StreamReader(persistentPath);
        string json = reader.ReadToEnd();
        
        ObjectData data = JsonUtility.FromJson<ObjectData>(json);
        Debug.Log(data.ToString());
        return data;
    }
    void Start()
    {
        CreateObjectData();
        SetPaths();

        saveButton.onClick.AddListener(Save);
        loadButton.onClick.AddListener(Load);

    }
    void Save()
    {
        CreateObjectData();
        SetPaths();
        SaveData();
    }
    
    void Load()
    {
        Debug.Log("Loading");
        SceneManager.LoadScene("BuilderDemo");
        ObjectData data = LoadData();
        
        for (int i = 0; i < data.amt; i++)
        {
            Vector3 position;
            position.x = data.position[i,0];
            position.y = data.position[i,1];
            position.z = data.position[i,2];
            
            Instantiate(data.savedPrefabs[i], position, Quaternion.identity);
        }
    }
}
