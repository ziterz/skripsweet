using UnityEngine;
using TMPro;

public class SetUsername : MonoBehaviour
{
    public TMP_InputField nameField;

    public static GameObject homePanel, namePanel;
    public void OnSubmit()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetString("Username",nameField.text);
        PlayerPrefs.SetInt("Position", 0); 
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Intro", 1);
        PlayerPrefs.SetInt("ShowPretest", 1);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.SetInt("Level", 0);
        PlayerPrefs.Save();
    }

    void Start()
    {
        homePanel = GameObject.Find("HomePanel");
        namePanel = GameObject.Find("NamePanel");

        if(PlayerPrefs.GetInt("ShowPretest") == 1)
        {
            namePanel.gameObject.SetActive(false);
            homePanel.gameObject.SetActive(true);
            PlayerPrefs.SetInt("ShowPretest", 0);
        }
        else
        {
            namePanel.gameObject.SetActive(true);
            homePanel.gameObject.SetActive(false);
        }
    }
}
