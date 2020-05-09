using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMainMenu : MonoBehaviour {
    public string levelName;
    
    void Start()
    {
        PlayerPrefs.SetInt("mainLevel", 0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Player") {
            if (PlayerPrefs.GetInt("mainLevel") == 0 && string.Equals(levelName, "KasusLevel1"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            } else if (PlayerPrefs.GetInt("mainLevel") == 1 && string.Equals(levelName, "KasusLevel2"))

            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }
            else if (PlayerPrefs.GetInt("mainLevel") == 2 && string.Equals(levelName, "KasusLevel3"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }else if (PlayerPrefs.GetInt("mainLevel") == 3 && string.Equals(levelName, "KasusLevel4"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }
            else if (PlayerPrefs.GetInt("mainLevel") == 4 && string.Equals(levelName, "KasusSkorAkhir"))
            {
                SceneManager.LoadScene(levelName);
                PlayerPrefs.SetInt("mainLevel", PlayerPrefs.GetInt("mainLevel") + 1);
            }else if (PlayerPrefs.GetInt("mainLevel") == 5 && string.Equals(levelName, "KasusPostest"))
            {
                SceneManager.LoadScene(levelName);
            }
        }
    }
}
