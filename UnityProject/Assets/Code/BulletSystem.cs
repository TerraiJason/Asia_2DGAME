using UnityEngine;

public class BulletSystem : MonoBehaviour
{
    [SerializeField, Header("Bullut")]
    private GameObject prefabBullut;
    [SerializeField, Header("Spawn")]
    private Transform pointSpawn;
    [SerializeField, Header("FiringSound")]
    private AudioClip soundFire;

    protected void SpawnBullet()
    {
        //生成子彈，子彈，位置
        Instantiate(prefabBullut, pointSpawn.position, pointSpawn.rotation);

        SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));

    }
}
