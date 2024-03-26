//////////////////////////////////////////////
//Assignment/Lab/Project: Collision Resolution
//Name: Tristin Gatt
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 03/25/2024
/////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    //health and score variables
    int health;
    int score;

    public int Health
    {
        get { return health; }
    }
    public int Score
    {
        get { return score; }
    }

    //constructs player with max hp and zero score
    public Player()
    {
        health = 100;
        score = 0;
    }

    //deals 20 damage to player. prevents health from falling below 0
    public void DamagePlayer()
    {
        health -= 20;
        Debug.Log(health);

        if (health < 0)
        {
            health = 0;
        }
    }

    //increases score by 10
    public void IncreaseScore()
    {
        score += 10;
        Debug.Log(score);
    }
}
