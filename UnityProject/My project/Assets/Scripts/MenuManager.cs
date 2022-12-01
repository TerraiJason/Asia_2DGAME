
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TerraiJason
{
    /// <summary>
    /// ���޲z��
    /// </summary>
public class MenuManager : MonoBehaviour
{
        /// <summary>
        /// �}�l�C��
        /// </summary>
        private Button btnReplay;

        private void Awake()
        {
            btnReplay = GameObject.Find("�}�l�C��").GetComponent<Button>();
            btnReplay.onClick.AddListener(StartGame);
        }

        /// <summary>
        /// �}�l�C��
        /// </summary>

        private void StartGame()
        {
            SceneManager.LoadScene("�C������");
        }
    }

}
