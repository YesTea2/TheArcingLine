using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Use the Selectable class as a base class to access the IsHighlighted method
public class HighlightEnemy : Selectable, IPointerDownHandler
{
    public int enemyNumber;
    public int skillNumber;

    public bool enemyOneSelected;
    public bool enemyTwoSelected;
    public bool enemyThreeSelected;
    public bool enemyFourSelected;

    public SkillSelect sSelect;
    public CombatScript cScript;

    public static int skillBeingUsed;
    public int skillsCounter;

    private bool baseAttack;

    //Use this to check what Events are happening
    BaseEventData m_BaseEvent;

    public void Awake()
    {
        sSelect = FindObjectOfType<SkillSelect>();
        cScript = FindObjectOfType<CombatScript>();
    }
    void Update()
    {
        // Debug.Log(skillBeingUsed.ToString());
        skillsCounter = skillBeingUsed;
    }

    private bool IsHighlighted(BaseEventData m_BaseEvent)
    {
        throw new NotImplementedException();
    }

    
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
    public void OnPointerDown(PointerEventData eventData)
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
    {
       
        if(enemyNumber == 1)
        {
            cScript.enemyNumberSelected = 1;
            enemyOneSelected = true;
            enemyTwoSelected = false;
            enemyThreeSelected = false;
            enemyFourSelected = false;

            if (cScript.isUsingBasicAttack)
            {
                cScript.BasicAttack();
               
            }
            // skill set one
            if (cScript.skillNumberInUse == 1)
            {
                cScript.OnTheHunt();
            }

            if (cScript.skillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if (cScript.skillNumberInUse == 3)
            {
                cScript.Cleave();
            }


            if (cScript.skillNumberInUse == 4)
            {
                cScript.PayThePiper();
            }


            if (cScript.skillNumberInUse == 5)
            {
                cScript.FireBall();
            }

            // skill set two
            if (cScript.secondSkillNumberInUse == 1)
            {


            }

            if (cScript.secondSkillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if (cScript.secondSkillNumberInUse == 3)
            {
                cScript.SwordDance();
            }

            if (cScript.secondSkillNumberInUse == 4)
            {
                cScript.SweetSong();
            }

            if (cScript.secondSkillNumberInUse == 5)
            {
                cScript.Ignite();
            }


        }

        if (enemyNumber == 2)
        {
            cScript.enemyNumberSelected = 2;
            enemyTwoSelected = true;
            enemyOneSelected = false;
            enemyThreeSelected = false;
            enemyFourSelected = false;

            if (cScript.isUsingBasicAttack)
            {
                cScript.BasicAttack();
               
            }

            // skill set one
            if (cScript.skillNumberInUse == 1)
            {
                cScript.OnTheHunt();
            }

            if (cScript.skillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if (cScript.skillNumberInUse == 3)
            {
                cScript.Cleave();
            }


            if (cScript.skillNumberInUse == 4)
            {
                cScript.PayThePiper();
            }


            if (cScript.skillNumberInUse == 5)
            {
                cScript.FireBall();
            }

            // skill set two
            if (cScript.secondSkillNumberInUse == 1)
            {


            }

            if (cScript.secondSkillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if (cScript.secondSkillNumberInUse == 3)
            {
                cScript.SwordDance();
            }

            if (cScript.secondSkillNumberInUse == 4)
            {
                cScript.SweetSong();
            }

            if (cScript.secondSkillNumberInUse == 5)
            {
                cScript.Ignite();
            }


        }

        if (enemyNumber == 3)
        {
            cScript.enemyNumberSelected = 3;
            enemyThreeSelected = true;
            enemyOneSelected = false;
            enemyTwoSelected = false;
            enemyFourSelected = false;

            if (cScript.isUsingBasicAttack)
            {
                cScript.BasicAttack();
               
            }
            // skill set one
            if (cScript.skillNumberInUse == 1)
            {
                cScript.OnTheHunt();
            }

            if (cScript.skillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if (cScript.skillNumberInUse == 3)
            {
                cScript.Cleave();
            }


            if (cScript.skillNumberInUse == 4)
            {
                cScript.PayThePiper();
            }


            if (cScript.skillNumberInUse == 5)
            {
                cScript.FireBall();
            }

            // skill set two
            if (cScript.secondSkillNumberInUse == 1)
            {


            }

            if (cScript.secondSkillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if (cScript.secondSkillNumberInUse == 3)
            {
                cScript.SwordDance();
            }

            if (cScript.secondSkillNumberInUse == 4)
            {
                cScript.SweetSong();
            }

            if (cScript.secondSkillNumberInUse == 5)
            {
                cScript.Ignite();
            }


        }

        if (enemyNumber == 4)
        {
            cScript.enemyNumberSelected = 4;
            enemyFourSelected = true;
            enemyOneSelected = false;
            enemyTwoSelected = false;
            enemyThreeSelected = false;

            if (cScript.isUsingBasicAttack)
            {
                cScript.BasicAttack();
                
            }

            // skill set one
            if (cScript.skillNumberInUse == 1)
            {
                cScript.OnTheHunt();
            }

            if (cScript.skillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if (cScript.skillNumberInUse == 3)
            {
                cScript.Cleave();
            }


            if (cScript.skillNumberInUse == 4)
            {
                cScript.PayThePiper();
            }


            if (cScript.skillNumberInUse == 5)
            {
                cScript.FireBall();
            }

            // skill set two
            if(cScript.secondSkillNumberInUse == 1)
            {

            
            }

            if (cScript.secondSkillNumberInUse == 2)
            {
                cScript.RougeStuns();
            }

            if(cScript.secondSkillNumberInUse == 3)
            {
                cScript.SwordDance();
            }

            if(cScript.secondSkillNumberInUse == 4)
            {
                cScript.SweetSong();
            }

            if(cScript.secondSkillNumberInUse == 5)
            {
                cScript.Ignite();
            }

        }

        if(skillNumber == 1)
        {
            if(sSelect.firstSkillBeingUsed == 1)
            {
               
                cScript.skillNumberInUse = 1;
            }
          
            if (sSelect.firstSkillBeingUsed == 2)
            {
              
                cScript.skillNumberInUse = 2;
            }
          
            if (sSelect.firstSkillBeingUsed == 3)
            {
                cScript.skillNumberInUse = 3;
               
            }
          
            if (sSelect.firstSkillBeingUsed == 4)
            {
                cScript.skillNumberInUse = 4;
                
            }
           
            if (sSelect.firstSkillBeingUsed == 5)
            {
              
                cScript.skillNumberInUse = 5;
               
            }
            cScript.secondSkillNumberInUse = 0;
            cScript.isUsingBasicAttack = false;

        }

        if (skillNumber == 2)
        {
            if (sSelect.secondSkillBeingUsed == 1)
            {
                cScript.secondSkillNumberInUse = 1;
               
            }

            if (sSelect.secondSkillBeingUsed == 2)
            {

                cScript.secondSkillNumberInUse = 2;
            }

            if (sSelect.secondSkillBeingUsed == 3)
            {
                cScript.secondSkillNumberInUse = 3;
                sSelect.textResponseArea.text = "Select the enemy to hit with Sword Dance";
               
            }

            if (sSelect.secondSkillBeingUsed == 4)
            {
                cScript.secondSkillNumberInUse = 4;
               
            }

            if (sSelect.secondSkillBeingUsed == 5)
            {
                cScript.secondSkillNumberInUse = 5;
               
            }
            cScript.skillNumberInUse = 0;
            cScript.isUsingBasicAttack = false;
        }

        if(skillNumber == 3)
        {
            sSelect.textResponseArea.text = "Select the enemy you wish to attack with your weapon";
            cScript.isUsingBasicAttack = true;
            cScript.skillNumberInUse = 0;
            cScript.secondSkillNumberInUse = 0;
        }
    }
}