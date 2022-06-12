using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class CombatScript : MonoBehaviour
{
    public int baseAttack;
    public GameObject[] enemyContainer;
    int numToRemove;
    public GameObject[] heroContainer;
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

    [HideInInspector]
    public HeroHealth hH;

    public int skillNumberInUse;
    public int secondSkillNumberInUse;

    public int enemyNumberSelected;

    public bool isUsingBasicAttack;



    private void Start()
    {
        hE = FindObjectsOfType<HighlightEnemy>();
        sSelect = FindObjectOfType<SkillSelect>();
        hH = FindObjectOfType<HeroHealth>();
        
    }



    public void BasicAttack()
    {
        if(enemyNumberSelected == 1)
        {
            if (enemyContainer[0] == enabled)
            {
                enemyContainer[0].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textResponseArea.text = "Enemy 1 hit with a basic attack for " + baseAttack;
                isUsingBasicAttack = false;
                StartCoroutine(WaitForNextEnemy());
            }

        }
        if (enemyNumberSelected == 2)
        {
            if (enemyContainer[1] == enabled)
            {
                enemyContainer[1].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textResponseArea.text = "Enemy 2 hit with a basic attack for " + baseAttack;
                isUsingBasicAttack = false;
                StartCoroutine(WaitForNextEnemy());
            }
        
        }
        if(enemyNumberSelected == 3)
        {
            if (enemyContainer[2] == enabled)
            {
                enemyContainer[2].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textResponseArea.text = "Enemy 3 hit with a basic attack for " + baseAttack;
                isUsingBasicAttack = false;
                StartCoroutine(WaitForNextEnemy());
            }
        }
        if(enemyNumberSelected == 4)
        {
            if (enemyContainer[3] == enabled)
            {
                enemyContainer[3].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textResponseArea.text = "Enemy 4 hit with a basic attack for " + baseAttack;
                isUsingBasicAttack = false;
                StartCoroutine(WaitForNextEnemy());
            }
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
        HitAllEnemies(baseAttack);
        Debug.Log("Cleave Being Used");
        skillNumberInUse = 0;
        secondSkillNumberInUse = 0;
        
    }

    public void SwordDance()
    {
        if(enemyNumberSelected == 1)
        {
            if (enemyContainer[0] == enabled)
            {
                enemyContainer[0].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
                sSelect.textResponseArea.text = "Enemy 1 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
                StartCoroutine(WaitForNextEnemy());
            }
        }
        if(enemyNumberSelected == 2)
        {
            if (enemyContainer[1] == enabled)
            {
                enemyContainer[1].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
                sSelect.textResponseArea.text = "Enemy 2 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
                StartCoroutine(WaitForNextEnemy());
            }
        }

        if(enemyNumberSelected == 3)
        {
            if (enemyContainer[2] == enabled)
            {
                enemyContainer[2].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
                sSelect.textResponseArea.text = "Enemy 3 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
                StartCoroutine(WaitForNextEnemy());
            }
        }

        if(enemyNumberSelected == 4)
        {
            if (enemyContainer[3] == enabled)
            {
                enemyContainer[3].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
                sSelect.textResponseArea.text = "Enemy 4 hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
                StartCoroutine(WaitForNextEnemy());
            }
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
        GiveAllHeroesHealth(10);
        Debug.Log("Sweet Song Being Used");
        secondSkillNumberInUse = 0;
        skillNumberInUse = 0;

       
    }

    public void Ignite()
    {
        HitAllEnemies(baseAttack * 2);
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

  
     public void HitAllEnemies(int damage)
    {
        StartCoroutine(WaitForNextEnemy());
        foreach (GameObject gameObject in enemyContainer)
        {
            gameObject.GetComponent<EnemyHealth>().RemoveHealth(damage);
            sSelect.textResponseArea.text = "All enemies hit for " + damage;

        }
       
    }

    public void GiveAllHeroesHealth(int amountToGive)
    {
        StartCoroutine(WaitForNextEnemy());
        foreach (GameObject gameObject in heroContainer)
        {
            gameObject.GetComponent<HeroHealth>().GiveHealth(amountToGive);
        }
       
    }

    public void EnemyAttacking(int damageToGive, int enemyNumber)
    {
        string nameOfEnemy = "";
        if(enemyNumber == 1)
        {
            if (enemyContainer[0] == enabled)
                nameOfEnemy = enemyContainer[0].GetComponent<EnemyHealth>().nameForEnemy;
        }
        if(enemyNumber == 2)
        {
            if (enemyContainer[1] == enabled)
                nameOfEnemy = enemyContainer[1].GetComponent<EnemyHealth>().nameForEnemy;
        }
        if(enemyNumber == 3)
        {
            if (enemyContainer[2] == enabled)
                nameOfEnemy = enemyContainer[2].GetComponent<EnemyHealth>().nameForEnemy;
        }
        if(enemyNumber == 4)
        {
            if(enemyContainer[3] == enabled)
            nameOfEnemy = enemyContainer[3].GetComponent<EnemyHealth>().nameForEnemy;
        }
        if (sSelect.curEnemy != 6)
        {
            int random = UnityEngine.Random.Range(0, 2);
            sSelect.textResponseArea.text = nameOfEnemy + " is attacking  for " + damageToGive + " damage";
            hH.RemoveHealth(damageToGive);
        }

        
        StartCoroutine(WaitForNextEnemy());

       
    }

    //public static void RemoveAt<T>(ref T[] arr, int index)
    //{
    //    for (int a = index; a < arr.Length - 1; a++)
    //    {
    //        // moving elements downwards, to fill the gap at [index]
    //        arr[a] = arr[a + 1];
    //    }
    //    // finally, let's decrement Array's size by one
    //    Array.Resize(ref arr, arr.Length - 1);
    

    public void RemoveEnemyFromArray(int enemyNumberToRemove)
    {
        enemyContainer[enemyNumberToRemove].SetActive(false);
        //RemoveAt(ref enemyContainer, enemyNumberToRemove);
        ////Array.Clear(enemyContainer, enemyNumberToRemove, enemyContainer.Length);
    }

    IEnumerator WaitForNextEnemy()
    {
        yield return new WaitForSeconds(3f);
        sSelect.GoToNextCombatPhase();
        yield break;
    }

   
}
