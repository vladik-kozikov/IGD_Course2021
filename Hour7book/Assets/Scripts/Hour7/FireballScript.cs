using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FireballScript : MonoBehaviour
{
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
            return playerHealth - 5;
    }

    int TakeDamageFromFireballl(int damage)
    {
        int playerHealth = 100;
            return playerHealth - damage;
    }


    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Player Health 1: " + TakeDamageFromFireball());
        //print("Player Health 2: " + TakeDamageFromFireball(25);
        print("Player Health 3: " + TakeDamageFromFireball(30,50));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
