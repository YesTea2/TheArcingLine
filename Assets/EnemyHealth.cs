using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public string nameForEnemy;
    public int startingHealth;
    private int currentHealth;
    public int enemyNumber;
    public Slider healthSlider;
    public Gradient healthGradient;
    public Image fill;

    public TMP_Text textForHealth;
    public TMP_Text enemyName;

    [HideInInspector]
    SkillSelect sSelect;
    [HideInInspector]
    CombatScript cS;

    private void Start()
    {
        currentHealth = startingHealth;
       
        sSelect = FindObjectOfType<SkillSelect>();
        cS = FindObjectOfType<CombatScript>();
        SetMaxhealth(startingHealth);
    }

    private void Update()
    {
        nameForEnemy = enemyName.text;
        textForHealth.text = currentHealth.ToString() + " / " + startingHealth.ToString();
        if (currentHealth <= 0)
        {
            if (enemyNumber == 1)
            {
                sSelect.isEnemyOneAlive = false;
                cS.RemoveEnemyFromArray(0);
                
            }
            if(enemyNumber == 2)
            {
                cS.RemoveEnemyFromArray(1);
                sSelect.isEnemyTwoAlive = false;
                
            }
            if(enemyNumber == 3)
            {
                cS.RemoveEnemyFromArray(2);
                sSelect.isEnemyThreeAlive = false;
                
            }
            if(enemyNumber == 4)
            {
                cS.RemoveEnemyFromArray(3);
                sSelect.isEnemyFourAlive = false;
                
            }
           
        }


    }

    public void RemoveHealth(int amount)
    {
        if(currentHealth > amount)
        {
            currentHealth -= amount;
        }
        else if(currentHealth <= amount)
        {
            currentHealth = 0;
        }
        SetHealth(currentHealth);
    }

    public void SetMaxhealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
        fill.color = healthGradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;
        fill.color = healthGradient.Evaluate(healthSlider.normalizedValue);
    }
 
}
