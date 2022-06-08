using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class StoryScript : MonoBehaviour
{
    [Header("Story Text To Read")]
    public string[] storyTexts;
    public string[] choiceTextsOne;
    public string[] choiceTextsTwo;

    [Header("Choice Refs")]
    public GameObject choiceOneContainer;
    public GameObject choiceTwoContainer;
   
    [HideInInspector]
    public ScrollText sT;

    static int curLevel;

    static bool lvlOneChoiceOne;
    static bool lvlOneChoiceTwo;
    static bool lvlTwoChoiceOne;
    static bool lvlTwoChoiceTwo;
    static bool lvlThreeChoiceOne;
    static bool lvlThreeChoiceTwo;

    //public static StoryScript instance;
    //private void Awake()
    //{

    //    if (instance == null)
    //        instance = this;
    //    else
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }
    //    DontDestroyOnLoad(gameObject);

      
    //}

        private void Start()
    {
        sT = FindObjectOfType<ScrollText>();
        curLevel += 1;

        if(curLevel == 1)
        {
            sT.Show(storyTexts[0]);
        }
       
    }

    private void Update()
    {
        if (choiceOneContainer.activeInHierarchy)
        {
            choiceOneContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsOne[curLevel -1];
        }
        if (choiceTwoContainer.activeInHierarchy)
        {
            choiceTwoContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsTwo[curLevel -1];
        }
    }

    public void GoToChoices()
    {
        sT.Close();
        choiceOneContainer.SetActive(true);
        choiceTwoContainer.SetActive(true);
    }

    public void ClickedChoiceOne()
    {
        if(curLevel == 1)
        {
            lvlOneChoiceOne = true;
            StartCoroutine(EndStoryScene());
           
        }
        if(curLevel == 2)
        {
            lvlTwoChoiceOne = true;
            StartCoroutine(EndStoryScene());

        }
        if (curLevel == 3)
        {
            lvlThreeChoiceOne = true;
            StartCoroutine(EndStoryScene());

        }
    }

    public void ClickedChoiceTwo()
    {
        if(curLevel == 1)
        {
            lvlOneChoiceTwo = true;
            StartCoroutine(EndStoryScene());

        }
        if (curLevel == 2)
        {
            lvlTwoChoiceTwo = true;
            StartCoroutine(EndStoryScene());

        }
        if (curLevel == 3)
        {
            lvlThreeChoiceTwo = true;
            StartCoroutine(EndStoryScene());

        }
    }

    IEnumerator EndStoryScene()
    {
        yield return new WaitForSeconds(.1f);
        choiceOneContainer.SetActive(false);
        choiceTwoContainer.SetActive(false);
        SceneManager.LoadScene(3);
    }

}
