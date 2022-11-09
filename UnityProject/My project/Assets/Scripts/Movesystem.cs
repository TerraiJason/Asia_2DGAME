
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class Movesystem : MonoBehaviour
    {
        [Range(-10, 0), SerializeField, Header("移動速度")]
        private float speed = -3.5f;

        private void Update()
        {
            //transform 此物件的transform 元件
            //translate(x,y,z) 位移
            //Time.deltaTime 每幀數花費時間
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
    

    
}
