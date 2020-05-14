using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeriksaJawaban : MonoBehaviour
{
    [Header("Properties (Jangan Diubah)")]
    public SaveLoad saveLoad;
    public SoalManager soalManager;
    public PanelSoal panelSoal;
    public List<string> gayaBelajar;
    public List<int> recordedHasil;
    public GameObject panelHasil;
    public Text textHasil;

    // Start is called before the first frame update
    void Start()
    {
        gayaBelajar = soalManager.gayaBelajar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YesAnswer(){
        soalManager.randomedSoal[panelSoal.soalKe-1].jawabanYa = true;
        panelSoal.NextSoal();
    }

    public void NoAnswer(){
        soalManager.randomedSoal[panelSoal.soalKe-1].jawabanYa = false;
        panelSoal.NextSoal();
    }

    public void Periksa(){
        foreach (Soal soal in soalManager.randomedSoal)
        {
            if(soal.type == gayaBelajar[0] && soal.jawabanYa == true){
                recordedHasil[0]++;
            }else if(soal.type == gayaBelajar[1] && soal.jawabanYa == true){
                recordedHasil[1]++;
            }else if(soal.type == gayaBelajar[2] && soal.jawabanYa == true){
                recordedHasil[2]++;
            }else if(soal.type == gayaBelajar[3] && soal.jawabanYa == true){
                recordedHasil[3]++;
            }else{
                Debug.Log("Error Penyimpanan Soal!");
            }
        }


        panelHasil.SetActive(true);
        textHasil.text = soalManager.gayaBelajar[saveLoad.LogisticRegression(recordedHasil)];
        //soalManager.gayaBelajar[MaxValue(recordedHasil)];
    }

}
