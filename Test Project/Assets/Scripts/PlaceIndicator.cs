using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class PlaceIndicator : MonoBehaviour
{
    ARRaycastManager arRaycastManager;
    public GameObject Indicator;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();
   
    void Start()
    {
        arRaycastManager = FindObjectOfType<ARRaycastManager>();
        Indicator = transform.GetChild(0).gameObject;
        Indicator.SetActive(false);
    }

    
    void Update()
    {
        var ray = new Vector2(Screen.width / 2, Screen.height / 2);
        if(arRaycastManager.Raycast(ray, hits, TrackableType.Planes))
        {
            Pose hitPose = hits[0].pose;
            transform.position = hitPose.position;
            transform.rotation = hitPose.rotation;

            if(!Indicator.activeInHierarchy)
            {
                Indicator.SetActive(true);
            }
        }
    }
}
