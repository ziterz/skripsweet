using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class jawabanSelectLike : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public TMP_InputField field1, field2, field3, field4;
    public AudioSource correct, incorrect;

    public void OnCek()
	{
        if(field1.text.Equals("select") && field2.text.Equals("nama") && field3.text.Equals("where")&& field4.text.Equals("like '%a';"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else  if(field1.text.Equals("Select") && field2.text.Equals("Nama") && field3.text.Equals("Where")&& field4.text.Equals("Like '%a';"))
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