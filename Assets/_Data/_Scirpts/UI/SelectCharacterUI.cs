using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class SelectCharacterUI : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] protected int id;
    [SerializeField] protected TMP_InputField inputField;
    [SerializeField] protected Button selectButton;
    [Header("Hero")]
    [SerializeField] protected Sprite[] characters;
    [SerializeField] protected TextMeshProUGUI titleName;
    [SerializeField] protected TextMeshProUGUI backStory;
    [SerializeField] protected Image characterImage;
    public void ClickCharacter(Hero hero)
    {
        characterImage.enabled = true;
        characterImage.sprite = hero.icon;
        titleName.text = hero.nameHero;
        backStory.text = hero.backStoryHero;
        id = hero.id;
    }
    void OnGUI()
    {
        Event e = Event.current;

        if (e.isKey || e.isMouse)
        {
            CheckInputField();
        }
    }
    private void CheckInputField()
    {
        if(inputField.text.Length > 5 && id != 0)
            selectButton.interactable = true;
        else
            selectButton.interactable = false;
    }
    public void ClickGetId()
    {
        PlayerData player = new PlayerData
        {
            id = id,
            name = inputField.text
        };
        player.SaveData();
        GetId();
        Debug.Log(id);
        SceneManager.LoadScene("Map1");
    }
    public int GetId()
    {
        return id;
    }
}
