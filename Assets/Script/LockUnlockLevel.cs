using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockUnlockLevel : MonoBehaviour
{
    // Start is called before the first frame update
    // public List<Button> materiERD;
    // public List<Button> materiDDL;
    // public List<Button> materiDML;
    public List<Button> materi;
    public int levelSekarangERD;
    public int levelSekarangDDL;
    public int levelSekarangDML;
//    public Text level;

    private
    void Start()
    {
        levelSekarangERD = PlayerPrefs.GetInt("LevelERD",0);
        levelSekarangDDL = PlayerPrefs.GetInt("LevelDDL",0);
        levelSekarangDML = PlayerPrefs.GetInt("LevelDML",0);
    }

    void Update() {
        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarangERD || i<=levelSekarangDDL || i<=levelSekarangDML){
                materi[i].interactable = true;
            }else{
                materi[i].interactable = false;
            }
            
        }
    }

    public void OnClickERD(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelERD",levelSekarangERD);
        // buat nambah level kebuka
        levelSekarangERD++;
    }

     public void OnClickDDL(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDDL",levelSekarangDDL);
        // buat nambah level kebuka
        levelSekarangDDL++;
    }

     public void OnClickDML(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDML",levelSekarangDML);
        // buat nambah level kebuka
        levelSekarangDML++;
    }

    public void ResetERD(){
        levelSekarangERD = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelERD",levelSekarangERD);
    }

        public void ResetDDL(){
        levelSekarangDDL = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDDL",levelSekarangDDL);
    }

        public void ResetDML(){
        levelSekarangDML = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDML",levelSekarangDML);
    }

}
