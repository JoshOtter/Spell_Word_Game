using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bombling : MonoBehaviour
{
    public int maxHealth = 2;
    public int bomblingHealth;

    public HealthBar bomblingHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        bomblingHealth = maxHealth;
        bomblingHealthBar.SetHealth(bomblingHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (bomblingHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Tower")
        {
            Destroy(gameObject);
        }


    }
}
