using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DMLockUnlock2 : MonoBehaviour
{
    // Start is called before the first frame update
    // public List<Button> materiERD;
    // public List<Button> materiDDL;
    // public List<Button> materiDML;
    public List<Button> materi;
    public int levelSekarangDML;
//    public Text level;

    private
    void Start()
    {
        levelSekarangDML = PlayerPrefs.GetInt("LevelDML",0);
    }

    void Update() {
        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarangDML){
                materi[i].interactable = true;
            }else{
                materi[i].interactable = false;
            }
            
        }
    }


     public void OnClickDML(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDML",levelSekarangDML);
        // buat nambah level kebuka
        levelSekarangDML++;
    }

        public void ResetDML(){
        levelSekarangDML = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDML",levelSekarangDML);
    }



}
