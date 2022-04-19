using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteCustom : MonoBehaviour
{

    public static int spriteIndex = 1;

    public void SpriteCandy()
    {
        spriteIndex = 1;
        SceneManager.LoadScene("TitleScreen");
    }

    public void SpriteFruit()
    {
        spriteIndex = 2;
        SceneManager.LoadScene("TitleScreen");
    }

    public void SpriteGem()
    {
        spriteIndex = 3;
        SceneManager.LoadScene("TitleScreen");
    }

    public void SpriteAnimal()
    {
        spriteIndex = 4;
        SceneManager.LoadScene("TitleScreen");
    }

}
