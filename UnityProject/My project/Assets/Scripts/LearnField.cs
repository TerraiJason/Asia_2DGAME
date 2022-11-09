
using UnityEngine;

namespace TerraiJason
{
    /// <summary>
    /// 欄位學習 Field
    /// </summary>
public class LearnField : MonoBehaviour
{
        //欄位 Field : 儲存資料
        //語法:
        //修飾詞 資料類型 欄位名稱 ;
        //私人:priveate 僅在此類別內能夠存取，不顯示
        private int lv;

        //等於 指定符號 : 將等號右邊的結果指定給左邊
        //公開:public 所有類別都能夠存取，顯示
        public int enemy = 5;

        public float speed = 3.5f;
        public float run = 9.3f;

        public string playername = "超級雞";

        public bool ispass = false;
        public bool hasweapon = true;

        //標題
        [Header("血量")]
        public float hp = 100;

        //提示
        [Tooltip("設定攻擊力，提供每一次攻擊的基本傷害")]
        public float attack = 100;

        //在設定的數值範圍內 range 括弧裡頭左邊放最小值，右方放最大值
        [Range(1, 99)]
        public int level = 20;

        //若要讓private出現在引擎中做調整，得在前面加serializeField
        [SerializeField]
        private int countBoomb = 8;
}

}
