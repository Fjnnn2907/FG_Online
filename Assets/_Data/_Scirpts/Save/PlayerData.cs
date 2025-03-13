[System.Serializable]
public class PlayerData : ISaveable
{
    public string name;
    public int id;

    public void SaveData()
    {
        SaveLoadSystem.Save("PlayerData", this);
    }

    public void LoadData()
    {
        PlayerData data = SaveLoadSystem.Load<PlayerData>("PlayerData");
        if (data != null)
        {
            name = data.name;
            id = data.id;
        }
    }
}
