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

    public Sprite[] enemyImages;
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

        if(StoryScript.choice1 == 1)
        {
            enemyContainer[0].GetComponent<Image>().sprite = enemyImages[0];
            
            enemyContainer[0].GetComponent<EnemyHealth>().enemyName.text = "Confused Pub Patron #1";
            enemyContainer[1].GetComponent<Image>().sprite = enemyImages[1];
            enemyContainer[1].GetComponent<EnemyHealth>().enemyName.text = "Confused Pub Patron #2";
            enemyContainer[2].GetComponent<Image>().sprite = enemyImages[2];
            enemyContainer[2].GetComponent<EnemyHealth>().enemyName.text = "Confused Pub Patron #3";
            enemyContainer[3].GetComponent<Image>().sprite = enemyImages[3];
            enemyContainer[3].GetComponent<EnemyHealth>().enemyName.text = "Confused Pub Patron #4";
        }
        if(StoryScript.choice2 == 1)
        {
            enemyContainer[0].GetComponent<Image>().sprite = enemyImages[4];
            enemyContainer[0].GetComponent<EnemyHealth>().enemyName.text = "Skeleton Warrior #1";
            enemyContainer[1].GetComponent<Image>().sprite = enemyImages[5];
            enemyContainer[1].GetComponent<EnemyHealth>().enemyName.text = "Skeleton Warrior #2";
            enemyContainer[2].GetComponent<Image>().sprite = enemyImages[6];
            enemyContainer[2].GetComponent<EnemyHealth>().enemyName.text = "Skeleton Warrior #3";
            enemyContainer[3].GetComponent<Image>().sprite = enemyImages[7];
            enemyContainer[3].GetComponent<EnemyHealth>().enemyName.text = "Skeleton Warrior #4";
        }
        
    }



    public void BasicAttack()
    {
        if(enemyNumberSelected == 1)
        {
            if (enemyContainer[0] == enabled)
            {
                enemyContainer[0].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textCombatResponse.text = enemyContainer[0].GetComponent<EnemyHealth>().enemyName.text + " hit with a basic attack for " + baseAttack;
                isUsingBasicAttack = false;
                StartCoroutine(WaitForNextEnemy());
            }

        }
        if (enemyNumberSelected == 2)
        {
            if (enemyContainer[1] == enabled)
            {
                enemyContainer[1].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textCombatResponse.text = enemyContainer[1].GetComponent<EnemyHealth>().enemyName.text + " hit with a basic attack for " + baseAttack;
                isUsingBasicAttack = false;
                StartCoroutine(WaitForNextEnemy());
            }
        
        }
        if(enemyNumberSelected == 3)
        {
            if (enemyContainer[2] == enabled)
            {
                enemyContainer[2].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textCombatResponse.text = enemyContainer[2].GetComponent<EnemyHealth>().enemyName.text + " hit with a basic attack for " + baseAttack;
                isUsingBasicAttack = false;
                StartCoroutine(WaitForNextEnemy());
            }
        }
        if(enemyNumberSelected == 4)
        {
            if (enemyContainer[3] == enabled)
            {
                enemyContainer[3].GetComponent<EnemyHealth>().RemoveHealth(baseAttack);
                sSelect.textCombatResponse.text = enemyContainer[3].GetComponent<EnemyHealth>().enemyName.text + " hit with a basic attack for " + baseAttack;
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
                sSelect.textCombatResponse.text = enemyContainer[0].GetComponent<EnemyHealth>().enemyName.text + " hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
                StartCoroutine(WaitForNextEnemy());
            }
        }
        if(enemyNumberSelected == 2)
        {
            if (enemyContainer[1] == enabled)
            {
                enemyContainer[1].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
                sSelect.textCombatResponse.text = enemyContainer[1].GetComponent<EnemyHealth>().enemyName.text + " hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
                StartCoroutine(WaitForNextEnemy());
            }
        }

        if(enemyNumberSelected == 3)
        {
            if (enemyContainer[2] == enabled)
            {
                enemyContainer[2].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
                sSelect.textCombatResponse.text = enemyContainer[2].GetComponent<EnemyHealth>().enemyName.text + " hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
                StartCoroutine(WaitForNextEnemy());
            }
        }

        if(enemyNumberSelected == 4)
        {
            if (enemyContainer[3] == enabled)
            {
                enemyContainer[3].GetComponent<EnemyHealth>().RemoveHealth(baseAttack * 3);
                sSelect.textCombatResponse.text = enemyContainer[3].GetComponent<EnemyHealth>().enemyName.text + " hit with Sword Dance for " + baseAttack * 3 + " CRITICAL HIT!!";
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
            sSelect.textCombatResponse.text = "All enemies hit for " + damage;

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
        
        yield return new WaitForSeconds(.1f);
        yield return new WaitForSeconds(.1f);
        sSelect.GoToNextCombatPhase();
        yield return new WaitForSeconds(1f);
        sSelect.textCombatResponse.text = "";
        sSelect.textResponseArea.text = "";
        yield break;
    }

   
}
