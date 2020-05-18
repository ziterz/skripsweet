using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ERDLockUnlock : MonoBehaviour
{
    // Start is called before the first frame update
    // public List<Button> materiERD;
    // public List<Button> materiDDL;
    // public List<Button> materiDML;
    public List<Button> materi;
    public int levelSekarangERD2;
//    public Text level;

    private
    void Start()
    {
        levelSekarangERD2 = PlayerPrefs.GetInt("LevelERD2",0);
    }

    void Update() {
        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarangERD2){
                materi[i].interactable = true;
            }else{
                materi[i].interactable = false;
            }
            
        }
    }

     public void OnClickERD2(){
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelERD2",levelSekarangERD2);
        // buat nambah level kebuka
        levelSekarangERD2++;
    }

    public void ResetERD2(){
        levelSekarangERD2 = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelERD2",levelSekarangERD2);
    }

}
