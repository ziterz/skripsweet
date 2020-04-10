﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class JawabanRecord : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public TMP_InputField field1, field2, field3,field4,field5,field6,field7,field8,field9,field10,field11,field12;
    public AudioSource correct, incorrect;

    public void OnCek()
	{
        if(field1.text.Equals("RT089") && field2.text.Equals("RT762") && field3.text.Equals("RT512") && field4.text.Equals("Sel Strb") && field5.text.Equals("RTPJG") && field6.text.Equals("RTTWR") && field7.text.Equals("1") && field8.text.Equals("1") && field9.text.Equals("1") && field10.text.Equals("35.000") && field11.text.Equals("15.000") && field12.text.Equals("20.000"))
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