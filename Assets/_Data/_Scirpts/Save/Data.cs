using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Data : MonoBehaviour
{
    public static Data instace;
    [SerializeField] protected string Name;
    [SerializeField] protected int id;
    [SerializeField] protected TextMeshProUGUI[] nameText;
    [SerializeField] protected GameObject[] characters;
    private void Awake()
    {
        if(instace == null)
            instace = this;
        else
            Destroy(gameObject);
        
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        PlayerData player = new();
        player.LoadData();

        Name = player.name;
        id = player.id;
        
        GetCharacter();
        GetName();
    }
    protected virtual void GetName()
    {
        nameText[id - 1].text = Name;
    }
    protected virtual void GetCharacter()
    {
        characters[id - 1].SetActive(true);
    }
}
