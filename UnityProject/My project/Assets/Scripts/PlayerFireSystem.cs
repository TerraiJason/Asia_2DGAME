
using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// ª±®aµo®g
    /// </summary>
public class PlayerFireSystem : FireSystemBase
{
        //°»´úª±®aªº¿é¤J¦æ¬°:Áä½L¡B·Æ¹«¡B·n±ì¡BÄ²±±
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }

        }
 
}

}

