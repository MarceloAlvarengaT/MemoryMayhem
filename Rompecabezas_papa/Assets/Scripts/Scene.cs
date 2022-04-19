using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("GameSelect");
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void EasyScene()
    {
        SceneManager.LoadScene("Main Game Easy");
    }

    public void MediumScene()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void HardScene()
    {
        SceneManager.LoadScene("Main Game Hard");
    }

    public void TimerScene()
    {
        SceneManager.LoadScene("Main Game Timer");
    }

    public void DifficultyScene()
    {
        SceneManager.LoadScene("Difficulty");
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void PreviousSceneDifficulty()
    {
        SceneManager.LoadScene(1);
    }

    public void PreviousSceneSelect()
    {
        SceneManager.LoadScene(0);
    }
    public void Custom()
    {
        SceneManager.LoadScene("Sprite Customization");
    }
}
