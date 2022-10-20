using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneMenejeri : MonoBehaviour
{

    public GameObject statsObj;
    public string nextArea;
    public int[][] nEnemy;//xx,yy
    //türü için xx, adeti için yy
    public Vector3 myPos;
    public bool islemVar;

    void Start()
    {
        statsObj = GameObject.Find("Stats");
        islemVar = false;
    }
    public void toFight(string areaa, int[][] enemyy)
    {
        if (islemVar == false)
        {
            
            if (GameObject.Find("Player").GetComponent<myDokunulmazlik>().dokunulmazlik <= 0)
            {
                islemVar = true;
                //Debug.Log("dokunulmaz değilsin");
                try
                {
                    myPos = GameObject.Find("Player").transform.position;
                }
                catch
                {
                    Debug.Log("pos kaydedemedim");
                }

                try
                {
                    nEnemy = enemyy;
                }
                catch
                {
                    Debug.Log("enemyy boş");
                }

                DontDestroyOnLoad(this.gameObject);
                DontDestroyOnLoad(statsObj);


                StartCoroutine(waitForSceneLoadFight("FightScene"));
                
                

            }
            else
            {
                //Debug.Log("dokunulmazlık");
            }
        }
        
        


    }
    public void toSample()
    {

        DontDestroyOnLoad(this.gameObject);
       
        if (islemVar == false)
        {
            islemVar = true;

            StartCoroutine(waitForSceneLoad("SampleScene"));

            
        }

    }
    IEnumerator waitForSceneLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        while (SceneManager.GetActiveScene().name != sceneName)
        {
            yield return null;
        }


        Debug.Log("doru yere geçtin");

        islemVar = false;

        GameObject.Find("Player").GetComponent<myDokunulmazlik>().dokunulmazlik = 10;

        GameObject.Find("Player").transform.position = myPos;


    }


    IEnumerator waitForSceneLoadFight(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        while (SceneManager.GetActiveScene().name != sceneName)
        {

            yield return null;
        }

        Debug.Log("doru yere geçtin");

        islemVar = false;

        try
        {
            statsObj.GetComponent<myStats>().reStatHero();
            Debug.Log("maxHP: " + statsObj.GetComponent<myStats>().maxHp);
            float hpp = statsObj.GetComponent<myStats>().maxHp;
            Debug.Log("maxMana: " + statsObj.GetComponent<myStats>().maxMana);
            float manaa = statsObj.GetComponent<myStats>().maxMana;
            GameObject.Find("Player").GetComponent<myFightStats>().setMeToFight(hpp, manaa);
        }
        catch
        {
            Debug.LogError("statlarda hata var");
        }


        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
