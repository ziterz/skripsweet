using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoal : MonoBehaviour {
    //public AudioSource ButtonSound;
    public GameObject player;
    public GameObject Soal,barang1,barang2;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            Soal.SetActive(true);
            barang2.SetActive(true);
            barang1.SetActive(false);
        }
    }
    
}
