
using UnityEngine;
namespace TerraiJason
{
   /// <summary>
   /// 移動系統
   /// </summary>
   public class Movesystem : MonoBehaviour
   {
        [Range(-10,0), SerializeField, Header("移動速度")]
        private float speed = -3.5f; 
   }

}
