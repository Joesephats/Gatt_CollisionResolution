//////////////////////////////////////////////
//Assignment/Lab/Project: Collision Resolution
//Name: Tristin Gatt
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 03/25/2024
/////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //HUD references
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text healthText;

    //game end UI references
    [SerializeField] GameObject endPanel;
    [SerializeField] TMP_Text endPanelMessage;

    //camera reference for raycast
    [SerializeField] GameObject mainCamera;

    Player player;

    private void Awake()
    {
        //create new player variable
        player = new Player();
    }

    // Start is called before the first frame update
    void Start()
    {
        //locks cursor on level1 start
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //game end cases
        if (player.Health <= 0)
        {
            GameEnd("Game Over");
        }

        if (player.Score >= 100)
        {
            GameEnd("Victory");
        }

        //DOES NOT WORK. Raycasts to disable traps
        if (Input.GetMouseButtonDown(0))
        {
            LayerMask mask = LayerMask.GetMask("Trap");

            Debug.Log("click");
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.transform.position, Vector3.forward, out hit, 1000))
            {
                if (hit.collider.gameObject.tag == "Trap")
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("Hit Trap");
                }
                Debug.Log(hit.collider.tag);
            }
        }
    }

    //collision resolution
    private void OnTriggerEnter(Collider other)
    {
        //if collision with pickup, delete pickup object and increase score. update HUD
        if (other.gameObject.tag == "Pickup")
        {
            player.IncreaseScore();
            Destroy(other.gameObject);

            UpdateScoreUI();
        }

        //if collision with trap, damage player. update HUD
        if (other.gameObject.tag == "Trap")
        {
            player.DamagePlayer();
            UpdateHealthUI();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = $"Score: {player.Score}";
    }

    void UpdateHealthUI()
    {
        healthText.text = $"Health: {player.Health}";
    }

    //enables cursor and sets appropriate game end message
    void GameEnd(string message)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        endPanelMessage.text = message;
        endPanel.SetActive(true);
    }
}
