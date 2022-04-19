using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class VictoryScreen : MonoBehaviour
{
    public TextMeshProUGUI score;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score.text =  "Te demoraste " + GameController.scoreString + " intentos en ganar!";
    }

    public void TitleScreen()
    {
        GameController.scoreString = "0";
        SceneManager.LoadScene("TitleScreen");
    }
}
