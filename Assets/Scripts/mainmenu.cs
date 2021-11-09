using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
    public void Start()
    {
       // SceneManager.LoadScene("Game");
    }


}
