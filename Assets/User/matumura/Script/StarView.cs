using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarView : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField, Tooltip("¯‚ÌÅ‘å’l")] private int MaxStarValue = 6;
=======
    [SerializeField, Tooltip("¯‚ÌÅ‘å’l")] private int MaxStarValue = 3;
>>>>>>> parent of c445c00 (Revert "2022å¹´å‰æœŸã€€ã‚²ãƒ¼ãƒ ãƒ—ãƒ­ã‚¸ã‚§ã‚¯ãƒˆå®Œæˆ")
    [SerializeField, Tooltip("“ïˆÕ“x‚Ì’l")] private int StarValue = 0;

    private Text text;

    void Start()
    {
        //‰Šú‰»
        text = this.GetComponent<Text>();
        //™‚Ìtext‚ðXV
        text.text = returnStar();
    }
    /// <summary>
    /// ŸŽè‚É™‚ð•t‚¯‚Ä‚­‚ê‚é‚æI
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
                startext += "š";
            }
            else
            {
                //Zæ“ª‚Étext‚ð‘}“ü‚·‚é
                startext = startext.Insert(0, "™");
            }
        }
<<<<<<< HEAD

=======
>>>>>>> parent of c445c00 (Revert "2022å¹´å‰æœŸã€€ã‚²ãƒ¼ãƒ ãƒ—ãƒ­ã‚¸ã‚§ã‚¯ãƒˆå®Œæˆ")
        return startext;
    }

}
