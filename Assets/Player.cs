using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
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

    public Player()
    {
        health = 100;
        score = 0;
    }

    public void DamagePlayer()
    {
        health -= 20;
        Debug.Log(health);

        if (health < 0)
        {
            health = 0;
        }
    }

    public void IncreaseScore()
    {
        score += 10;
        Debug.Log(score);
    }
}
