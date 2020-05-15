using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJawaban : MonoBehaviour {
    //public AudioSource ButtonSound;
    public GameObject player,next;

    private void OnMouseDown() {
        PlayerPrefs.SetInt("nilaiKuis", 0);
        if (gameObject.name == "A") {
            PlayerPrefs.SetInt("nilaiKuis", PlayerPrefs.GetInt("nilaiKuis") + 25);
          //  player.GetComponent<NilaiKuis>().OnSubmit();
            next.SetActive(true);
            Debug.Log(PlayerPrefs.GetInt("nilaiKuis"));
        }else if (gameObject.name == "B"){
            next.SetActive(true);
        }else if (gameObject.name == "C"){
            next.SetActive(true);
        }else if (gameObject.name == "D"){
            next.SetActive(true);
        }else if (gameObject.name == "E"){
            next.SetActive(true);
        }
    }
    
   
}
