<<<<<<< HEAD
=======
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
>>>>>>> parent of c445c00 (Revert "2022年前期　ゲームプロジェクト完成")
using UnityEngine;

public class BeforeBack : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            onBack();
        }
    }

    public void onBack()
    {
        if (GeneralManager.Instance.isPlay && !StageManager.Instance.isPlayerMove)
        {
<<<<<<< HEAD
            GeneralManager.Instance.soundManager.PlaySE(SoundManager.SeName.se_04);
=======
            GeneralManager.Instance.soundManager.PlaySE(SoundManager.SeName.se_08);
>>>>>>> parent of c445c00 (Revert "2022年前期　ゲームプロジェクト完成")
            StageManager.Instance.mapManager.LoadTurnData();
        }

    }
}
