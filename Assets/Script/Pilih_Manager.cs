using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pilih_Manager : MonoBehaviour {
    public GameObject saladah, saladahX ,saladahcek, lemon, lemonX ,lemoncek, apel, apelX ,apelcek, selai, selaiX ,selaicek, roti, rotiX ,roticek;

    public GameObject roti2, roti2X ,roti2cek, susu, susuX ,susucek, jus, jusX ,juscek, cola, colaX ,colacek, coklat, coklatX ,coklatcek, hotdog, hotdogX ,hotdogcek, cake, cakeX ,cakecek;

    public GameObject kasir;
    public int item;

    Vector2 saladahInitialPos,lemonInitialPos,apelInitialPos,selaiInitialPos,rotiInitialPos,roti2InitialPos;
    Vector2 susuInitialPos,jusInitialPos,colaInitialPos,coklatInitialPos,hotdogInitialPos,cakeInitialPos;

    // Start is called before the first frame update
    void Start() {
        PlayerPrefs.SetInt("ceklisitem", 0);
        saladahInitialPos = saladah.transform.position;
        lemonInitialPos = lemon.transform.position;
        apelInitialPos = apel.transform.position;
        selaiInitialPos = selai.transform.position;
        rotiInitialPos = roti.transform.position;
        roti2InitialPos = roti2.transform.position;
        susuInitialPos= susu.transform.position;
        jusInitialPos= jus.transform.position;
        colaInitialPos= cola.transform.position;
        coklatInitialPos= coklat.transform.position;
        hotdogInitialPos= hotdog.transform.position;
        cakeInitialPos= cake.transform.position;
    }

    public void klikSaladah() {
        saladah.SetActive(false);
        saladah.transform.position = Input.mousePosition;
        saladahX.SetActive(true);
        saladahcek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void kliklemon() {
        lemon.SetActive(false);
        lemon.transform.position = Input.mousePosition;
        lemonX.SetActive(true);
        lemoncek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikapel() {
        apel.SetActive(false);
        apel.transform.position = Input.mousePosition;
        apelX.SetActive(true);
        apelcek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikselai() {
        selai.SetActive(false);
        selai.transform.position = Input.mousePosition;
        selaiX.SetActive(true);
        selaicek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikroti() {
        roti.SetActive(false);
        roti.transform.position = Input.mousePosition;
        rotiX.SetActive(true);
        roticek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikroti2() {
        roti2.SetActive(false);
        roti2.transform.position = Input.mousePosition;
        roti2X.SetActive(true);
        roti2cek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void kliksusu() {
        susu.SetActive(false);
        susu.transform.position = Input.mousePosition;
        susuX.SetActive(true);
        susucek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikjus() {
        jus.SetActive(false);
        jus.transform.position = Input.mousePosition;
        jusX.SetActive(true);
        juscek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikcola() {
        cola.SetActive(false);
        cola.transform.position = Input.mousePosition;
        colaX.SetActive(true);
        colacek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikcoklat() {
        coklat.SetActive(false);
        coklat.transform.position = Input.mousePosition;
        coklatX.SetActive(true);
        coklatcek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikhotdog() {
        hotdog.SetActive(false);
        hotdog.transform.position = Input.mousePosition;
        hotdogX.SetActive(true);
        hotdogcek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

    public void klikcake() {
        cake.SetActive(false);
        cake.transform.position = Input.mousePosition;
        cakeX.SetActive(true);
        cakecek.SetActive(true);
        PlayerPrefs.SetInt("ceklisitem", PlayerPrefs.GetInt("ceklisitem") + 1);
        Debug.Log(PlayerPrefs.GetInt("ceklisitem"));
        if(PlayerPrefs.GetInt("ceklisitem") == 12){
            kasir.SetActive(true);
        }
        /*score.text = PlayerPrefs.GetInt("skor").ToString();*/
    }

}