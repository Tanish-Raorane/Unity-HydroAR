using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Scale_Rotate : MonoBehaviour
{
    ARSessionOrigin ARSO;
    GameObject Ind;
    GameObject button;
    public Slider scale_slider;
    public Slider rotate_slider;

    void Start()
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

    public void Scale()
    {
        float val = scale_slider.value;
        ARSO.transform.localScale = new Vector3(val, val, val);
    }

    public void Rotate()
    {
        float val = rotate_slider.value;
        ARSO.transform.rotation = Quaternion.Euler(0, val, 0);
    }






    //if(Current_Dist > Previous_Dist)
    //{
    //    OScale = ARSO.transform.localScale;
    //    NScale = OScale * 0.94f;
    //    ARSO.transform.localScale = NScale;
    //    Previous_Dist = Current_Dist;
    //} 

    //if(Current_Dist < Previous_Dist)
    //{
    //    OScale = ARSO.transform.localScale;
    //    NScale = OScale * 1.06f;
    //    ARSO.transform.localScale = NScale;
    //    Previous_Dist = Current_Dist;
    //}
}
