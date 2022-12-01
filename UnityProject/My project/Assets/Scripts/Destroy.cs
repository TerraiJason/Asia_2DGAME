
using UnityEngine;
namespace TerraiJason
{///<summary>
  ///�R������
  ///</summary>
public class Destroy : MonoBehaviour
{
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameobject ���}�����C������
            //�R��(����A�R���ɶ�)
            Destroy(gameObject, destroyTime);
        }

        //���i���ƥ�:���V����(Render) �����b Scene �� Game �ɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        //�i���ƥ�:���V����(Render) �X�{�b Scene �� Game �ɰ���@��
        private void OnBecameVisible()
        {
            
        }
    }
}

