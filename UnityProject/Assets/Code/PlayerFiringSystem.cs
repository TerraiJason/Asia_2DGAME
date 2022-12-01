using UnityEngine;

public class PlayerFiringSystem : BulletSystem
{
    //偵測玩家輸入
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet();
        }
    }
}

