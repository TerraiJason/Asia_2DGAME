using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace TerraiJason
{
    /// <summary>
    /// �����޲z��
    /// </summary>
public class Final : MonoBehaviour
{
        public static Final instance;

        //�����e��
        private CanvasGroup groupFinal;

        //�������D
        private TextMeshProUGUI textTitle;

        //���s�C��
        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("�����e��").GetComponent<CanvasGroup>();

            textTitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();

            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();

            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// �C������
        /// </summary>
        /// <param name="title">�C�����D</param>

        public void GameOver(string title)
        {
            textTitle.text = title;

            StartCoroutine(FadIn());
        }

        /// <summary>
        /// �H�J
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
        /// ���s�C��
        /// </summary>
        
        private void Replay()
        {
            
            SceneManager.LoadScene("�}�l���");
        }


    }

}
