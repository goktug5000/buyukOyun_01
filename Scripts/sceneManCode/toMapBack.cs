using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMapBack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject koru1, koru2;//sikenMenej, stats


    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(koru1);
        DontDestroyOnLoad(koru2);

        StartCoroutine(deneme("SampleScene"));

        //koru1.GetComponent<SceneMenejeri>().toSample();

        

    }
    IEnumerator deneme(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        while (SceneManager.GetActiveScene().name != sceneName)
        {
            yield return null;
        }
        koru2.GetComponent<myStats>().reStatHero();
        Destroy(this.gameObject);
    }

}
