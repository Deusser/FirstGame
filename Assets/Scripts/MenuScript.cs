using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject MainScreen;
    [SerializeField] private GameObject LevelMenu;
    private GameObject Currentscreen;

    void Start()
    {
        MainScreen.SetActive(true);
        Currentscreen = MainScreen;
    }

    public void ChangeGame(GameObject state)
    {
        if (Currentscreen != null)
        {
            Currentscreen.SetActive(false);
            state.SetActive(true);
            Currentscreen = state;
        }

    }

    public void Exit()
    {
        Application.Quit();
    }
}
