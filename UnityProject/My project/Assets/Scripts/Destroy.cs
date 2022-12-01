
using UnityEngine;
namespace TerraiJason
{///<summary>
  ///刪除物件
  ///</summary>
public class Destroy : MonoBehaviour
{
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //gameobject 此腳本的遊戲物件
            //刪除(物件，刪除時間)
            Destroy(gameObject, destroyTime);
        }

        //不可見事件:當渲染元件(Render) 消失在 Scene 或 Game 時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        //可見事件:當渲染元件(Render) 出現在 Scene 或 Game 時執行一次
        private void OnBecameVisible()
        {
            
        }
    }
}

