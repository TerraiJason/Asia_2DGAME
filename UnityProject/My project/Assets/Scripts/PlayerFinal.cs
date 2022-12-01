
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// 玩家結束管理: 死亡或通關
    /// </summary>
public class PlayerFinal : MonoBehaviour
{
        //被刪除時執行一次
        private void OnDestroy()
        {
            //死亡
            Final.instance.GameOver("挑戰失敗!");
        }

        //碰到勾選 Is Trigger 物件會執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //通關
            Final.instance.GameOver("恭喜通過!");
        }
    }

}

