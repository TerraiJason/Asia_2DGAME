
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ���a�����޲z: ���`�γq��
    /// </summary>
public class PlayerFinal : MonoBehaviour
{
        //�Q�R���ɰ���@��
        private void OnDestroy()
        {
            //���`
            Final.instance.GameOver("�D�ԥ���!");
        }

        //�I��Ŀ� Is Trigger ����|����@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�q��
            Final.instance.GameOver("���߳q�L!");
        }
    }

}

