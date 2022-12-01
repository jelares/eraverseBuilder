using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveObjects(List<GameObject> objects)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/objects.prefabs";
        FileStream stream = new FileStream(path, FileMode.Create);

        ObjectData data = new ObjectData(objects);

        formatter.Serialize(stream,data);
        stream.Close();
    }

    public static ObjectData LoadObjects()
    {
        string path = Application.persistentDataPath + "/objects.prefabs";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ObjectData data = formatter.Deserialize(stream) as ObjectData;
            stream.Close();

            return data;


        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
