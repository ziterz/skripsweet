using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSoal : MonoBehaviour
{
    
    public List<SoalProperties> soalProperties;
    public int soalKe;

    private int i;
    private SoalManager soalManager;
    private PeriksaJawaban periksaJawaban;
    
    // Start is called before the first frame update
    void Start()
    {
        soalProperties = new List<SoalProperties>();
        periksaJawaban = FindObjectOfType<PeriksaJawaban>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JumpToSoal(int nomorSoal){
        for(i=0;i<soalProperties.Count;i++){
            soalProperties[i].listSoal.SetActive(false);
            soalProperties[i].listActive = false;
            soalProperties[i].listButton.GetComponent<Button>().interactable = true;
        }
        soalProperties[nomorSoal].listSoal.SetActive(true);
        soalProperties[nomorSoal].listActive = false;
        soalProperties[nomorSoal].listButton.GetComponent<Button>().interactable = true;
        soalKe = nomorSoal+1;
    }

    public void SetFirstSoal(){
        int nomerSoal;
        for(i=0;i<soalProperties.Count;i++){
            soalProperties[i].listSoal.SetActive(false);
            soalProperties[i].listActive = false;

            nomerSoal = i + 1;
            soalProperties[i].listButton.GetComponentInChildren<Text>().text = nomerSoal.ToString();
            soalProperties[i].listButton.GetComponent<ButtonBehaviour>().buttonNumber = i;
        }
        soalKe = 1;

        soalProperties[soalKe-1].listActive = true;
        soalProperties[soalKe-1].listSoal.SetActive(true);
        soalProperties[soalKe-1].listButton.GetComponent<Button>().interactable = false;
    }

    public void NextSoal(){
        if(soalKe<soalProperties.Count){
            for(i=0;i<soalProperties.Count;i++){
                soalProperties[i].listSoal.SetActive(false);
                soalProperties[i].listActive = false;
                soalProperties[i].listButton.GetComponent<Button>().interactable = true;
            }
            soalProperties[soalKe].listSoal.SetActive(true);
            soalProperties[soalKe].listActive = false;
            soalProperties[soalKe].listButton.GetComponent<Button>().interactable = false;
            soalKe++;
        }else{
            periksaJawaban.Periksa();
        }
    }

    public void PrevSoal(){
        if(soalKe<soalProperties.Count){
            for(i=0;i<soalProperties.Count;i++){
                soalProperties[i].listSoal.SetActive(false);
                soalProperties[i].listActive = false;
                soalProperties[i].listButton.GetComponent<Button>().interactable = true;
            }

            soalProperties[soalKe-1].listSoal.SetActive(true);
            soalProperties[soalKe-1].listActive = false;
            soalProperties[soalKe-1].listButton.GetComponent<Button>().interactable = false;
            soalKe--;
        }   
    }

    public void SetButtonNumber(){
        for(i=0;i<soalProperties.Count;i++){
            int nomerSoal = i+1;
            soalProperties[i].listButton.GetComponentInChildren<Text>().text = nomerSoal.ToString();
            soalProperties[i].listButton.GetComponent<ButtonBehaviour>().buttonNumber = i;
        }
    }
}
