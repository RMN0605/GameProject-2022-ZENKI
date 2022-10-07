using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public bool Name = false;
    public GameObject Other;
<<<<<<< HEAD
=======
    public GameObject Menu1;
>>>>>>> parent of c445c00 (Revert "2022年前期　ゲームプロジェクト完成")

    public void MenuOnOff()
    {
        if (GeneralManager.Instance.isPlay)
        {
            if (Name == false)
            {
                Name = true;
<<<<<<< HEAD
                
                Other.GetComponent<MenuImage>().OpenMenuBota();
                GeneralManager.Instance.isPlay = false;

=======
                    Other.GetComponent<TurnTile>().enabled = false;
                    GeneralManager.Instance.soundManager.PlaySE(SoundManager.SeName.se_04);
                    GeneralManager.Instance.isPlay = false;
                    GeneralManager.Instance.soundManager.MuteBGM();
>>>>>>> parent of c445c00 (Revert "2022年前期　ゲームプロジェクト完成")
            }
            else if (Name == true)
            {
                Name = false;
                Other.GetComponent<TurnTile>().enabled = true;
<<<<<<< HEAD
                Other.GetComponent<MenuImage>().CloseMenuBota();

            }
=======
                GeneralManager.Instance.isPlay = true;
                GeneralManager.Instance.soundManager.ResumeBGM();
            }

            Menu1.SetActive(Name);
>>>>>>> parent of c445c00 (Revert "2022年前期　ゲームプロジェクト完成")
        }
    }
}
