using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ReadSpeaker;

public class Anim_Trial : MonoBehaviour
{
    public Button RestartButton, NextButton;
    public RawImage EvaporationMessage, TapOnScreenEva;
    public RawImage CloudFormMessage, TapOnScreenCloudForm;
    public RawImage CloudMoveMessage, TapOnScreenCloudMove;
    public RawImage PrecipitationMessage, TapOnScreenPreci;
    public RawImage AfterPreciMessage, TapOnScreenAfterPreci;
    bool inside = false;


    //public Animator animator_LF;
    //public Animator animator_OF;
    //public Animator animator_C1;
    //public Animator animator_C2;
    //public Animator animator_C3;
    //public Animator animator_AS;
    //public Animator animator_AE;
    //public Animator animator_AC;
    //public ParticleSystem R1, R2, R3;

    public GameObject Arrow_Sun, Arrow_Evaporation, Arrow_Cloud;

    LockManager lockmanager;

    bool canTap = false;
    public int count = 0;
    private Touch touch;
    //public LockManager lockmanager;

    //Sound
    public AudioSource Wind;
    public AudioSource Thunder;

    public TTSSpeaker speaker;
    public TTSSpeaker speaker2;

    void Start()
    {
        StopAllCoroutines();
        TTS.Init();
        lockmanager = gameObject.GetComponent<LockManager>();
        StartCoroutine(InitialAudioPrompt());
        

    }

    


    public void PlayAnim()
    {

        StopCoroutine(After_AS());
        StartCoroutine(After_AS());
    }

    public void StopAnim()
    {

        TTS.InterruptAll();
        StopCoroutine(After_AS());
        StopAllCoroutines();

        EvaporationMessage.gameObject.SetActive(false);
        TapOnScreenEva.gameObject.SetActive(false);
        CloudFormMessage.gameObject.SetActive(false);
        TapOnScreenCloudForm.gameObject.SetActive(false);
        CloudMoveMessage.gameObject.SetActive(false);
        TapOnScreenCloudMove.gameObject.SetActive(false);
        PrecipitationMessage.gameObject.SetActive(false);
        TapOnScreenPreci.gameObject.SetActive(false);

        Arrow_Sun.SetActive(false);
        Arrow_Evaporation.SetActive(false);
        Arrow_Cloud.SetActive(false);

        lockmanager.animator_AS.Rebind();
        lockmanager.animator_AS.Update(0f);
        lockmanager.animator_AE.Rebind();
        lockmanager.animator_AE.Update(0f);
        lockmanager.animator_LF.Rebind();
        lockmanager.animator_LF.Update(0f);
        lockmanager.animator_OF.Rebind();
        lockmanager.animator_OF.Update(0f);
        lockmanager.animator_AC.Rebind();
        lockmanager.animator_AC.Update(0f);
        lockmanager.animator_C1.Rebind();
        lockmanager.animator_C1.Update(0f);
        lockmanager.animator_C2.Rebind();
        lockmanager.animator_C2.Update(0f);
        lockmanager.animator_C3.Rebind();
        lockmanager.animator_C3.Update(0f);

        lockmanager.R1.Stop();
        lockmanager.R2.Stop();
        lockmanager.R3.Stop();

        lockmanager.FirstTime = true;
        RestartButton.gameObject.SetActive(false);
        NextButton.gameObject.SetActive(false);
        lockmanager.playbutton.gameObject.SetActive(true);
        lockmanager.Lock();
        
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
        {
            return;
        }

        
        
            if (Input.touchCount > 0 && canTap && touch.phase == TouchPhase.Began)
            {
                //TTS.InterruptAll();
              
                canTap = false;
                touch = Input.GetTouch(0);
                count++;
            }
        

    }

    public IEnumerator After_AS()
    {
        inside = true;
        StopCoroutine(InitialAudioPrompt());
        TTS.InterruptAll();
        count = 0;
        yield return new WaitUntil(() => lockmanager.isLocked == true);
        //Debug.Log("Start");
        Arrow_Sun.SetActive(true);
        lockmanager.animator_AS.SetTrigger("Arrow_Sun");
        yield return new WaitForSecondsRealtime(5.5f);
        yield return new WaitUntil(() => lockmanager.isLocked == true);

        //if (!lockmanager.isLocked)
        //{
        //    yield return new WaitUntil(() => lockmanager.isLocked == true);
        //}
        
        Arrow_Evaporation.SetActive(true);
        lockmanager.animator_AE.SetTrigger("Arrow_Evaporation");
        yield return new WaitForSecondsRealtime(6f);
        yield return new WaitUntil(() => lockmanager.isLocked == true);

        lockmanager.animator_LF.SetTrigger("Tap_Lake_Fog");
        lockmanager.animator_OF.SetTrigger("Tap_Ocean_Fog");
        yield return new WaitForSecondsRealtime(15f);
        yield return new WaitUntil(() => lockmanager.isLocked == true);

        EvaporationMessage.gameObject.SetActive(true);
        TapOnScreenEva.gameObject.SetActive(true);
        lockmanager.playbutton.gameObject.SetActive(false);

        TTS.Say("The process that you just saw is called Evaporation!! The Sun’s heat warms up the water in oceans lakes and rivers, turning it into water vapour.", speaker);
        yield return new WaitUntil(() => !speaker.audioSource.isPlaying);
        TTS.Say("Tap on the screen to explore the next experience!!", speaker);

        canTap = true;



        yield return new WaitUntil(() => count == 1);
       


        EvaporationMessage.gameObject.SetActive(false);
        TapOnScreenEva.gameObject.SetActive(false);
        lockmanager.playbutton.gameObject.SetActive(true);
        

        lockmanager.animator_C1.SetTrigger("Cloud 1_Formation");
        lockmanager.animator_C2.SetTrigger("Cloud 2_Formation");
        lockmanager.animator_C3.SetTrigger("Cloud 3_Formation");
        yield return new WaitForSecondsRealtime(6f);
        yield return new WaitUntil(() => lockmanager.isLocked == true);

        CloudFormMessage.gameObject.SetActive(true);
        TapOnScreenCloudForm.gameObject.SetActive(true);
        lockmanager.playbutton.gameObject.SetActive(false);
        TTS.Say("Next, the water vapour cools and changes back into tiny water droplets, thus forming clouds!! This is called Condensation.", speaker);
        yield return new WaitUntil(() => !speaker.audioSource.isPlaying);
        TTS.Say("Now, tap on the screen to see the effect of wind....", speaker);
        canTap = true;




        yield return new WaitUntil(() => count == 2);


        CloudFormMessage.gameObject.SetActive(false);
        TapOnScreenCloudForm.gameObject.SetActive(false);
        lockmanager.playbutton.gameObject.SetActive(true);

        Arrow_Cloud.SetActive(true);
        lockmanager.animator_AC.SetTrigger("Arrow_Clouds");
        yield return new WaitForSecondsRealtime(4.5f);
        yield return new WaitUntil(() => lockmanager.isLocked == true);

        lockmanager.animator_C1.SetTrigger("Cloud 1_Movement");
        lockmanager.animator_C2.SetTrigger("Cloud 2_Movement");
        lockmanager.animator_C3.SetTrigger("Cloud 3_Movement");
        Wind.Play();
        yield return new WaitForSecondsRealtime(13f);
        yield return new WaitUntil(() => lockmanager.isLocked == true);

        CloudMoveMessage.gameObject.SetActive(true);
        TapOnScreenCloudMove.gameObject.SetActive(true);
        lockmanager.playbutton.gameObject.SetActive(false);
        TTS.Say("The clouds move towards the mountain regions and become saturated.", speaker);
        yield return new WaitUntil(() => !speaker.audioSource.isPlaying);
        TTS.Say("Tap on the screen to see what happens next!!", speaker);

        canTap = true;
        yield return new WaitUntil(() => count == 3);

        CloudMoveMessage.gameObject.SetActive(false);
        TapOnScreenCloudMove.gameObject.SetActive(false);
        lockmanager.playbutton.gameObject.SetActive(true);

        Thunder.Play();
        lockmanager.R1.Play();
        lockmanager.R2.Play();
        lockmanager.R3.Play();

        yield return new WaitForSecondsRealtime(13f);
        yield return new WaitUntil(() => lockmanager.isLocked == true);

        PrecipitationMessage.gameObject.SetActive(true);
        TapOnScreenPreci.gameObject.SetActive(true);
        lockmanager.playbutton.gameObject.SetActive(false);
        TTS.Say("Eventually, the clouds become heavy with water droplets and release water back into the ground in the form of rain, snow, sleet, and hail. This is called Precipitation.", speaker2);
        yield return new WaitUntil(() => !speaker2.audioSource.isPlaying);
        TTS.Say("Tap on the screen to continue...", speaker2);


        canTap = true;
        yield return new WaitUntil(() => count == 4);

        PrecipitationMessage.gameObject.SetActive(false);
        TapOnScreenPreci.gameObject.SetActive(false);
        

        AfterPreciMessage.gameObject.SetActive(true);
        //TapOnScreenAfterPreci.gameObject.SetActive(true);
        canTap = true;
        TTS.Say("After Precipitation, the water goes back into the lakes rivers and oceans and gets warmed up by the Sun’s heat and turns into water vapour. I could go on all day, but you get the point!!", speaker2);

        yield return new WaitUntil(() => !speaker2.audioSource.isPlaying);
        //yield return new WaitUntil(() => count == 5);

        AfterPreciMessage.gameObject.SetActive(false);
        //TapOnScreenAfterPreci.gameObject.SetActive(false);
        RestartButton.gameObject.SetActive(true);
        NextButton.gameObject.SetActive(true);
        lockmanager.Lock();
        
    }

    public IEnumerator InitialAudioPrompt()
    {
        
        yield return new WaitForSecondsRealtime(2f);
        if (!inside)
        {
            TTS.Say("Now that you have placed the model, you can move the model by placing your finger on it and dragging it around.", speaker);
        }
        yield return new WaitUntil(() => !speaker.audioSource.isPlaying);
        yield return new WaitForSecondsRealtime(2.5f);
        if (!inside)
        {
            TTS.Say("You can scale and rotate the model by pressing on the respective buttons and adjusting the sliders to the desired scale and rotation.", speaker);
        }
        yield return new WaitUntil(() => !speaker.audioSource.isPlaying);
        yield return new WaitForSecondsRealtime(2.5f);
        if (!inside)
        {
            TTS.Say("You can click on the Play button given below to experience the process of water cycle.", speaker);
        }
    }
}







