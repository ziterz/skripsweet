using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterGerak : MonoBehaviour
{

    public int kecepatan;
    public int x;
    public float scaleX;
    // balik badan
    public bool balik;
    public int pindah;

    // Rigidbody2D lompat;

    // public bool tanah;
	// public LayerMask targetlayer;
	// public Transform deteksitanah;

    Animator anim;

    public bool tombolkiri, tombolkanan;
    
    void Start()
    {
        // lompat = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
        x = PlayerPrefs.GetInt("x",-13);
        transform.position = new Vector3(x, -3, -2);
        scaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Posisi: " + transform.position.x);
        if (Input.GetKey (KeyCode.D)|| (tombolkanan == true)) {
			anim.SetBool ("gerak", true);
			transform.Translate (Vector2.right * kecepatan * Time.deltaTime);
			pindah = 1;
		} else if (Input.GetKey (KeyCode.A) || (tombolkiri == true)) {
			anim.SetBool ("gerak", true);
			transform.Translate (Vector2.right * -kecepatan * Time.deltaTime);
			pindah = -1;
		}else{
            anim.SetBool ("gerak", false);
        }

        // if(Input.GetKey (KeyCode.W)){
        //     lompat.AddForce(new Vector2(0,kekuatanLompat));
        // }

        if (pindah > 0 && !balik) {
			balikbadan();
		}else if(pindah<0 && balik){
			balikbadan();
		}

    }

    void balikbadan(){
		balik = !balik;
		Vector3 karakter = transform.localScale;
		karakter.x *= -1;
		transform.localScale = karakter;
	}

    public void klikiri(){
        tombolkiri = true;
    }

    public void lepaskiri(){
        tombolkiri = false;
    }

    public void klikanan(){
        tombolkanan = true;
    }

    public void lepaskanan(){
        tombolkanan = false;
    }
}
