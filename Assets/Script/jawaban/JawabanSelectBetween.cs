using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class JawabanSelectBetween : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public TMP_InputField field1, field2, field3, field4;
    public AudioSource correct, incorrect;

    public void OnCek()
	{
        if(field1.text.Equals("barang") && field2.text.Equals("harga") && field3.text.Equals("between")&& field4.text.Equals("10000 and 35000;"))
        {
          /*  correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            lanjutkan.SetActive(true);
        }else  if(field1.text.Equals("Barang") && field2.text.Equals("Harga") && field3.text.Equals("Between")&& field4.text.Equals("10000 and 35000;"))
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