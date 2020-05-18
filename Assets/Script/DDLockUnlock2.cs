using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDLockUnlock2 : MonoBehaviour
{
    // Start is called before the first frame update
    // public List<Button> materiERD;
    // public List<Button> materiDDL;
    // public List<Button> materiDML;
    public List<Button> materi;
    public int levelSekarangDDL;
//    public Text level;

    private
    void Start()
    {
        levelSekarangDDL = PlayerPrefs.GetInt("LevelDDL",0);
    }

    void Update() {
        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarangDDL){
                materi[i].interactable = true;
            }else{
                materi[i].interactable = false;
            }
            
        }
    }



     public void OnClickDDL(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDDL",levelSekarangDDL);
        // buat nambah level kebuka
        levelSekarangDDL++;
    }
    
    public void ResetDDL(){
        levelSekarangDDL = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDDL",levelSekarangDDL);
    }




}
