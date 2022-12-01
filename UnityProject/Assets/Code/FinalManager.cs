using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class FinalManager : MonoBehaviour
{
    public static FinalManager instance;

    private CanvasGroup groupFinal;
    private TextMeshProUGUI textTitle;
    private Button btnReplay;

    private void Awake()
    {
        instance = this;

        groupFinal = GameObject.Find("界面").GetComponent<CanvasGroup>();
        textTitle = GameObject.Find("EndGame").GetComponent<TextMeshProUGUI>();
        btnReplay = GameObject.Find("Retry").GetComponent<Button>();
        btnReplay.onClick.AddListener(Replay);
    }
    
    public void GameOver(string title)
    {
        textTitle.text = title;
        StartCoroutine(FadeIn());

    }

    private IEnumerator FadeIn()
    {
        for (int i = 0; i < 10; i++)
        {
            groupFinal.alpha += 0.1f;
            yield return new WaitForSeconds(0.02f);
        }

        groupFinal.interactable = true;
        groupFinal.blocksRaycasts = true;
    }

    private void Replay()
    {
        SceneManager.LoadScene("Game");
    }

}
