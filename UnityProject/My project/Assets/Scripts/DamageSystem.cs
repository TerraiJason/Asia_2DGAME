
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// 傷害系統
    /// </summary>
public class DamageSystem : MonoBehaviour
{
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [Header("受傷與爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        //碰撞的開始事件 一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("碰撞 :" + collision.gameObject);

            //如果 碰到物件的名稱 包含 敵機 就爆炸
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundSystem.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundSystem.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                //Destroy 刪除
                //gameObject 此物件
                Destroy(gameObject);
            }
        }

        //碰撞離開事件 一次
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        //碰撞持續事件
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }

}

