using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tap_Anim : MonoBehaviour
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


    public void PlayAnim()
    {
        if (lockmanager.isLocked)
        {
            StartCoroutine(After_AS());
        }

        //reset this animator in Lock function in LockManager Script
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
            StartCoroutine(AfterCloudForm());
            if (!lockmanager.isLocked)
            {
                StopCoroutine(AfterCloudForm());
                //animator_C1.Rebind();
                //animator_C1.Update(0f);
                //animator_C2.Rebind();
                //animator_C2.Update(0f);
                //animator_C3.Rebind();
                //animator_C3.Update(0f);
            }

        }

        if (count == 2)
        {
            StartCoroutine(AfterCloudMovement());
            if (!lockmanager.isLocked)
            {
                StopCoroutine(AfterCloudMovement());
                //animator_AC.Rebind();
                //animator_AC.Update(0f);
                //animator_C1.Rebind();
                //animator_C1.Update(0f);
                //animator_C2.Rebind();
                //animator_C2.Update(0f);
                //animator_C3.Rebind();
                //animator_C3.Update(0f);
            }
        }

        if (count == 3)
        {
            StartCoroutine(AfterPrecipitation());
            if(!lockmanager.isLocked)
            {
                StopCoroutine(AfterPrecipitation());
                //R1.Clear();
                //R2.Clear();
                //R3.Clear();
            }
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
            //Debug.Log("End");
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

        CloudFormMessage.gameObject.SetActive(true);
        TapOnScreenCloudForm.gameObject.SetActive(true);
        if (lockmanager.isLocked)
        {
            canTap = true;
        }

    }

    IEnumerator AfterCloudMovement()
    {
        CloudFormMessage.gameObject.SetActive(false);
        TapOnScreenCloudForm.gameObject.SetActive(false);

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
    }
}






