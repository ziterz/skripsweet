using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class jawabanEntitas : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, cek;
    public GameObject item1, item2, item3,item4, target1;
    public AudioSource correct, incorrect;

    public void OnCek()
	{ 
       if(item1.transform.position == target1.transform.position )
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