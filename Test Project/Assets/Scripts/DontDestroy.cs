using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class DontDestroy : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

} 
   