using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth;


    private void Update()
    {
        if(startingHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void RemoveHealth(int amount)
    {
        startingHealth -= amount;
    }
}
