using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Scale : MonoBehaviour
{
    ARSessionOrigin ARSO;

    Vector2 First_Touch, Second_Touch; 
    float Current_Dist, Previous_Dist;
    bool First_Pinch = true;

    Vector3 OScale, NScale;

    GameObject Ind;
    GameObject button;

    void Awake()
    {
        ARSO_Holder holder = FindObjectOfType<ARSO_Holder>();
        ARSO = holder.arSessionOrigin;
        Ind = GameObject.Find("PlaceIndicator");
        gameObject.transform.position = Ind.transform.position;
        ARSO.MakeContentAppearAt(gameObject.transform, gameObject.transform.position, gameObject.transform.rotation);
        button = GameObject.Find("Button");
        button.SetActive(false);
        Ind.SetActive(false);
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
                Previous_Dist = Current_Dist;
                First_Pinch = false;
            }

            if(Current_Dist > Previous_Dist)
            {
                OScale = ARSO.transform.localScale;
                NScale = OScale * 0.94f;
                ARSO.transform.localScale = NScale;
                Current_Dist = Previous_Dist;
            } 
            
            if(Current_Dist < Previous_Dist)
            {
                OScale = ARSO.transform.localScale;
                NScale = OScale * 1.06f;
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
