using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tileTown : MonoBehaviour
{
    public GameObject uiManager;
    public string adi,aciklama;
    public int orduTipi, gorev, emlak, iksirci, ahir, bar, zirhci, demirci, marangoz, kumarhane;
    //orduTipi x, gorev xx, emlak x, iksirci 1-4, ahir 1, bar 1, zirhci 1-3, demirci 1-3, marangoz 1-3, kumarhane 1;
    public float emlakCarpani, orduCarpani, zirhciCarpani, iksirciCarpani, demirciCarpani, marangozCarpani;
    private float playerChr;

    void Start()
    {
        try
        {
            playerChr = GameObject.Find("Stats").GetComponent<myStats>().chr;
        }
        catch
        {
            Debug.Log("ref için aaa");
        }
        
        uiManager = GameObject.Find("UI_Manager");

    }


    private void OnTriggerStay(Collider col)
    {
        int d100 = 0;
        //Debug.Log(col.gameObject.name + " girdi");
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log("player girdi ve d100= " + d100);
            d100 = col.gameObject.GetComponent<eventDie>().getD100();
            uiManager.GetComponent<uiMenejer>().sehreIlkGirdim(adi, aciklama, gorev, emlak, iksirci, ahir, bar, zirhci, demirci, marangoz, kumarhane);
        }
    }
    private void OnTriggerExit(Collider col)
    {
        int d100 = 0;
        //Debug.Log(col.gameObject.name + " çıktı");
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log("player girdi ve d100= " + d100);
            d100 = col.gameObject.GetComponent<eventDie>().getD100();
            uiManager.GetComponent<uiMenejer>().sehirdeDegilim();
        }
    }

    void Update()
    {

    }
}
