using UnityEngine;

namespace TerraiJason
{
    #region ���O
    //������

    /*�h�����
     * �h�����
     */

    /*����H�Ʀr���}�Y
     * �i�H������A���ɶq���n
     * ��ӳ�r�R�W�覡:�b��l���Ĥ@�Ӧr�W���n�令�j�g
     * �j�p�g���^��r���O���P��
     */

    /*�Y��:Tab
     * �榡�Ƥ��(�۰ʱ�):Ctrl + K D
     */

    //�K�n:�T��/
    #endregion
}
/// <summary>
/// �Ĥ@�ӵ{��
/// </summary>
public class FirstScript : MonoBehaviour
{
    #region ���O2
    //����ƥ�:�C���}�l�ɰ���@��
    private void Awake()
    {
        //��X�T��:�C���}�l�ɰ���@��
        print("Oh Yeah Baby");
    }

    //�}�l�ƥ�:�bAwake�������@��
    private void Start()
    {
        print("<color=blue>�o�O�}�l�ƥ�</color>");
    }

    //��s�ƥ�:�bStart�������A���榸�Ƭ� 60 FPS
    private void Update()
    {
        print("<color=purple>�o�O��s�ƥ�</color>");
    }
    #endregion
}