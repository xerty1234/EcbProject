using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{

   public GameObject Hpbar;
   public GameObject ksManager;
   public GameObject SentenceManager;

    
    int iListSize = 0;
    List<SentManager.Sentence> myList;

      class Sentence 
    {
        public string strEngSentence;
        public string strKorSentence; 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickButton()
    {
    
        settingSentence(); 

        ksManager.GetComponent<KsManager>().setttingKs(myList[0].strKorSentence);
        ksManager.GetComponent<KsManager>().settingWord(myList[0].strEngSentence);

        myList.RemoveAt(0);
        iListSize = myList.Count;
        
    }

    public void settingSentence () 
    {
        if(iListSize <= 0) 
        {
            myList = new List<SentManager.Sentence> (GameObject.Find("gameObjSentManager").GetComponent<SentManager>().getSentence());
            iListSize = myList.Count;
        }   
    }

    public void initGamePlay()
    {
        iListSize = 0;
        myList = new List<SentManager.Sentence> (GameObject.Find("gameObjSentManager").GetComponent<SentManager>().getSentence());
        
        ksManager.GetComponent<KsManager>().setttingKs(myList[0].strKorSentence);
        ksManager.GetComponent<KsManager>().settingWord(myList[0].strEngSentence);

        myList.RemoveAt(0);
        iListSize = myList.Count;
    }


}
