using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    [SerializeField] private string[] dialogLines;
    private bool isPlayerInRange = false;

    private void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            DialogManager.Instance.ShowDialog(dialogLines);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
