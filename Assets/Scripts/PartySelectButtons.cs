using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PartySelectButtons : MonoBehaviour
{
    

    [Header("Class Strings")]
    public TextMeshProUGUI classTextContainer;
    public string[] classStrings;

    [Header("Class Buttons")]
    public Button hunterButton;
    public Button rougeButton;
    public Button swordsmanButton;
    public Button bardButton;
    public Button mageButton;

    [Header("Class Buttons BG Images")]
    public Image hunterClassButton;
    public Image rougeClassButton;
    public Image swordsmanClassButton;
    public Image bardClassButton;
    public Image mageClassButton;

    [Header("Confirm Button")]
    public TMP_Text confirmButtonText;


    private bool hunterSelected;
    private bool rougeSelected;
    private bool swordsmanSelected;
    private bool mageSelected;
    private bool bardSelected;
    private bool adventureReady;

    public static bool notSelectedHunter;
    public static bool notSelectedRouge;
    public static bool notSelectedSwordsman;
    public static bool notSelectedMage;
    public static bool notSelectedBard;
    public static int[] arrayClassNumbers = new int[2];

    private int classNumber;
    private int amountSelected;

    private Color storedColor;

    public static PartySelectButtons instance;
    private void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

       
        
    }

        private void Start()
    {
        storedColor = hunterClassButton.color;
        notSelectedHunter = true;
        notSelectedRouge = true;
        notSelectedSwordsman = true;
        notSelectedBard = true;
        notSelectedMage = true;

        classTextContainer.text = "Choose Your Party " + CharacterSelectButtons.playerName.ToString() + "<br><br> <size=5><br>(Select 2 heroes to join party)<br><br> (Select your first member)";

    }


    private void Update()
    {
      

       if(amountSelected < 2)
        {
            if (notSelectedHunter)
            {
                if (classNumber != 0)
                {
                    hunterClassButton.color = storedColor;

                    hunterSelected = false;
                }
            }
            if (notSelectedRouge)
            {
                if (classNumber != 1)
                {
                    rougeClassButton.color = storedColor;

                    rougeSelected = false;
                }
            }
            if (notSelectedSwordsman)
            {
                if (classNumber != 2)
                {
                    swordsmanClassButton.color = storedColor;

                    swordsmanSelected = false;
                }
            }
            if (notSelectedBard)
            {
                if (classNumber != 3)
                {
                    bardClassButton.color = storedColor;

                    bardSelected = false;
                }
            }
            if (notSelectedMage)
            {
                if (classNumber != 4)
                {
                    mageClassButton.color = storedColor;

                    mageSelected = false;
                }
            }
        }
        
      
    }

    public void OnPartyClick(int arraySpot)
    {


        if (arraySpot == 0)
        {
            if (!hunterSelected)
            {
                
                classNumber = 0;
                hunterClassButton.color = new Color32(115, 111, 111, 255);
                classTextContainer.text = classStrings[0];
                confirmButtonText.text = "Confirm Selection?";
               
                hunterSelected = true;
                
            }
            

        }

        if(arraySpot == 1)
        {
            if (!rougeSelected)
            {
                classNumber = 1;
                rougeClassButton.color = new Color32(115, 111, 111, 255);
                classTextContainer.text = classStrings[1];
                confirmButtonText.text = "Confirm Selection?";
                rougeSelected = true;
            }
        }

        if(arraySpot == 2)
        {
            if (!swordsmanSelected)
            {
                classNumber = 2;
                swordsmanClassButton.color = new Color32(115, 111, 111, 255);
                classTextContainer.text = classStrings[2];
                confirmButtonText.text = "Confirm Selection?";
                swordsmanSelected = true;
            }
        }

        if(arraySpot == 3)
        {
            if (!bardSelected)
            {
                classNumber = 3;
                bardClassButton.color = new Color32(115, 111, 111, 255);
                classTextContainer.text = classStrings[3];
                confirmButtonText.text = "Confirm Selection?";
                bardSelected = true;
            }
        }

        if(arraySpot == 4)
        {
            if (!mageSelected)
            {
                classNumber = 4;
                mageClassButton.color = new Color32(115, 111, 111, 255);
                classTextContainer.text = classStrings[4];
                confirmButtonText.text = "Confirm Selection?";
                mageSelected = true;

            }
        }
    }


    public void OnConfirmClick()
    {

        if (!adventureReady)
        {
            if (amountSelected < 2)
            {
                amountSelected += 1;
                if (amountSelected == 2)
                {
                    StartCoroutine(PartySelected());

                    hunterButton.enabled = false;
                    rougeButton.enabled = false;
                    swordsmanButton.enabled = false;
                    bardButton.enabled = false;
                    mageButton.enabled = false;
                }
                if (hunterSelected)
                {
                    classTextContainer.text = "<size=4>Hunter Has Joined Party";
                    hunterButton.enabled = false;
                    hunterClassButton.color = new Color32(115, 115, 115, 255);
                    hunterSelected = false;

                    if (arrayClassNumbers[0] == 0)
                    {
                        arrayClassNumbers[0] = 1;
                    }
                    else
                    {
                        arrayClassNumbers[1] = 1;
                    }

                    notSelectedHunter = false;
                }

                if (rougeSelected)
                {
                    classTextContainer.text = "<size=4>Rouge Has Joined Party";
                    rougeButton.enabled = false;
                    rougeClassButton.color = new Color32(115, 115, 115, 255);
                    rougeSelected = false;

                    if (arrayClassNumbers[0] == 0)
                    {
                        arrayClassNumbers[0] = 2;
                    }
                    else
                    {
                        arrayClassNumbers[1] = 2;
                    }

                    notSelectedRouge = false;
                }

                if (swordsmanSelected)
                {
                    classTextContainer.text = "<size=4>Swordsman Has Joined Party";
                    swordsmanButton.enabled = false;
                    swordsmanClassButton.color = new Color32(115, 115, 115, 255);
                    swordsmanSelected = false;

                    if (arrayClassNumbers[0] == 0)
                    {
                        arrayClassNumbers[0] = 3;
                    }
                    else
                    {
                        arrayClassNumbers[1] = 3;
                    }

                    notSelectedSwordsman = false;
                }

                if (bardSelected)
                {
                    classTextContainer.text = "<size=4>Bard Has Joined Party";
                    bardButton.enabled = false;
                    bardClassButton.color = new Color32(115, 115, 115, 255);
                    bardSelected = false;

                    if (arrayClassNumbers[0] == 0)
                    {
                        arrayClassNumbers[0] = 4;
                    }
                    else
                    {
                        arrayClassNumbers[1] = 4;
                    }

                    notSelectedBard = false;
                }

                if (mageSelected)
                {
                    classTextContainer.text = "<size=4>Mage Has Joined Party";
                    mageButton.enabled = false;
                    mageClassButton.color = new Color32(115, 115, 115, 255);
                    mageSelected = false;

                    if (arrayClassNumbers[0] == 0)
                    {
                        arrayClassNumbers[0] = 5;
                    }
                    else
                    {
                        arrayClassNumbers[1] = 5;
                    }

                    notSelectedMage = false;
                }
            }
        }
        else if (adventureReady)
        {
            SceneManager.LoadScene(2);
        }
      
    }

    IEnumerator PartySelected()
    {
        yield return new WaitForSeconds(1f);
        classTextContainer.text = "<size=5>And So The party Was Formed";
        confirmButtonText.text = "Start Adventure";
        adventureReady = true;
    }
    
}
