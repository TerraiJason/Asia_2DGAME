using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace TerraiJason
{
    /// <summary>
    /// 結束管理器
    /// </summary>
public class Final : MonoBehaviour
{
        public static Final instance;

        //結束畫布
        private CanvasGroup groupFinal;

        //結束標題
        private TextMeshProUGUI textTitle;

        //重新遊戲
        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("結束畫布").GetComponent<CanvasGroup>();

            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();

            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();

            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// 遊戲結束
        /// </summary>
        /// <param name="title">遊戲標題</param>

        public void GameOver(string title)
        {
            textTitle.text = title;

            StartCoroutine(FadIn());
        }

        /// <summary>
        /// 淡入
        /// </summary>

        private IEnumerator FadIn()
        {
            for (int i = 0; i < 10; i++)
            {
              groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }

        /// <summary>
        /// 重新遊戲
        /// </summary>
        
        private void Replay()
        {
            
            SceneManager.LoadScene("開始選單");
        }


    }

}
