using System;
using System.IO;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Color TeamColor;

    public void SaveColor()
    {
        var data = new SaveData { TeamColor = TeamColor };
        var json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/teamcolor.json", json);
    }

    public void LoadColor()
    {
        var path = Application.persistentDataPath + "/teamcolor.json";
        if(File.Exists(path))
        {
            var json = File.ReadAllText(path);
            var data = JsonUtility.FromJson<SaveData>(json);
            TeamColor = data.TeamColor;
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadColor();
    }

    [Serializable]
    class SaveData
    {
        public Color TeamColor;
    }
}
