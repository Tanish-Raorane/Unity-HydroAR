using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Scale : MonoBehaviour
{
    ARSessionOrigin ARSO;
    Vector2 First_Touch;
    Vector2 Second_Touch;
    float Current_Dist;
    float Previous_Dist;
    bool First_Pinch = true;
    Vector3 OScale, NScale;
    GameObject Ind;
    GameObject button;

    void Start()
    {
        ARSO = GameObject.
        Ind = GameObject.Find("PlaceIndicator");
        gameObject.transform.position = Ind.transform.position;
        ARSO.MakeContentAppearAt(gameObject.transform, gameObject.transform.position);
        button = GameObject.Find("Button");
        button.SetActive(false);
    }


    void Update()
    {
        if(Input.touchCount > 1)
        {
            First_Touch = Input.GetTouch(0).position;
            Second_Touch = Input.GetTouch(1).position;
            Current_Dist = Second_Touch.magnitude - First_Touch.magnitude;
            if(First_Pinch)
            {
                Current_Dist = Previous_Dist;
                First_Pinch = false;
            }

            if(Current_Dist!=Previous_Dist)
            {
                OScale = ARSO.transform.localScale;
                NScale = OScale * (Previous_Dist / Current_Dist);
                ARSO.transform.localScale = NScale;
                Current_Dist = Previous_Dist;
            }
        }
        else
        {
            First_Pinch = true;
        }
    }
}
