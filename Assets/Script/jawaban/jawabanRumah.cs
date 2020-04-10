using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
 
public class jawabanRumah : MonoBehaviour
{
    public GameObject benar, salah, lanjutkan, lanjutkan2, lanjutkan3, lanjutkan4,lanjutkan5, cek,cek2,cek3,cek4,cek5;
    public GameObject item1, item2, item3, item4, item5, item6, target1, target2, target3, target4;
    public GameObject putih1,putih2,putih3,putih4;
    public GameObject juduloker1,juduloker2,juduloker3,juduloker4,juduloker5;
    public AudioSource correct, incorrect;

    public void OnCek()
	{ 
       if(item1.transform.position == target1.transform.position )
       {
            /*correct.Play(0);*/
            actionBenar();
            cek.SetActive(false);
            item1.SetActive(false);
            putih1.SetActive(false);
            juduloker1.SetActive(true);
            target1.SetActive(true);
            lanjutkan.SetActive(true);
        }
        else
        {
            /*incorrect.Play(0);*/
            actionSalah();
        }
    }

    public void OnCek2()
	{ 
       if(item2.transform.position == target2.transform.position )
        {
            /*correct.Play(0);*/
            actionBenar();
            cek2.SetActive(false);
            item2.SetActive(false);
            putih2.SetActive(false);
            target2.SetActive(true);
            juduloker2.SetActive(true);
            lanjutkan2.SetActive(true);
        }
        else
        {
            /*incorrect.Play(0);*/
            actionSalah();
        }
    }

     public void OnCek3()
	{ 
       if(item3.transform.position == target3.transform.position )
        {
            /*correct.Play(0);*/
            actionBenar();
            
            cek3.SetActive(false);
             item3.SetActive(false);
             putih3.SetActive(false);
            target3.SetActive(true);
            juduloker3.SetActive(true);
            lanjutkan3.SetActive(true);
        }
        else
        {
            /*incorrect.Play(0);*/
            actionSalah();
        }
    }

     public void OnCek4()
	{ 
       if(item4.transform.position == target4.transform.position )
        {
            /*correct.Play(0);*/
            actionBenar();
            cek4.SetActive(false);
            item4.SetActive(false);
            putih4.SetActive(false);
            target4.SetActive(true);
            juduloker4.SetActive(true);
            lanjutkan4.SetActive(true);
        }
        else
        {
            /*incorrect.Play(0);*/
            actionSalah();
        }
    }
  public void OnCek5()
	{ 
       if(item5.transform.position == target3.transform.position )
        {
            /*correct.Play(0);*/
            actionBenar();
            cek5.SetActive(false);
            item5.SetActive(false);
            juduloker3.SetActive(false);
            item3.SetActive(true);
            target3.SetActive(true);
            juduloker5.SetActive(true);
            lanjutkan5.SetActive(true);
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