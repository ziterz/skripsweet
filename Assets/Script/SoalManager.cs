using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Soal
{
    [TextArea]
    public string soal;
    public string type;
    public bool jawabanYa;
}

[System.Serializable]
public class SoalProperties
{
    public GameObject listSoal;
    public GameObject listButton;
    public bool listActive;
}

public class SoalManager : MonoBehaviour
{
    [Header("Pengaturan Soal")]
    public List<string> gayaBelajar;
    public List<Soal> recordSoal;
    
    [Header("Properties (Jangan Diubah)")]
    public GameObject card;
    public GameObject buttonNavigasi;
    public GameObject panelSoal;
    public RectTransform navigasi;
    public PanelSoal listView;
    
    private TMP_Text textSoal;
    private SoalProperties properties;
    public List<Soal> randomedSoal;

    // Start is called before the first frame update
    void Start()
    {
        
        randomedSoal = new List<Soal>();
        SetSoal();
    
    }

   void Restart(){
        SceneManager.LoadScene("2 kuisioner");
    }

    public void SetSoal(){
        RandomSoal();
        foreach (Soal soal in randomedSoal)
        {
            properties = new SoalProperties();
            GameObject obj = Instantiate(card, panelSoal.GetComponent<RectTransform>(), false) as GameObject;
            obj.transform.SetParent(panelSoal.GetComponent<RectTransform>());

            GameObject nvgs = Instantiate(buttonNavigasi, navigasi, false) as GameObject;
            nvgs.transform.SetParent(navigasi);
            
            obj.GetComponentInChildren<TMP_Text>().text = soal.soal;
            obj.GetComponent<SoalBehaviour>().soal = soal.soal;
            obj.GetComponent<SoalBehaviour>().type = soal.type;

            properties.listSoal = obj;
            properties.listButton = nvgs;
            properties.listActive = false;

            listView.soalProperties.Add(properties);
            
        }
        listView.SetFirstSoal();
        //listView.SetButtonNumber();

    }

    void RandomSoal(){
        while(recordSoal.Count != 0){
        int tempAngka = Random.Range(0,recordSoal.Count);
        Soal temp = recordSoal[tempAngka];
        randomedSoal.Add(temp);
        recordSoal.RemoveAt(tempAngka);
        };
        
    }
}
