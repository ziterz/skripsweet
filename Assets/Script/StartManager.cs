using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public int PretestDone;
    public string Pretest,MainMenu;
    // Start is called before the first frame update
    void Start()
    {
        PretestDone = PlayerPrefs.GetInt("PretestDone",0);
    }

    // Update is called once per frame
    public void PretestDonee(){
        if(PlayerPrefs.GetInt("PretestDone") == 0){
            SceneManager.LoadScene(Pretest);
            PlayerPrefs.SetInt("PretestDone",1);
            //PlayerPrefs.SetInt("PretestDone",0);
            Debug.Log(PlayerPrefs.GetInt("PretestDone"));
        }else{
            SceneManager.LoadScene(MainMenu);
        }
    }
}
