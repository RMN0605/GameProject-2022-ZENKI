using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearUI : MonoBehaviour
{
    private void Start()
    {
<<<<<<< HEAD
=======
        GeneralManager.Instance.soundManager.PlaySE(SoundManager.SeName.se_09);
>>>>>>> parent of c445c00 (Revert "2022年前期　ゲームプロジェクト完成")
        GeneralManager.Instance.soundManager.StopBGM();
        GeneralManager.Instance.soundManager.PlayBGM(SoundManager.BgmName.bgm_03);
    }
}
