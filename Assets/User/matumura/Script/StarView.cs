using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarView : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField, Tooltip("星の最大値")] private int MaxStarValue = 6;
=======
    [SerializeField, Tooltip("星の最大値")] private int MaxStarValue = 3;
>>>>>>> parent of c445c00 (Revert "2022蟷ｴ蜑肴悄縲?繧ｲ繝ｼ繝?繝励Ο繧ｸ繧ｧ繧ｯ繝亥ｮ梧??")
    [SerializeField, Tooltip("難易度の値")] private int StarValue = 0;

    private Text text;

    void Start()
    {
        //初期化
        text = this.GetComponent<Text>();
        //☆のtextを更新
        text.text = returnStar();
    }
    /// <summary>
    /// 勝手に☆を付けてくれるよ！
    /// </summary>
    /// <returns></returns>
    string returnStar()
    {
        int NowStar = 0;
        string startext = "";
        for (int i = 0; i < MaxStarValue; i++)
        {
            if (NowStar < StarValue)
            {
                NowStar++;
                startext += "★";
            }
            else
            {
                //〇先頭にtextを挿入する
                startext = startext.Insert(0, "☆");
            }
        }
<<<<<<< HEAD

=======
>>>>>>> parent of c445c00 (Revert "2022蟷ｴ蜑肴悄縲?繧ｲ繝ｼ繝?繝励Ο繧ｸ繧ｧ繧ｯ繝亥ｮ梧??")
        return startext;
    }

}
