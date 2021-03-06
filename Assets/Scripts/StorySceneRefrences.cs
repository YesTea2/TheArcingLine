using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StorySceneRefrences : MonoBehaviour
{
    

    [Header("Party Images")]
    public Image memberContainer1;
    public Image memberContainer2;
    public Image memberContainer3;
    public Sprite[] partyMemberSprites;

    [Header("Player Sprite Parts")]
    public Sprite[] headImages;
    public Sprite[] bodyImages;
    public Sprite[] legImages;
    public Sprite[] weaponImages;
    public Sprite[] capeImages;

    [Header("Player Image Containers")]
    public Image headImage;
    public Image bodyImage;
    public Image legImage;
    public Image weaponImage;
    public Image capeImage;



    private bool hasBeenAssignedFirstMember;




    private void Start()
    {
        headImage.sprite = headImages[CharacterSelectButtons.headSelected];
        bodyImage.sprite = bodyImages[CharacterSelectButtons.bodySelected];
        legImage.sprite = legImages[CharacterSelectButtons.legSelected];
        weaponImage.sprite = weaponImages[CharacterSelectButtons.classSelected];
        capeImage.sprite = capeImages[CharacterSelectButtons.capeSelected];
        
        //checking for hunter in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 1 || PartySelectButtons.arrayClassNumbers[1] == 1)
        {
            if (!hasBeenAssignedFirstMember)
            {
                memberContainer2.sprite = partyMemberSprites[0];
                hasBeenAssignedFirstMember = true;
            }
            else if (hasBeenAssignedFirstMember)
            {
                memberContainer3.sprite = partyMemberSprites[0];
            }

        }

        //checking for rouge in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 2 || PartySelectButtons.arrayClassNumbers[1] == 2)
        {
            if (!hasBeenAssignedFirstMember)
            {
                memberContainer2.sprite = partyMemberSprites[1];
                hasBeenAssignedFirstMember = true;
            }
            else if (hasBeenAssignedFirstMember)
            {
                memberContainer3.sprite = partyMemberSprites[1];
            }

        }

        //checking for swordsman in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 3 || PartySelectButtons.arrayClassNumbers[1] == 3)
        {
            if (!hasBeenAssignedFirstMember)
            {
                memberContainer2.sprite = partyMemberSprites[2];
                hasBeenAssignedFirstMember = true;
            }
            else if (hasBeenAssignedFirstMember)
            {
                memberContainer3.sprite = partyMemberSprites[2];
            }

        }

        //checking for bard in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 4 || PartySelectButtons.arrayClassNumbers[1] == 4)
        {
            if (!hasBeenAssignedFirstMember)
            {
                memberContainer2.sprite = partyMemberSprites[3];
                hasBeenAssignedFirstMember = true;
            }
            else if (hasBeenAssignedFirstMember)
            {
                memberContainer3.sprite = partyMemberSprites[3];
            }

        }

        //checking for mage in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 5 || PartySelectButtons.arrayClassNumbers[1] == 5)
        {
            if (!hasBeenAssignedFirstMember)
            {
                memberContainer2.sprite = partyMemberSprites[4];
                hasBeenAssignedFirstMember = true;
            }
            else if (hasBeenAssignedFirstMember)
            {
                memberContainer3.sprite = partyMemberSprites[4];
            }

        }
    }
}
