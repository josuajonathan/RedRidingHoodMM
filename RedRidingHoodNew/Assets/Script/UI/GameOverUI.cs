using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public GameObject UIGameOver;

    public void setGameOverUI (bool set)
    {
        UIGameOver.SetActive(set);
    }
}
