using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveNextLevel : MonoBehaviour
{
    public int nextScene;

    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void NextLevel()
    {
        //Move to Next Level
        SceneManager.LoadScene(nextScene);

        if(nextScene > PlayerPrefs.GetInt("UnlockedLevel"))
        {
            PlayerPrefs.SetInt("UnlockedLevel", nextScene);
            PlayerPrefs.Save();
        }
    }
}
