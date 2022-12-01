using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menumanager : MonoBehaviour
{
    private Button btnPlay;

    private void Awake()
    {
        btnPlay = GameObject.Find("Retry").GetComponent<Button>();
        btnPlay.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}


