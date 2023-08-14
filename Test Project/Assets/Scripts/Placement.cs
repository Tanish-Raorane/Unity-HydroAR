using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{

    GameObject Ind;
    GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        Ind = GameObject.Find("PlaceIndicator");
        gameObject.transform.position = Ind.transform.position;
        button = GameObject.Find("Button");
        button.SetActive(false);
    }

}