using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("GamePlay");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("Menu");
    }
}
