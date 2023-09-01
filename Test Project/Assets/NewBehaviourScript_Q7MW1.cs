using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript_Q7MW1 : MonoBehaviour
{
    public GameObject Main_Canvas;
    public GameObject Wrong_Canvas_1;

    public void Show_Main_Canvas()
    {
        Main_Canvas.SetActive(true);
        Wrong_Canvas_1.SetActive(false);
    }

    public void Show_Wrong_Canvas_1()
    {
        Main_Canvas.SetActive(false);
        Wrong_Canvas_1.SetActive(true);
    }
}
