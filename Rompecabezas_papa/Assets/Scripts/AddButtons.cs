using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtons : MonoBehaviour
{
    [SerializeField] 
    private Transform puzzleField;

    [SerializeField]
    private GameObject btn;

    public int index = 0;

    private void Awake()
    {
        for (int i = 0; i < index; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }
    }
}
