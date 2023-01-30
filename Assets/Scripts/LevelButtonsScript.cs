using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonsScript : MonoBehaviour
{
    public int Level;
    public void LevelChanger()
    {
        SceneManager.LoadScene(Level);
    }
}
