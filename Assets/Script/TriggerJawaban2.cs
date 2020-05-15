using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJawaban2 : MonoBehaviour {
    //public AudioSource ButtonSound;
    public GameObject player,next;

    private void OnMouseDown() {
      //  PlayerPrefs.SetInt("nilaiKuis", 0);
        if (gameObject.name == "A") {
            next.SetActive(true);
        }else if (gameObject.name == "B"){
            next.SetActive(true);
        }else if (gameObject.name == "C"){
           PlayerPrefs.SetInt("nilaiKuis", PlayerPrefs.GetInt("nilaiKuis") + 25);
        //    player.GetComponent<NilaiKuis>().OnSubmit();
            Debug.Log(PlayerPrefs.GetInt("nilaiKuis"));
            next.SetActive(true);
        }else if (gameObject.name == "D"){
            next.SetActive(true);
        }else if (gameObject.name == "E"){
            next.SetActive(true);
        }
    }
    
   
}
