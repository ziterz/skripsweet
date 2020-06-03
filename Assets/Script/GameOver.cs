using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{

    //public GameObject toolbar;
    public TMP_Text pretest, posttest,winnerName;

    public void OnFinish()
    {
        //toolbar.gameObject.SetActive(false);
        pretest.text = PlayerPrefs.GetInt("Pretest").ToString();
        posttest.text = PlayerPrefs.GetInt("Postest").ToString();
        winnerName.text = PlayerPrefs.GetString("Username");
    }
}
