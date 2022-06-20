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

    [Header("Background Images")]
    public Image bgImage;
    public Color[] colorsForBackground;
    public GameObject[] backgroundObjects;

    static int curLevel;

    static bool lvlOneChoiceOne;
    static bool lvlOneChoiceTwo;
    static bool lvlTwoChoiceOne;
    static bool lvlTwoChoiceTwo;
    static bool lvlThreeChoiceOne;
    static bool lvlThreeChoiceTwo;
    public static int choice1;
    public static int choice2;

    private static bool hasAssignedLevelOne;
    private static bool hasAssignedLevelTwo;
    private string nameForParty;

   
      
        private void Start()
    {
        nameForParty = CharacterSelectButtons.playerName.ToString();
        storyTexts[0] = "<br><br>  You and your party head to the forest to embark towards the rumors of great fortune to be made towards the north.<br><br> While heading thru the woods you and your party came across a city that is not on their map.<br><Br>   -  " + nameForParty + " and party have a choice to make";
        //if (lvlOneChoiceOne)
        //{
        //    curLevel += 1;

        //}
        //else if (lvlOneChoiceTwo)
        //{
        //    curLevel += 2;
        //}

        sT = FindObjectOfType<ScrollText>();


        if (curLevel == 0)
        {
            sT.Show(storyTexts[curLevel]);
            bgImage.color = colorsForBackground[0];
        }
        
        if(choice1 == 1)
        {
            
            sT.Show(storyTexts[3]);

        }
        
        if(choice2 == 1)
        {
            
            sT.Show(storyTexts[4]);
        }
       
    }

    private void Update()
    {
        if (choiceOneContainer.activeInHierarchy)
        {
           
            if (curLevel == 0)
                choiceOneContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsOne[curLevel];
           if(choice1 == 1)
                choiceOneContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsOne[1];
                
           if(choice2 == 1)
                choiceOneContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsOne[2];


        }
      
        if (choiceTwoContainer.activeInHierarchy)
        {
            if (curLevel == 0)
                choiceTwoContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsTwo[curLevel];
            if(choice1 == 1)
                choiceTwoContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsTwo[1];
            if (choice2 == 1)
                choiceTwoContainer.transform.GetChild(0).GetComponent<TMP_Text>().text = choiceTextsTwo[2];

        }

        if (lvlOneChoiceOne && !hasAssignedLevelOne)
        {
            choice1 = 1;
            bgImage.color = colorsForBackground[1];
            backgroundObjects[0].SetActive(false);
            backgroundObjects[1].SetActive(false);
            backgroundObjects[2].SetActive(false);
            backgroundObjects[3].SetActive(false);
            backgroundObjects[4].SetActive(false);
            backgroundObjects[5].SetActive(true);
            backgroundObjects[6].SetActive(true);
            backgroundObjects[7].SetActive(true);
            backgroundObjects[8].SetActive(true);
            backgroundObjects[9].SetActive(true);




            sT.Show(storyTexts[1]);
            hasAssignedLevelOne = true;

        }
        else if (lvlOneChoiceTwo && !hasAssignedLevelOne)
        {
            bgImage.color = colorsForBackground[2];
            backgroundObjects[0].SetActive(false);
            backgroundObjects[1].SetActive(false);
            backgroundObjects[2].SetActive(false);
            backgroundObjects[3].SetActive(false);
            backgroundObjects[4].SetActive(false);
            backgroundObjects[11].SetActive(true);
           
            choice2 = 1;
            sT.Show(storyTexts[2]);
            hasAssignedLevelOne = true;

        }

        if(choice1 == 2 && !hasAssignedLevelTwo)
        {
            bgImage.color = colorsForBackground[3];
            backgroundObjects[0].SetActive(false);
            backgroundObjects[1].SetActive(false);
            backgroundObjects[2].SetActive(false);
            backgroundObjects[3].SetActive(false);
            backgroundObjects[4].SetActive(false);
            if (backgroundObjects[5].activeInHierarchy)
            {
                backgroundObjects[5].SetActive(false);
                backgroundObjects[6].SetActive(false);
                backgroundObjects[7].SetActive(false);
                backgroundObjects[8].SetActive(false);
                backgroundObjects[9].SetActive(false);
            }
            if (backgroundObjects[11].activeInHierarchy)
            {
                backgroundObjects[11].SetActive(false);
            }
            backgroundObjects[12].SetActive(true);
            sT.Show(storyTexts[5]);
            hasAssignedLevelTwo = true;

        }
        if(choice1 == 3 && !hasAssignedLevelTwo)
        {
           
            sT.Show(storyTexts[7]);
            hasAssignedLevelTwo = true;
        }
        if(choice2 == 2 && !hasAssignedLevelTwo)
        {
           
            sT.Show(storyTexts[6]);
            hasAssignedLevelTwo = true;
        }
        if(choice2 == 3 && !hasAssignedLevelTwo)
        {
            sT.Show(storyTexts[8]);
            hasAssignedLevelTwo = true;
        }



    }

    public void GoToChoices()
    {
        if (curLevel < 2 && PartySelectButtons.levelCarryOver == 0)
        {
            if (!hasAssignedLevelOne)
            {
                sT.Close();
                choiceOneContainer.SetActive(true);
                choiceTwoContainer.SetActive(true);

                
            }
            else if (hasAssignedLevelOne)
            {
                StartCoroutine(EndStoryScene());
            }
        }
       else if(choice1 == 1)
        {
            sT.Close();
            choiceOneContainer.SetActive(true);
            choiceTwoContainer.SetActive(true);
        }
        else if(choice2 == 1)
        {
            sT.Close();
            choiceOneContainer.SetActive(true);
            choiceTwoContainer.SetActive(true);
        }
        if (hasAssignedLevelTwo)
        {
            StartCoroutine(EndStoryScene());
        }
    }

        public void ClickedChoiceOne()
    {
        if(curLevel == 0)
        {
           
            lvlOneChoiceOne = true;
            // StartCoroutine(EndStoryScene());
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            curLevel += 1;
        }
        if(choice1 == 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice1 += 1;
        }
        if(choice2 == 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice2 += 1;
        }
        //if(curLevel == 1)
        //{
        //    lvlTwoChoiceOne = true;
        //   // StartCoroutine(EndStoryScene());

        //}
        //if (curLevel == 2)
        //{
        //    lvlThreeChoiceOne = true;
        //  //  StartCoroutine(EndStoryScene());

        //}
    }

    public void ClickedChoiceTwo()
    {
        if(curLevel == 0)
        {
          
            lvlOneChoiceTwo = true;
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            curLevel += 1;
            // StartCoroutine(EndStoryScene());

        }
        if(choice1 == 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice1 += 2;
        }
        if(choice2 == 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice2 += 2;
        }
        //if (curLevel == 1)
        //{
        //    lvlTwoChoiceTwo = true;
        //   // StartCoroutine(EndStoryScene());

        //}
        //if (curLevel == 2)
        //{
        //    lvlThreeChoiceTwo = true;
        //  //  StartCoroutine(EndStoryScene());

        //}
    }

    void CloseContainers()
    {
        choiceOneContainer.SetActive(false);
        choiceTwoContainer.SetActive(false);
    }

    IEnumerator EndStoryScene()
    {
        yield return new WaitForSeconds(.1f);
        choiceOneContainer.SetActive(false);
        choiceTwoContainer.SetActive(false);
        StopAllCoroutines();
        SceneManager.LoadScene(3);
        AkSoundEngine.PostEvent("stop_mus_combat_event", GameObject.Find("WwiseGlobal"));
        AkSoundEngine.PostEvent("stop_mus_theme_event", GameObject.Find("WwiseGlobal"));
        AkSoundEngine.PostEvent("play_mus_combat_event", GameObject.Find("WwiseGlobal"));
    }



}
