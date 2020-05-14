using UnityEngine;
using TMPro;

public class SetUsername : MonoBehaviour
{
    public TMP_InputField nameField;

    public GameObject homePanel, namePanel;
    public GameObject kasus, tutor, mulai;
    
    public void OnSubmit()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetString("Username",nameField.text);
        PlayerPrefs.SetInt("Position", 0); 
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Intro", 1);
        PlayerPrefs.SetInt("ShowPretest", 1);
        PlayerPrefs.SetInt("Pretest", 0);
        PlayerPrefs.SetInt("Postest", 0);
        // PlayerPrefs.SetInt("KuisDDL", 0);
        // PlayerPrefs.SetInt("KuisDML", 0);
        // PlayerPrefs.SetInt("KuisERD", 0);
        PlayerPrefs.SetInt("nilaiKuis", 0);
        PlayerPrefs.SetInt("mainLevel", 0);
        PlayerPrefs.SetInt("LevelERD", 0);
        PlayerPrefs.SetInt("LevelDDL", 0);
        PlayerPrefs.SetInt("LevelDML", 0);
        PlayerPrefs.SetInt("LevelERD2", 0);
        PlayerPrefs.SetInt("LevelDDL2", 0);
        PlayerPrefs.SetInt("LevelDML2", 0);
        PlayerPrefs.Save();
    }

    void Start()
    {
        homePanel = GameObject.Find("HomePanel");
        namePanel = GameObject.Find("NamePanel");
        kasus.SetActive(false);
        tutor.SetActive(false);
        mulai.SetActive(true);

        if(PlayerPrefs.GetInt("ShowPretest") == 1)
        {
            namePanel.gameObject.SetActive(false);
            homePanel.gameObject.SetActive(true);
            PlayerPrefs.SetInt("ShowPretest", 0);

            if(PlayerPrefs.GetString("Username") != null){
                if(PlayerPrefs.GetString("GayaBelajar") == "StudiKasus"){
                    kasus.SetActive(true);
                    tutor.SetActive(false);
                    mulai.SetActive(false);
                } else if(PlayerPrefs.GetString("GayaBelajar") == "Tutorial"){
                    tutor.SetActive(true);
                    kasus.SetActive(false);
                    mulai.SetActive(false); 
                }
            }
        }
        else
        {
            namePanel.gameObject.SetActive(true);
            homePanel.gameObject.SetActive(false);
        }
    }
}
