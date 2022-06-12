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


    //    story 1 - arc1_x  or arc1_y     if  arc1_x  story 2a    if arc1_y story 2B    if story 2a  arc2_x_choice1  arc2_y_choice2    if story2B  arc2_x_choice3  arc2_y_choice4

        private void Start()
    {
        if (lvlOneChoiceOne)
        {
            curLevel += 1;

        }
        else if (lvlOneChoiceTwo)
        {
            curLevel += 2;
        }

        sT = FindObjectOfType<ScrollText>();
       

      
            sT.Show(storyTexts[curLevel]);
        
       
    }

    private void Update()
    {
        if (choiceOneContainer.activeInHierarchy)
        {
            choiceOneContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsOne[curLevel];
        }
        if (choiceTwoContainer.activeInHierarchy)
        {
            choiceTwoContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsTwo[curLevel];
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
        if(curLevel == 0)
        {
            lvlOneChoiceOne = true;
            StartCoroutine(EndStoryScene());
           
        }
        if(curLevel == 1)
        {
            lvlTwoChoiceOne = true;
            StartCoroutine(EndStoryScene());

        }
        if (curLevel == 2)
        {
            lvlThreeChoiceOne = true;
            StartCoroutine(EndStoryScene());

        }
    }

    public void ClickedChoiceTwo()
    {
        if(curLevel == 0)
        {
            lvlOneChoiceTwo = true;
            StartCoroutine(EndStoryScene());

        }
        if (curLevel == 1)
        {
            lvlTwoChoiceTwo = true;
            StartCoroutine(EndStoryScene());

        }
        if (curLevel == 2)
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
        StopAllCoroutines();
        SceneManager.LoadScene(3);
    }

}
