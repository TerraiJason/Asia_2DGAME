
using UnityEngine;

namespace TerraiJason
{
    /// <summary>
    /// ���ǲ� Field
    /// </summary>
public class LearnField : MonoBehaviour
{
        //��� Field : �x�s���
        //�y�k:
        //�׹��� ������� ���W�� ;
        //�p�H:priveate �Ȧb�����O������s���A�����
        private int lv;

        //���� ���w�Ÿ� : �N�����k�䪺���G���w������
        //���}:public �Ҧ����O������s���A���
        public int enemy = 5;

        public float speed = 3.5f;
        public float run = 9.3f;

        public string playername = "�W����";

        public bool ispass = false;
        public bool hasweapon = true;

        //���D
        [Header("��q")]
        public float hp = 100;

        //����
        [Tooltip("�]�w�����O�A���ѨC�@���������򥻶ˮ`")]
        public float attack = 100;

        //�b�]�w���ƭȽd�� range �A�����Y�����̤p�ȡA�k���̤j��
        [Range(1, 99)]
        public int level = 20;

        //�Y�n��private�X�{�b���������վ�A�o�b�e���[serializeField
        [SerializeField]
        private int countBoomb = 8;
}

}
