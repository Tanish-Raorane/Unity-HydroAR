using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap_Anim : MonoBehaviour
{
    public Animator animator_LF;
    public Animator animator_OF;
    public Animator animator_C1;
    public Animator animator_C2;
    public Animator animator_C3;
    public Animator animator_AS;
    public Animator animator_AE;
    public Animator animator_AC;
    public ParticleSystem R1, R2, R3;

    int count = 0;
    private Touch touch;
    
    void Start()
    {
        
    }

  
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
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
