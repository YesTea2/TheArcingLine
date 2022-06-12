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

    [Header("Skill Flavor Text")]
    public string[] skillFlavorText;

    [HideInInspector]
    public string partyMemberClassOne;
    public string partyMemberClasstwo;

    [HideInInspector]
    public int firstSkillBeingUsed;
    [HideInInspector]
    public int secondSkillBeingUsed;
    [HideInInspector]
    public string firstCombatSkillSelectedText;
    [HideInInspector]
    public string secondCombatSkillSelectedText;
    [HideInInspector]
    CombatScript cS;
    

    private bool hasBeenAssignedFirstMember;
    public bool enemyAttacking;

    [HideInInspector]
    public int memberAttacking;
    public int secondMemberAttacking;

    [HideInInspector]
    public bool isHunterAttacking;
    public bool isRougeAttacking;
    public bool isSwordsmanAttacking;
    public bool isBardAttacking;
    public bool isMageAttacking;

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

    [HideInInspector]
    public bool isEnemyFourAlive;
    public bool isEnemyThreeAlive;
    public bool isEnemyTwoAlive;
    public bool isEnemyOneAlive;
    public bool partyAttacking;
    public bool finalMemberHasGone;

    public int curMember;
    public int curEnemy;

    [HideInInspector]
    EnemyHealth[] eH;

    private void Awake()
    {
        cS = FindObjectOfType<CombatScript>();
    }
    private void Start()
    {
        eH = FindObjectsOfType<EnemyHealth>();
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

        isEnemyOneAlive = true;
        isEnemyTwoAlive = true;
        isEnemyThreeAlive = true;
        isEnemyFourAlive = true;
        partyAttacking = true;
        finalMemberHasGone = false;

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



        GoToNextCombatPhase();

    }
    private void Update()
    {
       
    }

    public void GoToNextCombatPhase()
    {
        StartCoroutine(CombatTime());
    }
    void FirstMemberPhase()
    {

        if (isHunterAttacking && memberAttacking == 1)
        {
            partyMemberClassOne = "Hunter";
            heroAttacking.text = "Hunters turn to attack";
            SetSkillTextOne(attackSkills[0], 1 , 0);
            SetSkillTextTwo(attackSkills[1], 1, 1);
           
        }
        else if (isRougeAttacking && memberAttacking == 2)
        {
            partyMemberClassOne = "Rouge";
            heroAttacking.text = "Rouges turn to attack";
            SetSkillTextOne(attackSkills[2], 2, 2);
            SetSkillTextTwo(attackSkills[3], 2 , 3);
            
        }
        else if (isSwordsmanAttacking && memberAttacking == 3)
        {
            partyMemberClassOne = "Swordsman";
            heroAttacking.text = "Swordsmans turn to attack";
            SetSkillTextOne(attackSkills[4], 3, 4);
            SetSkillTextTwo(attackSkills[5], 3, 5);
            
        }
        else if (isBardAttacking && memberAttacking == 4)
        {
            partyMemberClassOne = "Bard";
            heroAttacking.text = "Bards turn to attack";
            SetSkillTextOne(attackSkills[6], 4, 6);
            SetSkillTextTwo(attackSkills[7], 4, 7);
           
        }
        else if (isMageAttacking && memberAttacking == 5)
        {
            partyMemberClassOne = "Mage";
            heroAttacking.text = "Mages turn to attack";
            SetSkillTextOne(attackSkills[8], 5, 8);
            SetSkillTextTwo(attackSkills[9], 5, 9);
            
        }

    }

    void SecondMemberPhase()
    {
        if ( secondMemberAttacking == 1)
        {
            partyMemberClasstwo = "Hunter";
            heroAttacking.text = "Hunters turn to attack";
            SetSkillTextOne(attackSkills[0], 1, 0);
            SetSkillTextTwo(attackSkills[1], 1, 1);
            
        }
        if (secondMemberAttacking == 2)
        {
            partyMemberClasstwo = "Rouge";
            heroAttacking.text = "Rouges turn to attack";
            SetSkillTextOne(attackSkills[2], 2, 2);
            SetSkillTextTwo(attackSkills[3], 2, 3);
            
        }
        if ( secondMemberAttacking == 3)
        {
            partyMemberClasstwo = "Swordsman";
            heroAttacking.text = "Swordsmans turn to attack";
            SetSkillTextOne(attackSkills[4], 3, 4);
            SetSkillTextTwo(attackSkills[5], 3, 5);
           
        }
        if (secondMemberAttacking == 4)
        {
            partyMemberClasstwo = "Bard";
            heroAttacking.text = "Bards turn to attack";
            SetSkillTextOne(attackSkills[6], 4, 6);
            SetSkillTextTwo(attackSkills[7], 4, 7);
           
        }
        if (secondMemberAttacking == 5)
        {
            partyMemberClasstwo = "Mage";
            heroAttacking.text = "Mages turn to attack";
            SetSkillTextOne(attackSkills[8], 5, 8);
            SetSkillTextTwo(attackSkills[9], 5, 9);
            
        }
    }

    void ThirdMemberPhase()
    {
        heroAttacking.text = CharacterSelectButtons.playerName.ToString() + " turn to attack";
        if (CharacterSelectButtons.classSelected == 0)
        {
            SetSkillTextOne(attackSkills[4], 3, 4);
            SetSkillTextTwo(attackSkills[5], 3, 5);
        }
        if(CharacterSelectButtons.classSelected == 1)
        {
            SetSkillTextOne(attackSkills[8], 5, 8);
            SetSkillTextTwo(attackSkills[9], 5, 9);
        }
        if(CharacterSelectButtons.classSelected == 2)
        {
            SetSkillTextOne(attackSkills[6], 4, 6);
            SetSkillTextTwo(attackSkills[7], 4, 7);
        }
        if(CharacterSelectButtons.classSelected == 3)
        {
            SetSkillTextOne(attackSkills[0], 1, 0);
            SetSkillTextTwo(attackSkills[1], 1, 1);
        }
        partyAttacking = false;
        enemyAttacking = true;
       

       
    }

    void SetSkillTextOne(string textToDisplay, int skillUsed,  int numberForArray)
    {
        firstSkillBeingUsed = skillUsed;
        skillTextOne.text = textToDisplay;
        firstCombatSkillSelectedText = skillFlavorText[numberForArray];
        Debug.Log(textToDisplay + " has been clicked!");
    }

    void SetSkillTextTwo(string textToDisplay, int skillUsed, int numberForArray)
    {
        secondSkillBeingUsed = skillUsed;
        skillTextTwo.text = textToDisplay;
        secondCombatSkillSelectedText = skillFlavorText[numberForArray];
        Debug.Log(textToDisplay + " has been clicked!");
    }

    void FirstEnemyPhase()
    {
        cS.EnemyAttacking(Random.Range(1, 5), 1);
    }

    void SecondEnemyPhase()
    {
        cS.EnemyAttacking(Random.Range(1, 5), 2);
    }

    void ThirdEnemyPhase()
    {
        cS.EnemyAttacking(Random.Range(1, 5), 3);
    }

    void FourthEnemyPhase()
    {
        cS.EnemyAttacking(Random.Range(1, 5), 4);
        enemyAttacking = false;
        partyAttacking = true;
        
       
    }


    IEnumerator CombatTime()
    {
        if (partyAttacking && !enemyAttacking)
        {
            finalMemberHasGone = false;
            if (curMember == 3)
            {
                curMember = 0;
            }
            yield return new WaitForSeconds(.1f);
            curMember += 1;
            yield return new WaitForSeconds(.1f);

            if (curMember == 1)
            {
                FirstMemberPhase();
                yield break;
            }

            else if (curMember == 2)
            {
                SecondMemberPhase();
                yield break;
            }

            else if (curMember == 3)
            {
                ThirdMemberPhase();
                yield break;
            }
            
        }
        if (enemyAttacking && !partyAttacking)
        {
            finalMemberHasGone = true;
            if (curEnemy >= 4)
            {
                curEnemy = 0;
            }
            yield return new WaitForSeconds(.1f);
            curEnemy += 1;
            yield return new WaitForSeconds(.1f);

            if(curEnemy == 1 && isEnemyOneAlive)
            {
                textResponseArea.text = "Enemy 1 is attacking";
                FirstEnemyPhase();
                yield break;
            }
            else if (curEnemy == 2 && isEnemyTwoAlive)
            {
                textResponseArea.text = "Enemy 2 is attacking";
                SecondEnemyPhase();
                yield break;

            }

            else if (curEnemy == 3 && isEnemyThreeAlive)
            {
                textResponseArea.text = "Enemy 3 is attacking";
                ThirdEnemyPhase();

            }
            else if (curEnemy == 4 && isEnemyFourAlive)
            {
                textResponseArea.text = "Enemy 4 is attacking";
                curEnemy += 1;
                FourthEnemyPhase();
                yield break;

            }

            else if(curEnemy == 1 && !isEnemyOneAlive)
            {
               
                ResetCombatCheck();
                yield break;
            }
           
            else if(curEnemy == 2 && !isEnemyTwoAlive)
            {
               
                ResetCombatCheck();
                yield break;
            }
       
            else if (curEnemy == 3 && !isEnemyThreeAlive)
            {
                
                ResetCombatCheck();
                yield break;
            }
           
            else if(curEnemy == 4 && !isEnemyFourAlive)
            {
                curEnemy = 6;
                FourthEnemyPhase();
               
                yield break;

            }
        }
    }

   void ResetCombatCheck()
    {
        
        StartCoroutine(CombatTime());
    }


    

}
