using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ERDLockUnlock2 : MonoBehaviour
{
    // Start is called before the first frame update
    // public List<Button> materiERD;
    // public List<Button> materiDDL;
    // public List<Button> materiDML;
    public List<Button> materi;
    public int levelSekarangERD;
//    public Text level;

    private
    void Start()
    {
        levelSekarangERD = PlayerPrefs.GetInt("LevelERD",0);
    }

    void Update() {
        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarangERD){
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

    public void ResetERD(){
        levelSekarangERD = 0;
        // buat nyimpen level 
        PlayerPrefs.SetInt("LevelERD",levelSekarangERD);
    }

}
