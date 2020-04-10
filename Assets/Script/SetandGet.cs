using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class SetandGet : MonoBehaviour
{
    public Text inputList, allList;

    public void cek()
    {
      allList.text = allList.text +"\n"+ inputList.text;
    }
}
