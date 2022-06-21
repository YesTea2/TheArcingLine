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
        storyTexts[0] =  "<br><br>" + nameForParty + " and their party head to the forest to embark towards the rumors of great fortune to be made towards the north.<br><br> While heading thru the woods the party came across a city that is not on any of their maps. <br><br>   -  " + nameForParty + " and party have a choice to make";
        storyTexts[4] = "<br><br> Once all of the skeletons had been destroyed the party started to search the farmstead for the supplies needed to continue on their journey. <br> " + nameForParty + " headed to the back of the farmstead and started to search thru the leftover burlap sacks. As " + CharacterSelectButtons.playerName.ToString() + " reached into the second sack they felt something hard and rectacular, something that would not be food. <br> " + nameForParty + " pulled the object from the sack to realize it was a book with thick carvings of some form of runic lettering etched in almost as deep as the cover was thick.";
        storyTexts[5] = "<br>" + nameForParty + "s party and the patrons from the pub start making their way to the towns graveyard on the outskirts of the bordering walls. As the group gets closer to the graveyard the sky seems to darken and a mist rolls across the ground, there is no doubt about this place a great evil is present. <br>The townsman that once seemed so brave look at your party with fear in their eyes. The one that was the loudest says \" I am sorry but none of us will go any further, we have seen what happens to those that challenge the necromancer but we have guided you to the source \" <br> the crowd of people that once followed along turn and make haste back thru the towns gates. Knowing that no good adventurer would go back on their word the party presses on into the graveyard. <br> As they approach the mosolium  near the center they start to hear the shuffling of what sounds like a group of people sliding their feet across the ground";
        storyTexts[6] = "<br><br>" + nameForParty + " tells the crowd that their party will not help and the party turns to leave the pub. The entire pub stands in a uproar \"HOW COULD YOU TELL US NO!!\"  \" YOUR ADVENTURERS ARE YOU NOT!!\"  the crowd becomes louder and louder until someone in the crowd screams \"ATTACK THEM!!!\" everyone in the crowed gets swept up in the commotion. " + nameForParty + "s party tries to leave the pub but the biggest one out the crowed steps in front of the door, its apparent the party wont be able to leave without a fight";
        storyTexts[7] = "<br><br> As " + nameForParty + " cracks open the spine of the book a loud boom can be heard overhead, alarmed the party runs outside to see what it could have been.  < br > The Sky that once was blue has turned the darkest shade of grey as if it happened in a instant, the party starts to look all around to see what could be happening. Back to the south from the direction that they had come from smoke can be seen billowing from the tree line.Seeing a call for aid the party quickly takes haste back thru the forest to the town that they once passed by";
        storyTexts[8] = "<br><br> With the book in bag the party heads back to the path they were following and start making their way further north and into the dessert that was ahead.  < br > After traveling for another days time " + nameForParty + " notices that their is a humming coming from their travel bag. Once  they opened the bag it was obviouse the source of the humming was coming from the book that was now radiating a red light. < br > The humming started to become louder and the book started to pulse with a fierce vibration.The sand around the party started to kick up as if someone was tossing it into the air, the amount of sand being tossed up became so thick it was like trying to look thru a wall. But then just as fast as it started, the book stopped pulsing, the light that was casting dimmed and the sand fell. < br > Only there was someone standing in front of the party behind where the sand wall once stood";
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
        if(choice1 == 1 && choice2 < 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice1 = 2;
        }
        if(choice2 == 1 && choice1 < 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice1 = 3;
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
        if(choice1 == 1 && choice2 < 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice2 = 2;
        }
        if(choice2 == 1 && choice1 < 1)
        {
            choiceOneContainer.SetActive(false);
            choiceTwoContainer.SetActive(false);
            choice2  = 3;
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
        SceneManager.LoadScene(4);
        AkSoundEngine.PostEvent("stop_mus_combat_event", GameObject.Find("WwiseGlobal"));
        AkSoundEngine.PostEvent("stop_mus_theme_event", GameObject.Find("WwiseGlobal"));
        AkSoundEngine.PostEvent("play_mus_combat_event", GameObject.Find("WwiseGlobal"));
    }



}
