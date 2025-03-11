using System.IO;
using UnityEngine;

public class SaveSystem
{
    private static string savePath = Application.persistentDataPath + "/";

    public static void SaveData(ISave data, string fileName)
    {
        string json = data.Save();
        File.WriteAllText(savePath + fileName + ".json", json);
        Debug.Log($"Saved {fileName}: {json}");
    }

    public static void LoadData(ISave data, string fileName)
    {
        string filePath = savePath + fileName + ".json";
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            data.Load(json);
            Debug.Log($"Loaded {fileName}: {json}");
        }
        else
        {
            Debug.LogWarning($"No save file found for {fileName}");
        }
    }
}
