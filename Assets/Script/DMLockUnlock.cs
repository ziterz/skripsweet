using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DMLockUnlock : MonoBehaviour
{
    // Start is called before the first frame update
    // public List<Button> materiERD;
    // public List<Button> materiDDL;
    // public List<Button> materiDML;
    public List<Button> materi;
    public int levelSekarangDML2;
//    public Text level;

    private
    void Start()
    {
        levelSekarangDML2 = PlayerPrefs.GetInt("LevelDML2",0);
    }

    void Update() {
        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarangDML2){
                materi[i].interactable = true;
            }else{
                materi[i].interactable = false;
            }
            
        }
    }


     public void OnClickDML2(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDML2",levelSekarangDML2);
        // buat nambah level kebuka
        levelSekarangDML2++;
    }

        public void ResetDML2(){
        levelSekarangDML2 = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDML2",levelSekarangDML2);
    }



}
