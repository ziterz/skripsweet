﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class JawabanRelasi : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public GameObject item1, item2, item3, item4, item5, item6, target1, target2, target3;
    public AudioSource correct, incorrect;

    public void OnCek()
	{ 
       if(item1.transform.position == target1.transform.position && item2.transform.position == target2.transform.position &&  item3.transform.position == target3.transform.position)
        {
            /*correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }
        else
        {
            /*incorrect.Play(0);*/
            actionSalah();
        }
    }

    void actionBenar()
	{
		benar.gameObject.SetActive(true);
		salah.gameObject.SetActive(false);
	}

	void actionSalah()
	{
		salah.gameObject.SetActive(true);
		benar.gameObject.SetActive(false);
	}
}