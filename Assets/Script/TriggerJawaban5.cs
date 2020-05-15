using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerJawaban5 : MonoBehaviour {
    //public AudioSource ButtonSound;
    public GameObject player;
    public string levelName;

    private void OnMouseDown() {
        if (gameObject.name == "A") {
           // next.SetActive(true);
            SceneManager.LoadScene(levelName);
        }else if (gameObject.name == "B"){
           // next.SetActive(true);
            SceneManager.LoadScene(levelName);
        }else if (gameObject.name == "C"){
           // next.SetActive(true);
            SceneManager.LoadScene(levelName);
        }else if (gameObject.name == "D"){
           // next.SetActive(true);
            SceneManager.LoadScene(levelName);
        }else if (gameObject.name == "E"){
            PlayerPrefs.SetInt("nilaiKuis", PlayerPrefs.GetInt("nilaiKuis") + 25);
            Debug.Log(PlayerPrefs.GetInt("nilaiKuis"));
            SceneManager.LoadScene(levelName);
          //  next.SetActive(true);
        }
    }
    
   
}
