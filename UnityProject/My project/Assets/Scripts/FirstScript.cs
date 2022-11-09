using UnityEngine;

namespace TerraiJason
{
    #region 筆記
    //單行註解

    /*多行註解
     * 多行註解
     */

    /*不能以數字做開頭
     * 可以打中文，但盡量不要
     * 兩個單字命名方式:在單子的第一個字上面要改成大寫
     * 大小寫的英文字母是不同的
     */

    /*縮排:Tab
     * 格式化文件(自動排):Ctrl + K D
     */

    //摘要:三個/
    #endregion
}
/// <summary>
/// 第一個程式
/// </summary>
public class FirstScript : MonoBehaviour
{
    #region 筆記2
    //喚醒事件:遊戲開始時執行一次
    private void Awake()
    {
        //輸出訊息:遊戲開始時執行一次
        print("Oh Yeah Baby");
    }

    //開始事件:在Awake之後執行一次
    private void Start()
    {
        print("<color=blue>這是開始事件</color>");
    }

    //更新事件:在Start之後執行，執行次數約 60 FPS
    private void Update()
    {
        print("<color=purple>這是更新事件</color>");
    }
    #endregion
}