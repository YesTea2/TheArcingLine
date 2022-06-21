using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInterface : MonoBehaviour
{
    private GameObject wwiseObject;

    private void Awake()
    {
        wwiseObject = GameObject.Find("WwiseGlobal");
    }

    public void NextButton()
    {
        AkSoundEngine.PostEvent("ui_next_event", wwiseObject);
    }

  public void ClickButton()
    {
        AkSoundEngine.PostEvent("ui_click_event", wwiseObject);
    }
}
