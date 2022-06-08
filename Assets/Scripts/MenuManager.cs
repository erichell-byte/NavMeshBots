using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneTransition.SwitchToScene(2);
        }
    }

    public void GoToGame()
    {
        SceneTransition.SwitchToScene(0);
    }
}
