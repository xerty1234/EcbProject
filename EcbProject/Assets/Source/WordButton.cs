using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordButton : MonoBehaviour
{
    public string strQuestion = "";
    public GameObject myHpBar;
    public GameObject EmpHpBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setQuestion (string str) 
    {   
        strQuestion = str;
    }

    public void initButton ()
    {
        strQuestion = "";
    }

    public void clickEvent ()
    {

        if(strQuestion == "정답")
        {
            // 넥스트 문제
            //EmpHpBar.GetComponent<HpBar>().TakeDamage(10);
            GameObject.Find("KsManager").GetComponent<KsManager>().nextWord();
        }
        else 
        {
            // 자신의 피가 내려간다.
            myHpBar.GetComponent<HpBar>().TakeDamage(10);

        }
    }
}
