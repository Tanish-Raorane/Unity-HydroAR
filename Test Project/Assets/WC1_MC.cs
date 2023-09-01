using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WC1_MC : MonoBehaviour
{
    public GameObject Canva1;
    public GameObject Canva2;

    public void From_Wrong_Canvas_1()
    {
        Canva1.SetActive(true);
        Canva2.SetActive(false);
    }

    public void To_Main_Canvas()
    {
        Canva1.SetActive(false);
        Canva2.SetActive(true);
    }
}
