using UnityEngine;

namespace Fox
{
    /// <summary>
    /// 欄位:儲存資料
    /// </summary>
}

public class Field : MonoBehaviour
{
    // 修飾詞
    //私人》僅私人組別的修飾詞代碼可以存取
    //公開》所有組別的修飾詞代碼都可以存取
    private int level;

    public int enemy = 5;

    [Header("Health")]
    public int hp = 100;
    [Header("Time")]
    public float time =10.5f;
    [Range(1, 99)]
    public int lv = 10;

    public float speed = 3.5f;
    public float jump = 7.5f;

    public string namePlayer = "Flyer";

    public bool isPass = false;
    public bool hasWeapon = true;


}
