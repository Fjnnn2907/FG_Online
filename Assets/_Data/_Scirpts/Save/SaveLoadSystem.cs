using System.IO;
using UnityEngine;

public class SaveLoadSystem
{
    private static string GetSavePath(string fileName)
    {
        return Path.Combine(Application.persistentDataPath, fileName + ".json");
    }

    public static void Save<T>(string fileName, T data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(GetSavePath(fileName), json);
        Debug.Log(GetSavePath(fileName));
        Debug.Log($"Saved: {fileName}");
    }

    public static T Load<T>(string fileName)
    {
        string path = GetSavePath(fileName);
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(json);
        }
        Debug.LogWarning($"Save file {fileName} not found!");
        return default;
    }
}
