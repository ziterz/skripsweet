using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NilaiKuis : MonoBehaviour
{
   /* public TMP_Text timerText;*/
    public TMP_Text nilai;
    public AudioSource correct, incorrect;
    public void OnSubmit()
    {
        PlayerPrefs.SetInt("nilaiKuis", PlayerPrefs.GetInt("nilaiKuis") + 25);
        Debug.Log(PlayerPrefs.GetInt("nilaiKuis"));
    }

    public void OnFinishCorrect()
    {
       /* timerText.gameObject.SetActive(false);*/
        PlayerPrefs.SetInt("nilaiKuis", PlayerPrefs.GetInt("nilaiKuis") + 10);
        nilai.text = PlayerPrefs.GetInt("nilaiKuis").ToString();
        Debug.Log(PlayerPrefs.GetInt("nilaiKuis"));
    }

    public void OnFinishInCorrect()
    {
        /*timerText.gameObject.SetActive(false);*/
        nilai.text = PlayerPrefs.GetInt("nilaiKuis").ToString();
        Debug.Log(PlayerPrefs.GetInt("nilaiKuis"));
    }
}
