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
    public float timeToWait = .1f;
    private string currentText;




    public void Show(string text)
    {
        storyTextContainer.SetActive(true);
        currentText = text;
        StartCoroutine(DisplayText());
    }

    public void Close()
    {
        StopAllCoroutines();
        storyTextContainer.SetActive(false);
    }

    IEnumerator DisplayText()
    {
        storyText.text = "";

        foreach(char c in currentText.ToCharArray())
        {
            storyText.text += c;
            yield return new WaitForSeconds(timeToWait);
        }
       
    }
}
