using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public int Level = 0;
    private void Awake()
    {
        Load();
    }
    private void Start()
    {
        GameManager.Instance.SaveManager = this;
        GameManager.Instance.CurrentLevel = Level;
    }
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData_Storage data = (PlayerData_Storage)bf.Deserialize(file);

            Level = data.Level;
            file.Close();
        }
    }
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        PlayerData_Storage data = new PlayerData_Storage();

        data.Level = Level;

        bf.Serialize(file, data);
        file.Close();
    }
}
[Serializable]
class PlayerData_Storage
{
    public int Level;
}
