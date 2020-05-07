using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class JawabanInsertTidak : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public TMP_InputField field1, field2, field4, field5;
    public AudioSource correct, incorrect;

    public void OnCek()
	{
        if(field1.text.Equals("insert into") && field2.text.Equals("ekstrakurikuler") && field4.text.Equals("(idEkskul, namaEkskul, hari)")&& field5.text.Equals("('EK001','Teater','Rabu');"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        } else  if(field1.text.Equals("Insert into") && field2.text.Equals("ekstrakurikuler") && field4.text.Equals("(idEkskul, namaEkskul, hari)")&& field5.text.Equals("('EK001','Teater','Rabu');"))
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