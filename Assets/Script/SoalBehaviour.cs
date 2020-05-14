using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoalBehaviour : MonoBehaviour
{
    [TextArea]
    public string soal;
    public string type;
    public bool terjawab;

    private List<string> typeSoalA,typeSoalB,typeSoalC,typeSoalD;
    private SoalManager soalManager;

    private void Start() {
        //soal = GameObject.FindObjectOfType<PanelSoal>();
    }

    public void SendAnswer(){
        //if(type ==  )
        //bool answer = true;
    }
}
