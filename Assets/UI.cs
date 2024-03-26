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
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //enable cursor when menu scene starts
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    //button methods
    public void PlayButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
