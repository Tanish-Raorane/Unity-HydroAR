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

    public GameObject Arrow_Sun, Arrow_Evaporation, Arrow_Cloud;

    LockManager lockmanager;

    bool canTap = false;
    int count = 0;
    private Touch touch;
    //public LockManager lockmanager;
    
    void Start()
    {
        lockmanager = gameObject.GetComponent<LockManager>();
    }


    public void PlayAnim()
    {
        if (lockmanager.isLocked)
        {
            StartCoroutine(After_AS());
        }
        

    }

    private void Update()
    {
        if (Input.touchCount > 0 && canTap)
        {
            count++;
            canTap = false;
            if (touch.phase == TouchPhase.Began)
            {
                touch = Input.GetTouch(0);
            }
        }
                
                if (count == 1)
                {
                    animator_C1.SetTrigger("Cloud 1_Formation");
                    animator_C2.SetTrigger("Cloud 2_Formation");
                    animator_C3.SetTrigger("Cloud 3_Formation");
                }

                if (count == 2)
                {
                    animator_C1.SetTrigger("Cloud 1_Movement");
                    animator_C2.SetTrigger("Cloud 2_Movement");
                    animator_C3.SetTrigger("Cloud 3_Movement");
                }

                if (count == 3)
                {
                    R1.Play();
                    R2.Play();
                    R3.Play();
                }

               
            

        
    }

    IEnumerator After_AS()
    {
       //Debug.Log("Start");
        Arrow_Sun.SetActive(true);
        animator_AS.SetTrigger("Arrow_Sun");
        yield return new WaitForSecondsRealtime(5.5f);

        if (lockmanager.isLocked)
        {
            Arrow_Evaporation.SetActive(true);
            animator_AE.SetTrigger("Arrow_Evaporation");
            yield return new WaitForSeconds(6f);
        }

        if (lockmanager.isLocked)
        {
            
            animator_LF.SetTrigger("Tap_Lake_Fog");
            animator_OF.SetTrigger("Tap_Ocean_Fog");
            yield return new WaitForSeconds(14f);
        }
        
        canTap = true;
        //Debug.Log("End");
    }
}


    
        
   

   