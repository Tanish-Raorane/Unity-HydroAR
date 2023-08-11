using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ARPlacement : MonoBehaviour
{
    ARRaycastManager arRaycastManager;
    public GameObject ObjToInstantiate;
    GameObject SpawnedObject;
    Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private Touch touch;
    int count = 0;

    public Animator animator_LF;
    public Animator animator_OF;
    public Animator animator_C1;
    public Animator animator_C2;
    public Animator animator_C3;
    public Animator animator_AS;
    public Animator animator_AE;
    public Animator animator_AC;
    public ParticleSystem R1, R2, R3;


    private void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            touchPosition = touch.position;

            if (SpawnedObject == null)
            {

                if (arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;
                    SpawnedObject = Instantiate(ObjToInstantiate, hitPose.position, hitPose.rotation);
                }
            }

            else
            {
                if (touch.phase == TouchPhase.Began)
                {
                    count++;
                    if (count == 1)
                    {
                        animator_LF.SetTrigger("Tap_Lake_Fog");
                        animator_OF.SetTrigger("Tap_Ocean_Fog");

                    }

                    if (count == 2)
                    {
                        animator_C1.SetTrigger("Cloud 1_Formation");
                        animator_C2.SetTrigger("Cloud 2_Formation");
                        animator_C3.SetTrigger("Cloud 3_Formation");
                    }

                    if (count == 3)
                    {
                        animator_C1.SetTrigger("Cloud 1_Movement");
                        animator_C2.SetTrigger("Cloud 2_Movement");
                        animator_C3.SetTrigger("Cloud 3_Movement");
                    }

                    if (count == 4)
                    {

                        R1.Play();
                        R2.Play();
                        R3.Play();

                    }
                }
            }

        }

    }
}
