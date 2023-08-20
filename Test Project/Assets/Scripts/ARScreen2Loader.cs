using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARScreen2Loader : MonoBehaviour
{
    public GameObject ARScreen1;
    public GameObject ARScreen2;
    public GameObject Indicator;
    void Update()
    {
        if(!Indicator.activeInHierarchy)
        {
            return;
        }

        ARScreen1.SetActive(false);
        ARScreen2.SetActive(true);
    }
}
