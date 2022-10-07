using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tutorialimage : MonoBehaviour
{
    private int SpriteNum = 0;
    public List<Sprite> sprites = new List<Sprite>();
    private SpriteRenderer spriteRenderer;
    // Update is called once per frame

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (SpriteNum != 0)
            {
                SpriteNum--;
                spriteRenderer.sprite = sprites[SpriteNum];
            }
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
<<<<<<< HEAD
            clickPage();
        }
    }

    public void clickPage()
    {
        if (SpriteNum != sprites.Count - 1)
        {
            SpriteNum++;
            spriteRenderer.sprite = sprites[SpriteNum];
=======
            if (SpriteNum != sprites.Count - 1)
            {
                SpriteNum++;
                spriteRenderer.sprite = sprites[SpriteNum];
            }
>>>>>>> parent of c445c00 (Revert "2022年前期　ゲームプロジェクト完成")
        }
    }
}
