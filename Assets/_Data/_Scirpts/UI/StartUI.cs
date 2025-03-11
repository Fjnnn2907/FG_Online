using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StartUI : MonoBehaviour
{
    [SerializeField] protected int UID;

    [SerializeField] protected TextMeshProUGUI textUID;

    private void Start()
    {
        textUID.text = "UID: " + GetRamDomUID().ToString();
    }
    protected virtual int GetRamDomUID()
    {
        return Random.Range(1000, 9999);
    }
}
