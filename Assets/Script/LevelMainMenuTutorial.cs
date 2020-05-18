using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMainMenuTutorial : MonoBehaviour {
    public string levelName;
    
    void Start()
    {
        //PlayerPrefs.SetInt("mainLevel", 0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Player") {
            if (/*PlayerPrefs.GetInt("mainLevel") == 0 &&*/ string.Equals(levelName, "TutorialLevel1"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            } else if (/*PlayerPrefs.GetInt("mainLevel") == 1 &&*/ string.Equals(levelName, "TutorialLevel2"))

            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }
            else if (/*PlayerPrefs.GetInt("mainLevel") == 2 &&*/ string.Equals(levelName, "TutorialLevel3"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }
            else if (/*PlayerPrefs.GetInt("mainLevel") == 4 &&*/ string.Equals(levelName, "TutorialSkorAkhir"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }else if (/*PlayerPrefs.GetInt("mainLevel") == 5 &&*/ string.Equals(levelName, "TutorialPostest"))
            {
                SceneManager.LoadScene(levelName);
            }
        }
    }
}
