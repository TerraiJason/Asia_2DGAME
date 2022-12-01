using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    //nameTarget是物件名字
    [SerializeField, Header("會造成傷害的目標")]
    private string nameTarget;
    [SerializeField, Header("爆炸的東西")]
    private GameObject prefabExplosion;

    [SerializeField]
    private AudioClip soundHit;
    [SerializeField]
    private AudioClip soundExplosion;

    //開始，一次性
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains(nameTarget))
        {
            Instantiate(prefabExplosion, transform.position, transform.rotation);

            SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
            SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));


            Destroy(gameObject);
        }
    }

    //離開，一次性
    private void OnCollisionExit2D(Collision2D collision)
    {

    }


    //持續
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
}
