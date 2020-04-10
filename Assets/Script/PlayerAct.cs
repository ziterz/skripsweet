using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAct : MonoBehaviour {
    public float kecepatan, scaleX;

    public int x;
    
    // Start is called before the first frame update
    void Start() {
        x = PlayerPrefs.GetInt("x");
        transform.position = new Vector3(x, -3, -2);

        scaleX = transform.localScale.x;
    }

    public void jalan_kiri() {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName ("New State")) {
            GetComponent<Animator>().SetTrigger("Jalan");
        }
        transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.left * kecepatan * Time.fixedDeltaTime, Space.Self);
    }

    public void jalan_kanan() {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("New State")) {
            GetComponent<Animator>().SetTrigger("Jalan");
        }
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right * kecepatan * Time.fixedDeltaTime, Space.Self);
    }

    public void berhenti() {
        GetComponent<Animator>().SetTrigger("Stop");
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("Posisi: " + transform.position.x);
        if(Input.GetKey(KeyCode.LeftArrow)) {
            jalan_kiri();
        }else if (Input.GetKey(KeyCode.RightArrow)) {
            jalan_kanan();
        }

        if(Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
            berhenti();
        }
    }
}
