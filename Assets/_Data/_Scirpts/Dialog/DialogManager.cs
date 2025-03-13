using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
public class DialogManager : FinMonoBehaviour
{
    public static DialogManager Instance;
    [Header("UI")]
    [SerializeField] protected TextMeshProUGUI nameText;
    [SerializeField] protected TextMeshProUGUI description;
    [SerializeField] protected Image avatar;
    [SerializeField] protected GameObject dialogBox;
    [Header("Setting")]
    [SerializeField] protected string[] dialogLines;
    [SerializeField] protected int currentLine;
    
    #region LoadCompoment
    protected override void LoadCompoment()
    {
        LoadGUI();
    }
    protected virtual void LoadGUI()
    {
        if(nameText != null || description != null || avatar != null) 
            return;

        dialogBox = transform.Find("Dialog").gameObject;
        nameText = transform.Find("Dialog/BG/NameText").GetComponent<TextMeshProUGUI>();
        description = transform.Find("Dialog/BG/Decription").GetComponent<TextMeshProUGUI>();
        avatar = transform.Find("Dialog/BG/Avatar").GetComponent<Image>();
        Debug.Log(transform.name + ": LoadGUI", gameObject);
    }
    #endregion
    private void Awake()
    {
        if (Instance == null) Instance = this;
        dialogBox.SetActive(false);
    }
    private void Update()
    {
        if (dialogBox.activeSelf && Input.GetButtonDown("Fire1"))
        {
            NextDialogLine();
        }
    }

    private void NextDialogLine()
    {
        currentLine++;
        if (currentLine >= dialogLines.Length)
        {
            dialogBox.SetActive(false);
        }
        else
        {
            description.text = dialogLines[currentLine];
        }
    }

    public void ShowDialog(string[] lines)
    {
        if (lines == null || lines.Length == 0) return;

        dialogLines = lines;
        currentLine = 0;
        dialogBox.SetActive(true);
        description.text = dialogLines[currentLine];
    }
}
