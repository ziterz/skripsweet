using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDLockUnlock : MonoBehaviour
{
    // Start is called before the first frame update
    // public List<Button> materiERD;
    // public List<Button> materiDDL;
    // public List<Button> materiDML;
    public List<Button> materi;
    public int levelSekarangDDL2;
//    public Text level;

    private
    void Start()
    {
        levelSekarangDDL2 = PlayerPrefs.GetInt("LevelDDL2",0);
    }

    void Update() {
        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarangDDL2){
                materi[i].interactable = true;
            }else{
                materi[i].interactable = false;
            }
            
        }
    }



     public void OnClickDDL2(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDDL2",levelSekarangDDL2);
        // buat nambah level kebuka
        levelSekarangDDL2++;
    }
    
    public void ResetDDL2(){
        levelSekarangDDL2 = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelDDL2",levelSekarangDDL2);
    }




}
