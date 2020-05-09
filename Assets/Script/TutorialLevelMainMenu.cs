using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialLevelMainMenu : MonoBehaviour {
    public string levelName;
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            if (PlayerPrefs.GetInt("mainLevel") == 0 && string.Equals(levelName, "TutorialLevel1"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            } else if (PlayerPrefs.GetInt("mainLevel") == 1 && string.Equals(levelName, "TutorialLevel2"))

            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }
            else if (PlayerPrefs.GetInt("mainLevel") == 2 && string.Equals(levelName, "TutorialLevel3"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }else if (PlayerPrefs.GetInt("mainLevel") == 3 && string.Equals(levelName, "TutorialLevel4"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }
            else if (PlayerPrefs.GetInt("mainLevel") == 4 && string.Equals(levelName, "TutorialskorAkhir"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }else if (PlayerPrefs.GetInt("mainLevel") == 5 && string.Equals(levelName, "TutorialPostest"))
            {
                SceneManager.LoadScene(levelName);
            }
        }
    }
}
