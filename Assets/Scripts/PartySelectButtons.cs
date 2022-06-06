using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    private bool notSelectedHunter;
    private bool notSelectedRouge;
    private bool notSelectedSwordsman;
    private bool notSelectedMage;
    private bool notSelectedBard;

    private int classNumber;
    private int amountSelected;

    private Color storedColor;

    private void Start()
    {
        storedColor = hunterClassButton.color;
        notSelectedHunter = true;
        notSelectedRouge = true;
        notSelectedSwordsman = true;
        notSelectedBard = true;
        notSelectedMage = true;

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
        

        if(amountSelected < 2)
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
                notSelectedHunter = false;
            }

            if (rougeSelected)
            {
                classTextContainer.text = "<size=4>Rouge Has Joined Party";
                rougeButton.enabled = false;
                rougeClassButton.color = new Color32(115, 115, 115, 255);
                rougeSelected = false;
                notSelectedRouge = false;
            }

            if (swordsmanSelected)
            {
                classTextContainer.text = "<size=4>Swordsman Has Joined Party";
                swordsmanButton.enabled = false;
                swordsmanClassButton.color = new Color32(115, 115, 115, 255);
                swordsmanSelected = false;
                notSelectedSwordsman = false;
            }

            if (bardSelected)
            {
                classTextContainer.text = "<size=4>Bard Has Joined Party";
                bardButton.enabled = false;
                bardClassButton.color = new Color32(115, 115, 115, 255);
                bardSelected = false;
                notSelectedBard = false;
            }

            if (mageSelected)
            {
                classTextContainer.text = "<size=4>Mage Has Joined Party";
                mageButton.enabled = false;
                mageClassButton.color = new Color32(115, 115, 115, 255);
                mageSelected = false;
                notSelectedMage = false;
            }
        }
      
    }

    IEnumerator PartySelected()
    {
        yield return new WaitForSeconds(1f);
        classTextContainer.text = "<size=5>And So The party Was Formed";
        confirmButtonText.text = "Start Adventure";

    }
    
}
