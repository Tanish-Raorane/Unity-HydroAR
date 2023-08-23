using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim_Trial : MonoBehaviour
{
    public Image EvaporationMessage, TapOnScreenEva;
    public Image CloudFormMessage, TapOnScreenCloudForm;
    public Image CloudMoveMessage, TapOnScreenCloudMove;
    public Image PrecipitationMessage, TapOnScreenPreci;

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


    IEnumerator PlayAnim()
    {
        if (lockmanager.isLocked)
        {
            StartCoroutine(After_AS());
        }
       
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
               
            }

            if (count == 2)
            {
                

            }

            if (count == 3)
            {
                
            }
        yield return null;
        

       
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
            yield return new WaitForSecondsRealtime(6f);
        }

        if (lockmanager.isLocked)
        {

            animator_LF.SetTrigger("Tap_Lake_Fog");
            animator_OF.SetTrigger("Tap_Ocean_Fog");
            yield return new WaitForSecondsRealtime(14f);
            if (lockmanager.isLocked)
            {
                EvaporationMessage.gameObject.SetActive(true);
                TapOnScreenEva.gameObject.SetActive(true);
            }

        }

        if (lockmanager.isLocked)
        {
            canTap = true;
        }
    }

    IEnumerator AfterCloudForm()
    {
        EvaporationMessage.gameObject.SetActive(false);
        TapOnScreenEva.gameObject.SetActive(false);


        animator_C1.SetTrigger("Cloud 1_Formation");
        animator_C2.SetTrigger("Cloud 2_Formation");
        animator_C3.SetTrigger("Cloud 3_Formation");
        yield return new WaitForSecondsRealtime(4.5f);

        //Debug.Log("Before active " + CloudFormMessage.gameObject.activeSelf);
        if (lockmanager.isLocked)
        {
            CloudFormMessage.gameObject.SetActive(true);
            TapOnScreenCloudForm.gameObject.SetActive(true);
        }

        //Debug.Log("after active  " + CloudFormMessage.gameObject.activeSelf);


        if (lockmanager.isLocked)
        {
            canTap = true;
            yield break;
        }

    }

    IEnumerator AfterCloudMovement()
    {
        Debug.Log("1");
        CloudFormMessage.gameObject.SetActive(false);
        Debug.Log("2");
        TapOnScreenCloudForm.gameObject.SetActive(false);
        //Debug.Log("After deactive " + CloudFormMessage.gameObject.activeSelf);

        Arrow_Cloud.SetActive(true);
        animator_AC.SetTrigger("Arrow_Clouds");
        yield return new WaitForSecondsRealtime(4.5f);

        animator_C1.SetTrigger("Cloud 1_Movement");
        animator_C2.SetTrigger("Cloud 2_Movement");
        animator_C3.SetTrigger("Cloud 3_Movement");
        yield return new WaitForSecondsRealtime(8.1f);

        CloudMoveMessage.gameObject.SetActive(true);
        TapOnScreenCloudMove.gameObject.SetActive(true);
        if (lockmanager.isLocked)
        {
            canTap = true;
            yield break;
        }
    }

    IEnumerator AfterPrecipitation()
    {
        CloudMoveMessage.gameObject.SetActive(false);
        TapOnScreenCloudMove.gameObject.SetActive(false);

        R1.Play();
        R2.Play();
        R3.Play();
        yield return new WaitForSecondsRealtime(6f);

        PrecipitationMessage.gameObject.SetActive(true);
        TapOnScreenPreci.gameObject.SetActive(true);
        yield break;
    }
}






