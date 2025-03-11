using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArenaExit : Arena
{
    public string SceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerCtrl.instance.arenaName = transtitonName;
            StartCoroutine(LoadSceneCoroutine());
        }
    }

    private IEnumerator LoadSceneCoroutine()
    {
        yield return new WaitForEndOfFrame();

        SceneManager.LoadScene(SceneName); 

        yield return new WaitForSeconds(0.1f); 

        ArenaEnter enter = transform?.GetComponentInChildren<ArenaEnter>();

        if (enter != null && enter.transtitonName == PlayerCtrl.instance.arenaName)
        {
            PlayerCtrl.instance.transform.position = enter.transform.position;
        }
    }
}
