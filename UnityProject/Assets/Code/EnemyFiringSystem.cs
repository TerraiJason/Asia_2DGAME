using UnityEngine;

public class EnemyFiringSystem : BulletSystem
{
    [SerializeField, Header("Spawn Delay"), Range(0, 3)]
    private float interval = 1.5f;

    private void Awake()
    {

    }
    private void OnBecameVisible()
    {
        //延迟重複執行
        InvokeRepeating("SpawnBullet", 0, interval);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
