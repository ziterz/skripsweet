using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void DoQuit()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("x", -13);
        PlayerPrefs.SetInt("Position", 0); 
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("ShowPretest", 0);
        PlayerPrefs.SetInt("Pretest", 0);
        PlayerPrefs.SetInt("PretestDone", 0);
        PlayerPrefs.SetInt("KuisionerDone", 0);
        PlayerPrefs.SetInt("Postest", 0);
        PlayerPrefs.SetInt("nilaiKuis", 0);
        PlayerPrefs.SetInt("mainLevel", 0);
        PlayerPrefs.SetInt("LevelERD", 0);
        PlayerPrefs.SetInt("LevelDDL", 0);
        PlayerPrefs.SetInt("LevelDML", 0);
        PlayerPrefs.SetInt("LevelERD2", 0);
        PlayerPrefs.SetInt("LevelDDL2", 0);
        PlayerPrefs.SetInt("LevelDML2", 0);
        PlayerPrefs.Save();
        Application.Quit();
    }
}