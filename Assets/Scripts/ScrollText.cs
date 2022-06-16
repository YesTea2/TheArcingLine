using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScrollText : MonoBehaviour
{
    [Header("Text Objects To Read")]
    public GameObject storyTextContainer;
    public TMP_Text storyText;
    [Header("How Fast To Read Text")]
    public float timeToWait = .01f;
    private string currentText;



    public void Show(string text)
    {
        //storyTextContainer.SetActive(true);
        currentText = text;
        StartCoroutine(DisplayText());
    }

    public void Close()
    {
        StopAllCoroutines();
        storyText.text = "";
    }

    IEnumerator DisplayText()
    {
        storyText.text = "";
        int index = 0;
        foreach(char c in currentText.ToCharArray())
        {
            storyText.text += c;
            if (index%4==0)
            {
                AkSoundEngine.PostEvent("dialogue_event", GameObject.Find("WwiseGlobal"));   
            }
            index++;
            yield return new WaitForSeconds(timeToWait);
        }
       
    }
}
