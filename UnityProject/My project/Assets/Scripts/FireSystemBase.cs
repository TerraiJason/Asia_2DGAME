using UnityEngine;
namespace TerraiJason
{
    /// <summary>
    /// 發射系統基底類別
    /// 生成子彈
    /// </summary>
    public class FireSystemBase : MonoBehaviour
{
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射音效")]
        private AudioClip soundFire;

        //自訂方法
        //生成子彈
        //protected 保護級別:允許子類別存取
        protected void SpawnBullet()
        {
            //實例化(物件 座標 角度)
            //生成 子彈預製物 角度與座標跟子彈生成點相同
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundSystem.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
}

}
