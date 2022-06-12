using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroHealth : MonoBehaviour
{
    public string nameForParty;
    public int startingHealth;
    private int currentHealth;
    
    public Slider healthSlider;
    public Gradient healthGradient;
    public Image fill;

    public TMP_Text textForHealth;
    public TMP_Text partyName;
    
    void Start()
    {
        currentHealth = startingHealth;
        partyName.text = CharacterSelectButtons.playerName.ToString() + "'s Traveling Party";
        SetMaxhealth(startingHealth);
    }

    private void Update()
    {
        textForHealth.text = currentHealth.ToString() + " / " + startingHealth.ToString();
    }

    private void FixedUpdate()
    {
        if (startingHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void RemoveHealth(int amount)
    {
        if (currentHealth > amount)
        {
            currentHealth -= amount;
        }
        else if (currentHealth <= amount)
        {
            currentHealth = 0;
        }
        SetHealth(currentHealth);
    }

    public void GiveHealth(int amount)
    {
        
        if(currentHealth < startingHealth && currentHealth + amount < startingHealth)
        {
            currentHealth += amount;
        }
        else if(currentHealth + amount > startingHealth)
        {
            currentHealth = startingHealth;
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
