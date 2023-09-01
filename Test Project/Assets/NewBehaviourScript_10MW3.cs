using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript_10MW3 : MonoBehaviour
{
    public GameObject Main_Canvas;
    public GameObject Wrong_Canvas_3;

    public void Show_Main_Canvas()
    {
        Main_Canvas.SetActive(true);
        Wrong_Canvas_3.SetActive(false);
    }

    public void Show_Wrong_Canvas_3()
    {
        Main_Canvas.SetActive(false);
        Wrong_Canvas_3.SetActive(true);
    }
}
