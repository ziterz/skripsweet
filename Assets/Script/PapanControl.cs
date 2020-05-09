using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapanControl : MonoBehaviour {
    //public AudioSource ButtonSound;
    public GameObject player;
    public GameObject arahanlvl;
    //public GameObject cerita;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            arahanlvl.SetActive(true);
        //    cerita.SetActive(true);
        }
    }
    
    /*private void OnMouseDown() {
        if (gameObject.name == "closeinstruksi") {
            arahanlvl.SetActive(false);
        }else{
            arahanlvl.SetActive(true);
        }
    }*/
}
