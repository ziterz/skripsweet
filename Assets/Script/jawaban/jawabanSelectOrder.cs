﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class jawabanSelectOrder : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public TMP_InputField field1, field2, field3, field4, field5;
    public AudioSource correct, incorrect;

    public void OnCek()
	{
        if(field1.text.Equals("select") && field2.text.Equals("namaBarang") && field3.text.Equals("order by")&& field4.text.Equals("hargaBarang") && field5.text.Equals("asc;"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else  if(field1.text.Equals("Select") && field2.text.Equals("namaBarang") && field3.text.Equals("Order by")&& field4.text.Equals("hargaBarang") && field5.text.Equals("Asc;"))
        {
          /*  correct.Play(0);*/
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