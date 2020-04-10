using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrolJalan : MonoBehaviour {
    public GameObject player;

    private void OnMouseDown() {
        if(gameObject.name == "kiri") {

        }else if(gameObject.name == "kanan") {
          
        }
    }
    
    private void OnMouseUp() {
        if (gameObject.name == "kiri") {
            player.GetComponent<PlayerAct>().berhenti();
        }else if (gameObject.name == "kanan") {
            player.GetComponent<PlayerAct>().berhenti();
        }
    }

    private void OnMouseDrag() {
        if (gameObject.name == "kiri") {
            player.GetComponent<PlayerAct>().jalan_kiri();
        }else if (gameObject.name == "kanan") {
            player.GetComponent<PlayerAct>().jalan_kanan();
        }
    }
}