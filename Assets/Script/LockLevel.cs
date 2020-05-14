using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Button> materi;
    public int levelSekarang;
    public Text level;

    private
    void Start()
    {
        levelSekarang = PlayerPrefs.GetInt("LevelAt",0);
    }

    void Update() {
        level.text = levelSekarang+1.ToString();

        for(int i=0;i<materi.Count;i++){
            if(i<=levelSekarang){
                materi[i].interactable = true;
            }else{
                materi[i].interactable = false;
            }
            
        }
    }

    public void Simpan(){
        PlayerPrefs.SetInt("LevelAt",levelSekarang);
    }

    public void Tambah(){
        levelSekarang++;
    }

    public void ResetInt(){
        levelSekarang = 0;
    }
}
