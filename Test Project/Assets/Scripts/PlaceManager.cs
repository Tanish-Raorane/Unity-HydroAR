using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManager : MonoBehaviour
{
    private PlaceIndicator placeIndicator;
    public GameObject ObjectToPlace;
    private GameObject SpawnedObject;

    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }

    public void PressToPlace()
    {
        if(SpawnedObject == null)
        {
            if(placeIndicator.Indicator.activeInHierarchy)
            {
                SpawnedObject = Instantiate(ObjectToPlace, placeIndicator.transform.position, ObjectToPlace.transform.rotation);
            }
            
        }
    }
}
