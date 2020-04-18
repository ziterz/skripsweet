using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class jawabanEntitasTutorial : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public TMP_InputField field1, field2, field3;
    public AudioSource correct, incorrect;

    public void OnCek()
	{
        if(field1.text.Equals("siswa") && field2.text.Equals("guru") && field3.text.Equals("ekstrakurikuler"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else if(field1.text.Equals("siswa") && field2.text.Equals("ekstrakurikuler") && field3.text.Equals("guru"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else if(field1.text.Equals("guru") && field2.text.Equals("siswa") && field3.text.Equals("ekstrakurikuler"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else if(field1.text.Equals("guru") && field2.text.Equals("ekstrakurikuler") && field3.text.Equals("siswa"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else if(field1.text.Equals("ekstrakurikuler") && field2.text.Equals("siswa") && field3.text.Equals("guru"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else if(field1.text.Equals("ekstrakurikuler") && field2.text.Equals("guru") && field3.text.Equals("siswa"))
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