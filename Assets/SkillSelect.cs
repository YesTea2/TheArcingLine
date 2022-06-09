using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SkillSelect : MonoBehaviour
{
    public int[] skills = new int[8];

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

    [Header("Skill Refs")]
    public string[] attackSkills;
    public TextMeshProUGUI skillTextOne;
    public TextMeshProUGUI skillTextTwo;

    [Header("Text Responses")]
    public TextMeshProUGUI textResponseArea;
    public TextMeshProUGUI heroAttacking;

    [HideInInspector]
    public int firstSkillBeingUsed;
    [HideInInspector]
    public int secondSkillBeingUsed;

    private bool hasBeenAssignedFirstMember;

    private int memberAttacking;
    private int secondMemberAttacking;


    private bool isHunterAttacking;
    private bool isRougeAttacking;
    private bool isSwordsmanAttacking;
    private bool isBardAttacking;
    private bool isMageAttacking;

    private bool isHunterAttackingSecond;
    private bool isRougeAttackingSecond;
    private bool isSwordsmanAttackingSecond;
    private bool isBardAttackingSecond;
    private bool isMageAttackingSecond;

    private bool cleaveInUse;
    private bool swordDanceInUse;
    private bool fireballInUse;
    private bool igniteInUse;
    private bool huntInUse;
    private bool eyePokeInUse;
    private bool surpiseKickInUse;
    private bool piperInUse;
    private bool sweetSongInUse;

    private int curMember;

    private void Start()
    {
        headImage.sprite = headImages[CharacterSelectButtons.headSelected];
        bodyImage.sprite = bodyImages[CharacterSelectButtons.bodySelected];
        legImage.sprite = legImages[CharacterSelectButtons.legSelected];
        weaponImage.sprite = weaponImages[CharacterSelectButtons.classSelected];
        capeImage.sprite = capeImages[CharacterSelectButtons.capeSelected];

        //checking for hunter in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 1)
        {

            memberContainer2.sprite = partyMemberSprites[0];
            hasBeenAssignedFirstMember = true;
            isHunterAttacking = true;
            isRougeAttacking = false;
            isSwordsmanAttacking = false;
            isBardAttacking = false;
            isMageAttacking = false;
            memberAttacking = 1;
        }
            if (PartySelectButtons.arrayClassNumbers[1] == 1)
            {
                memberContainer3.sprite = partyMemberSprites[0];
                isHunterAttackingSecond = true;
                isRougeAttackingSecond = false;
                isSwordsmanAttackingSecond = false;
                isBardAttackingSecond = false;
                isMageAttackingSecond = false;
                secondMemberAttacking = 1;
            }

        

        //checking for rouge in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 2)
        {
          
                memberContainer2.sprite = partyMemberSprites[1];
                hasBeenAssignedFirstMember = true;
                isRougeAttacking = true;
                isHunterAttacking = false;
                isSwordsmanAttacking = false;
                isBardAttacking = false;
                isMageAttacking = false;
                memberAttacking = 2;
            }
            if (PartySelectButtons.arrayClassNumbers[1] == 2)
            {
                memberContainer3.sprite = partyMemberSprites[1];
                isRougeAttackingSecond = true;
                isHunterAttackingSecond = false;
                isSwordsmanAttackingSecond = false;
                isBardAttackingSecond = false;
                isMageAttackingSecond = false;
                secondMemberAttacking = 2;
            }

        

        //checking for swordsman in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 3)
        {
           memberContainer2.sprite = partyMemberSprites[2];
                hasBeenAssignedFirstMember = true;
                isSwordsmanAttacking = true;
                isHunterAttacking = false;
                isRougeAttacking = false;
                isBardAttacking = false;
                isMageAttacking = false;
                memberAttacking = 3;
            }
           if (PartySelectButtons.arrayClassNumbers[1] == 3)
            {
                memberContainer3.sprite = partyMemberSprites[2];
                isSwordsmanAttackingSecond = true;
                isHunterAttackingSecond = false;
                isRougeAttackingSecond = false;
                isBardAttackingSecond = false;
                isMageAttackingSecond = false;
                secondMemberAttacking = 3;
            }

        

        //checking for bard in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 4)
        {
           
                memberContainer2.sprite = partyMemberSprites[3];
                hasBeenAssignedFirstMember = true;
                isBardAttacking = true;
                isHunterAttacking = false;
                isRougeAttacking = false;
                isSwordsmanAttacking = false;
                isMageAttacking = false;
                memberAttacking = 4;
            }
           if (PartySelectButtons.arrayClassNumbers[1] == 4)
            {
                memberContainer3.sprite = partyMemberSprites[3];
                isBardAttackingSecond = true;
                isHunterAttackingSecond = false;
                isRougeAttackingSecond = false;
                isSwordsmanAttackingSecond = false;
                isMageAttackingSecond = false;
               
         
                secondMemberAttacking = 4;
            }

        

        //checking for mage in array from party selection
        if (PartySelectButtons.arrayClassNumbers[0] == 5)
        {
          
                memberContainer2.sprite = partyMemberSprites[4];
                hasBeenAssignedFirstMember = true;
                isMageAttacking = true;
                isHunterAttacking = false;
                isRougeAttacking = false;
                isSwordsmanAttacking = false;
                isBardAttacking = false;
                memberAttacking = 5;
            }
           if (PartySelectButtons.arrayClassNumbers[1] == 5)
            {
                memberContainer3.sprite = partyMemberSprites[4];
                isMageAttackingSecond = true;
                isHunterAttackingSecond = false;
                isRougeAttackingSecond = false;
                isSwordsmanAttackingSecond = false;
                isBardAttackingSecond = false;
                secondMemberAttacking = 5;

            }

        
    
    StartCoroutine(CombatTime());

    }
    private void Update()
    {
       
    }

    void FirstMemberPhase()
    {

        if (isHunterAttacking && memberAttacking == 1)
        {
            heroAttacking.text = "Hunters turn to attack";
            SetSkillTextOne(attackSkills[0], 1);
            SetSkillTextTwo(attackSkills[1], 1);
        }
        else if (isRougeAttacking && memberAttacking == 2)
        {
            heroAttacking.text = "Rouges turn to attack";
            SetSkillTextOne(attackSkills[2], 2);
            SetSkillTextTwo(attackSkills[3], 2);
        }
        else if (isSwordsmanAttacking && memberAttacking == 3)
        {
            heroAttacking.text = "Swordsmans turn to attack";
            SetSkillTextOne(attackSkills[4], 3);
            SetSkillTextTwo(attackSkills[5], 3);
        }
        else if (isBardAttacking && memberAttacking == 4)
        {
            heroAttacking.text = "Bards turn to attack";
            SetSkillTextOne(attackSkills[6], 4);
            SetSkillTextTwo(attackSkills[7], 4);
        }
        else if (isMageAttacking && memberAttacking == 5)
        {
            heroAttacking.text = "Mages turn to attack";
            SetSkillTextOne(attackSkills[8], 5);
            SetSkillTextTwo(attackSkills[9], 5);
        }

    }

    void SecondMemberPhase()
    {
        if (isHunterAttackingSecond)
        {

        }
        if (isRougeAttackingSecond)
        {

        }
        if (isSwordsmanAttackingSecond)
        {

        }
        if (isBardAttackingSecond)
        {

        }
        if (isMageAttackingSecond)
        {

        }
    }

    void ThirdMemberPhase()
    {

    }

    void SetSkillTextOne(string textToDisplay, int skillUsed)
    {
        firstSkillBeingUsed = skillUsed;
        skillTextOne.text = textToDisplay;
        Debug.Log(textToDisplay + " has been clicked!");
    }

    void SetSkillTextTwo(string textToDisplay, int skillUsed)
    {
        secondSkillBeingUsed = skillUsed;
        skillTextTwo.text = textToDisplay;
        Debug.Log(textToDisplay + " has been clicked!");
    }

 
    IEnumerator CombatTime()
    {
        if(curMember == 3)
        {
            curMember = 0;
        }
        yield return new WaitForSeconds(.1f);
        curMember += 1;
        yield return new WaitForSeconds(.1f);

        if(curMember == 1)
        {
            FirstMemberPhase();
        }

        if(curMember == 2)
        {
            SecondMemberPhase();
        }

        if(curMember == 3)
        {
            ThirdMemberPhase();
        }
    }


    

}
