using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{

    public static MainManager instance;
    public string currentPlayer;
    public string userName;
    public Text displayName;
    public Color userColor;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadName();
    }

    [System.Serializable]
    class SaveData
    {
        public string name;
        public Color defaultColor;
    }

    public void SaveName()
    {
        SaveData data = new SaveData();
        data.name = userName;
        data.defaultColor = userColor;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            userName = data.name;
            userColor = data.defaultColor;

        }
    }



}
