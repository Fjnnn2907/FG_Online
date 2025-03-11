using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SelectCharacterUI : MonoBehaviour
{
    [SerializeField] protected int id;
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
    public void ClickGetId()
    {
        GetId();
        Debug.Log(id);
    }
    public int GetId()
    {
        return id;
    }
}
