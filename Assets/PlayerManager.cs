using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Player player;

    private void Awake()
    {
        player = new Player();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.Health <= 0)
        {
            //Do Game Over
        }

        if (player.Score <= 100)
        {
            //Do Win
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            player.IncreaseScore();
        }

        if (other.gameObject.tag == "Trap")
        {
            player.DamagePlayer();
        }
    }
}
