using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCamera : MonoBehaviour
{
    Camera ARCamera;
    public Canvas canvas;
    
    void Start()
    {
        ARSO_Holder holder = FindObjectOfType<ARSO_Holder>();
        ARCamera = holder.arCamera;
        canvas.worldCamera = ARCamera;
        canvas.planeDistance = 1;
    }

    
}
