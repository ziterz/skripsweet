using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class SaveLoad : MonoBehaviour
{
    
    public List<float> savedHasil;
    
    public int jumlahCoba;
    public bool resetPrefs;
    public SoalManager soalManager;
    private List<float> temp;

    // Start is called before the first frame update
    void Start()
    {
        
        temp = new List<float>();
        if(resetPrefs){
            jumlahCoba = 0;
            savedHasil[0] = 0;
            savedHasil[1] = 0;
            savedHasil[2] = 0;
            savedHasil[3] = 0;
        }else{
            jumlahCoba = PlayerPrefs.GetInt("coba",0);
            savedHasil[0] = PlayerPrefs.GetFloat("type1",0);
            savedHasil[1] = PlayerPrefs.GetFloat("type2",0);
            savedHasil[2] = PlayerPrefs.GetFloat("type3",0);
            savedHasil[3] = PlayerPrefs.GetFloat("type4",0);
        }
        
    }

    void Restart(){
        SceneManager.LoadScene("2 kuisioner");
    }

    //Logistic Regression nya disini
    public int LogisticRegression(List<int> recordedHasil){
        jumlahCoba++; // jumlah iterasi satu anak nyoba mengisi
        PlayerPrefs.SetInt("coba",jumlahCoba);
        float angka,angka2;
        for(int i =0;i<savedHasil.Count;i++){
            angka = (savedHasil[i] + recordedHasil[i]);
            temp.Add(angka);
        }

        PlayerPrefs.SetFloat("type1",temp[0]);
        PlayerPrefs.SetFloat("type2",temp[1]);
        PlayerPrefs.SetFloat("type3",temp[2]);
        PlayerPrefs.SetFloat("type4",temp[3]);

        List<float> temp2 = new List<float>();
        for(int i =0;i<temp.Count;i++){
            angka2 = temp[i]/jumlahCoba;
            temp2.Add(angka2);
        }

        int hasil = MaxValue(temp2);
        return hasil;
    }

    int MaxValue (List<float> intArray) {
        float max = intArray[0];
        int arrayNumber = 0;
        for (int i=0; i < intArray.Count; i++) {
            if (intArray[i] > max) {
                max = intArray[i];
                arrayNumber = i;
            }
        }
        return arrayNumber;
    }
}
