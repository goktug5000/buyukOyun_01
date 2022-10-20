using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class myFightStats : MonoBehaviour
{
    public float Hp;
    public float Mana;
    public GameObject oldunP;
    private Camera mainCam;
    public Vector3 aimPoint;
    public GameObject aimObj,aimSymbol;
    // Start is called before the first frame update
    void Start()
    {
        oldunP = GameObject.Find("oldunPanel");
        oldunP.SetActive(false);

        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        //aimSymbol = GameObject.Find("aimPoint");
    }
    public void setMeToFight(float maxHP, float maxMana)
    {
        Hp = maxHP;
        Mana = maxMana;
    }
    public void takeDmg(float DMG)
    {
        Hp -= DMG;
        if (Hp <= 0)
        {
            oldunP.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        //Debug.Log(col.tag);
        if (col.gameObject.tag == "enemyHitBox")
        {
            takeDmg(col.gameObject.transform.parent.GetComponent<enemyHit>().attackDMG);
        }
    }

    public Ray myRay;
    public RaycastHit myHit;
    void Update()
    {
        try
        {
            if(aimObj != null)
            {
                aimSymbol.transform.position = aimObj.transform.position;
            }
            else
            {
                aimSymbol.transform.position = aimPoint;
            }
            
        }
        catch
        {

        }
        
        if (Input.GetMouseButtonDown(0))
        {
            myRay = mainCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(myRay, out myHit))
            {
                Debug.Log(myHit.point);

                if (myHit.transform.tag == "enemy")
                {
                    aimObj = myHit.transform.gameObject;
                }
                else
                {
                    aimObj = null;
                    aimPoint = myHit.point;
                }

            }
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
    }
}
