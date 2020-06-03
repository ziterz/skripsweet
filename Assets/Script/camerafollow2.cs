using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class camerafollow2 : MonoBehaviour {
    public GameObject player;
    public float jarak;

    public TMP_Text nilaiKuis;
    
    // Update is called once per frame
    void Update() {
        Vector3 pos = new Vector3(player.transform.localPosition.x + (player.transform.localScale.x * jarak), 0, -10f);
        transform.localPosition = Vector3.Slerp(transform.localPosition, pos, 0.03f);
       // PlayerPrefs.SetInt("nilaiKuis", 0);
        nilaiKuis.text = PlayerPrefs.GetInt("nilaiKuis").ToString();
    }
}
