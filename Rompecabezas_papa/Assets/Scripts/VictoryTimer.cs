using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VictoryTimer : MonoBehaviour
{
    public TextMeshProUGUI score;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Ganaste con " + TimeManager.timeLeft + " segundos de sobra!";
    }

    public void TitleScreen()
    {
        TimeManager.timeLeft = "60";
        SceneManager.LoadScene("TitleScreen");
    }
}
