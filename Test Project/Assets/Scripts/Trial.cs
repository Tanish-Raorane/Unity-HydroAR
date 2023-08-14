using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trial : MonoBehaviour
{
    private PlaceIndicator placeIndicator;
    public GameObject ObjectToPlace;
    MeshRenderer mr;
    //bool isSpawned = false;

    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
        //mr = ObjectToPlace.GetComponent<MeshRenderer>();
        //mr.enabled = false;
        ObjectToPlace.SetActive(false);
    }

    public void PressToPlace()
    {

        ObjectToPlace.SetActive(true);
        //mr.enabled = true;
        ObjectToPlace.transform.position = placeIndicator.transform.position;
        
        //if (SpawnedObject == null)
        //{
        //    if (placeIndicator.Indicator.activeInHierarchy)
        //    {
        //        SpawnedObject = Instantiate(ObjectToPlace, placeIndicator.transform.position, ObjectToPlace.transform.rotation);
        //    }

        //}
    }
}