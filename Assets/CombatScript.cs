using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CombatScript : MonoBehaviour
{
    public int baseAttack;
    public GameObject[] enemyContainer;
    public int turnsToWait;
    public int bigAttackDamage;
    public int turn;
    public int[] hitPoints = new int[2];
    public int[] enemyHitPoints = new int[3];

    private int boostedHealthLeft;

    public Image[] enemyImages;
    public Image[] partyImages;

    [HideInInspector]
    public HighlightEnemy[] hE;

    [HideInInspector]
    public SkillSelect sSelect;

    public int skillNumberInUse;
    public int secondSkillNumberInUse;

    public int enemyNumberSelected;

    public bool isUsingBasicAttack;



    private void Start()
    {
        hE = FindObjectsOfType<HighlightEnemy>();
        sSelect = FindObjectOfType<SkillSelect>();
    }

    public void BasicAttack()
    {
        if(enemyNumberSelected == 1)
        {
            enemyContainer[0].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
            sSelect.textResponseArea.text = "Enemy 1 hit with a basic attack for " + baseAttack;
            isUsingBasicAttack = false;

        }
        if(enemyNumberSelected == 2)
        {
            enemyContainer[1].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
            sSelect.textResponseArea.text = "Enemy 2 hit with a basic attack for " + baseAttack;
            isUsingBasicAttack = false;
        }
        if(enemyNumberSelected == 3)
        {
            enemyContainer[2].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
            sSelect.textResponseArea.text = "Enemy 3 hit with a basic attack for " + baseAttack;
            isUsingBasicAttack = false;
        }
        if(enemyNumberSelected == 4)
        {
            enemyContainer[3].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
            sSelect.textResponseArea.text = "Enemy 4 hit with a basic attack for " + baseAttack;
            isUsingBasicAttack = false;
        }
    }
    public void OnTheHunt()
    {
        Debug.Log("On The Hunt Being Used");
        skillNumberInUse = 0;
        secondSkillNumberInUse = 0;
    }
    public void RougeStuns()
    {
        Debug.Log("No Rouges In Game");
        secondSkillNumberInUse = 0;
        skillNumberInUse = 0;
    }
    public void Cleave()
    {
        Debug.Log("Cleave Being Used");
        skillNumberInUse = 0;
        secondSkillNumberInUse = 0;
    }

    public void SwordDance()
    {
        if(enemyNumberSelected == 1)
        {
            enemyContainer[0].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
            sSelect.textResponseArea.text = "Enemy 1 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
        }
        if(enemyNumberSelected == 2)
        {
            enemyContainer[1].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
            sSelect.textResponseArea.text = "Enemy 2 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
        }

        if(enemyNumberSelected == 3)
        {
            enemyContainer[2].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
            sSelect.textResponseArea.text = "Enemy 3 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
        }

        if(enemyNumberSelected == 4)
        {
            enemyContainer[3].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
            sSelect.textResponseArea.text = "Enemy 4 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
        }
        
        secondSkillNumberInUse = 0;
        skillNumberInUse = 0;
       
    }

    public void PayThePiper()
    {
        Debug.Log("Pay The Piper Being Used");
        skillNumberInUse = 0;
        secondSkillNumberInUse = 0;
    }
    public void SweetSong()
    {
        Debug.Log("Sweet Song Being Used");
        secondSkillNumberInUse = 0;
        skillNumberInUse = 0;
    }

    public void Ignite()
    {
        Debug.Log("Ignite Being Used");
        skillNumberInUse = 0;
        secondSkillNumberInUse = 0;
    }

    public void FireBall()
    {
        Debug.Log("Fireball Being Used");
        secondSkillNumberInUse = 0;
        skillNumberInUse = 0;
    }

  
  

   
}
