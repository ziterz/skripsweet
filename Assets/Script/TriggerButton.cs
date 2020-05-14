using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour {
    //public AudioSource ButtonSound;
    public GameObject player,Soal;

    private void OnMouseDrag() {
        if (gameObject.name == "next") {
             Soal.SetActive(false);
        }
    }
    
}
