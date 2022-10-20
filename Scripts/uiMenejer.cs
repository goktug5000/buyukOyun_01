using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiMenejer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gorevB, emlakB, iksirciB, ahirB, barB, zirhciB, demirciB, marangozB, kumarB;
    public GameObject townP ,gorevP, emlakP, iksirciP, ahirP, barP, zirhciP, demirciP, marangozP, kumarP;
    public Text townName, townDescription;
    void Start()
    {
        try
        {
            sehirdeDegilim();
        }
        catch
        {

        }
    }
    public void gorevBut()
    {
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = gorevP.active;
        aktifMi = !aktifMi;

        gorevP.SetActive(aktifMi);
        
    }
    public void emlakBut()
    {
        gorevP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = emlakP.active;
        aktifMi = !aktifMi;

        
        emlakP.SetActive(aktifMi);
        
    }
    public void iksirciBut()
    {
        gorevP.SetActive(false);
        emlakP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = iksirciP.active;
        aktifMi = !aktifMi;

        
        iksirciP.SetActive(aktifMi);
        
    }
    public void ahirBut()
    {
        gorevP.SetActive(false);
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = ahirP.active;
        aktifMi = !aktifMi;

        
        ahirP.SetActive(aktifMi);
        
    }
    public void barBut()
    {
        gorevP.SetActive(false);
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = barP.active;
        aktifMi = !aktifMi;

        barP.SetActive(aktifMi);

    }
    public void zirhciBut()
    {
        gorevP.SetActive(false);
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = zirhciP.active;
        aktifMi = !aktifMi;

        zirhciP.SetActive(aktifMi);


    }
    public void demirciBut()
    {
        gorevP.SetActive(false);
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = demirciP.active;
        aktifMi = !aktifMi;

        demirciP.SetActive(aktifMi);


    }
    public void marangozBut()
    {
        gorevP.SetActive(false);
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        kumarP.SetActive(false);

        bool aktifMi = marangozP.active;
        aktifMi = !aktifMi;

        marangozP.SetActive(aktifMi);


    }
    public void kumarBut()
    {
        gorevP.SetActive(false);
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);

        bool aktifMi = kumarP.active;
        aktifMi = !aktifMi;

        kumarP.SetActive(aktifMi);


    }




    public void sehirdeDegilim()
    {
        townP.SetActive(false);

        gorevB.SetActive(false);
        emlakB.SetActive(false);
        iksirciB.SetActive(false);
        ahirB.SetActive(false);
        barB.SetActive(false);
        zirhciB.SetActive(false);
        demirciB.SetActive(false);
        marangozB.SetActive(false);
        kumarB.SetActive(false);

        gorevP.SetActive(false);
        emlakP.SetActive(false);
        iksirciP.SetActive(false);
        ahirP.SetActive(false);
        barP.SetActive(false);
        zirhciP.SetActive(false);
        demirciP.SetActive(false);
        marangozP.SetActive(false);
        kumarP.SetActive(false);
    }
    public void sehreIlkGirdim(string name, string aciklama,int gorev, int emlak, int iksirci, int ahir, int bar, int zirhci, int demirci, int marangoz, int kumarhane)
    {
        townP.SetActive(true);
        townName.text = name;
        townDescription.text = aciklama;
        if (gorev > 0)
        {
            gorevB.SetActive(true);
        }
        if (emlak > 0)
        {
            emlakB.SetActive(true);
        }
        if (iksirci > 0)
        {
            iksirciB.SetActive(true);
        }
        if (ahir > 0)
        {
            ahirB.SetActive(true);
        }
        if (bar > 0)
        {
            barB.SetActive(true);
        }
        if (zirhci > 0)
        {
            zirhciB.SetActive(true);
        }
        if (demirci > 0)
        {
            demirciB.SetActive(true);
        }
        if (marangoz > 0)
        {
            marangozB.SetActive(true);
        }
        if (kumarhane > 0)
        {
            kumarB.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
