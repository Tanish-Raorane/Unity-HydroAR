using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LockManager : MonoBehaviour
{
    public Button playbutton;
    public bool isLocked = false;
    public GameObject Model;
    public Slider Scaler, Rotator;
    public Button ScaleButton, RotateButton;
    Anim_Trial TA;
    bool wasClickedScale = false;
    bool wasClickedRotate = false;

    /* For Rebinding (Resetting) all animations once the 
     *  user presses on Play Button to start animation.*/
    //public Image EvaporationMessage, TapOnScreenEva;
    //public Image CloudFormMessage, TapOnScreenCloudForm;
    //public Image CloudMoveMessage, TapOnScreenCloudMove;
    //public Image PrecipitationMessage, TapOnScreenPreci;

    public Animator animator_LF;
    public Animator animator_OF;
    public Animator animator_C1;
    public Animator animator_C2;
    public Animator animator_C3;
    public Animator animator_AS;
    public Animator animator_AE;
    public Animator animator_AC;
    public ParticleSystem R1, R2, R3;

    private void Start()
    {
        TA = gameObject.GetComponent<Anim_Trial>();
        
    }


    public void Lock()
    {
        //Deactivate all Prompts (TextBoxes/images)
        //Reset ALL Animators here
        //Try implementing Pause Button
        //Debug.Log("Hi");
        // Remove Tap Interaction with UI Button
        isLocked = !isLocked;
        if (isLocked)
        {
            /*Resetting all animations so that when the user presses on play button again,
             The animations will start from the beginning.*/
            animator_AS.Rebind();
            animator_AS.Update(0f);
            animator_AE.Rebind();
            animator_AE.Update(0f);
            animator_LF.Rebind();
            animator_LF.Update(0f);
            animator_OF.Rebind();
            animator_OF.Update(0f);
            animator_AC.Rebind();
            animator_AC.Update(0f);
            animator_C1.Rebind();
            animator_C1.Update(0f);
            animator_C2.Rebind();
            animator_C2.Update(0f);
            animator_C3.Rebind();
            animator_C3.Update(0f);

            R1.Clear();
            R2.Clear();
            R3.Clear();

            /*Deactivating all Prompts.*/
            //EvaporationMessage.gameObject.SetActive(false);
            //TapOnScreenEva.gameObject.SetActive(false);
            //CloudFormMessage.gameObject.SetActive(false);
            //TapOnScreenCloudForm.gameObject.SetActive(false);
            //CloudMoveMessage.gameObject.SetActive(false);
            //TapOnScreenCloudMove.gameObject.SetActive(false);
            //PrecipitationMessage.gameObject.SetActive(false);
            //TapOnScreenPreci.gameObject.SetActive(false);


            Scaler.gameObject.SetActive(false);
            Rotator.gameObject.SetActive(false);
            ScaleButton.gameObject.SetActive(false);
            RotateButton.gameObject.SetActive(false);
            //Scaler.enabled = false;
            //Rotator.enabled = false;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = false;
            TA.StartCoroutine(PlayAnim);
          
        }

        else
        {
            
            if (wasClickedScale)
            {
                Scaler.gameObject.SetActive(true);
            }
            if (wasClickedRotate)
            {
                Rotator.gameObject.SetActive(true);
            }
            ScaleButton.gameObject.SetActive(true);
            RotateButton.gameObject.SetActive(true);
            //Scaler.enabled = true;
            //Rotator.enabled = true;
            Model.GetComponent<Lean.Touch.LeanDragTranslate>().enabled = true;
            
        }

    }

    public void OnClickScale()
    {
        if (!Scaler.gameObject.activeInHierarchy)
        {
            Scaler.gameObject.SetActive(true);
            wasClickedScale = true;
        }
        else
        {
            Scaler.gameObject.SetActive(false);
            wasClickedScale = false;
        }
    }

    public void OnClickRotate()
    {
        if (!Rotator.gameObject.activeInHierarchy)
        {
            Rotator.gameObject.SetActive(true);
            wasClickedRotate = true;
        }
        else
        {
            Rotator.gameObject.SetActive(false);
            wasClickedRotate = false;
        }
    }
}

