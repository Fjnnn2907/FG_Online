using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Hero")]
public class Hero : ScriptableObject
{
    public int id;
    public Sprite icon;
    public string nameHero;
    [TextArea]
    public string backStoryHero;
}
