using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public int buttonNumber;
    
    private PanelSoal panelSoal;

    private void Start() {
        panelSoal = FindObjectOfType<PanelSoal>();
    }

    public void ClickMe(){
        panelSoal.JumpToSoal(buttonNumber);
    }
}
