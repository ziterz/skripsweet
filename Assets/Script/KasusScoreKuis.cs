using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KasusScoreKuis : MonoBehaviour
{
    public TMP_Text nilai;

    // Update is called once per frame
    void Update()
    {
        nilai.text = PlayerPrefs.GetInt("nilaiKuis").ToString();
    }
}
