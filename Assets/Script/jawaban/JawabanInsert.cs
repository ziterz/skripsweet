using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class JawabanInsert : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public TMP_InputField field1, field2, field3, field4;
    public AudioSource correct, incorrect;

    public void OnCek()
	{
        if(field1.text.Equals("insert into") && field2.text.Equals("guru") && field3.text.Equals("values")&& field4.text.Equals("('DS976','herni rosiany','sarijadi baru');"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        } else  if(field1.text.Equals("Insert into") && field2.text.Equals("Guru") && field3.text.Equals("Values")&& field4.text.Equals("('DS976','herni rosiany','sarijadi baru'');"))
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