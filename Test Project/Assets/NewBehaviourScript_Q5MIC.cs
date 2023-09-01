using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript_Q5MIC : MonoBehaviour
{
    public GameObject Main_Canvas;
    public GameObject Impressive_Canvas;

    public void Show_Main_Canvas()
    {
        Main_Canvas.SetActive(true);
        Impressive_Canvas.SetActive(false);
    }

    public void Show_Impressive_Canvas()
    {
        Main_Canvas.SetActive(false);
        Impressive_Canvas.SetActive(true);
    }
}
