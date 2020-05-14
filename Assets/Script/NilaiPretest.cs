using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NilaiPretest : MonoBehaviour
{
   /* public TMP_Text timerText;*/
    public TMP_Text nilai;
    public void OnSubmit()
    {
        PlayerPrefs.SetInt("Pretest", PlayerPrefs.GetInt("Pretest") + 10);
        Debug.Log(PlayerPrefs.GetInt("Pretest"));
    }

    public void OnFinishCorrect()
    {
       /* timerText.gameObject.SetActive(false);*/
        PlayerPrefs.SetInt("Pretest", PlayerPrefs.GetInt("Pretest") + 10);
        nilai.text = PlayerPrefs.GetInt("Pretest").ToString();
        Debug.Log(PlayerPrefs.GetInt("Pretest"));
    }

    public void OnFinishInCorrect()
    {
        /*timerText.gameObject.SetActive(false);*/
        nilai.text = PlayerPrefs.GetInt("Pretest").ToString();
        Debug.Log(PlayerPrefs.GetInt("Pretest"));
    }
}
