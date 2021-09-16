using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar towerHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        towerHealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TOWER HEALTH DROP
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bombling")
        {
            currentHealth--;
            towerHealthBar.SetHealth(currentHealth);
        }

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    //TOWER HEALTH RESTORE

}
