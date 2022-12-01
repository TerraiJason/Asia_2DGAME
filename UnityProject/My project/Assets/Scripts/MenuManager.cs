
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TerraiJason
{
    /// <summary>
    /// 選單管理器
    /// </summary>
public class MenuManager : MonoBehaviour
{
        /// <summary>
        /// 開始遊戲
        /// </summary>
        private Button btnReplay;

        private void Awake()
        {
            btnReplay = GameObject.Find("開始遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(StartGame);
        }

        /// <summary>
        /// 開始遊戲
        /// </summary>

        private void StartGame()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }

}
