using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{

   public GameObject Hpbar;
   public GameObject ksManager;
   public GameObject SentenceManager;

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
        // 커밋 테스트
        //Debug.Log("테스트 버튼 클릭 이벤트");
        //Hpbar.GetComponent<HpBar>().TakeDamage(10);
        /*
            GameObject myGameObject = GameObject.Find("gameObjSentManager");
            SentManager myDict = myGameObject.GetComponent<SentManager>();
            List<SentManager.Sentence> myList = myDict.getSentence();
        */
        List<SentManager.Sentence> myList = GameObject.Find("gameObjSentManager").GetComponent<SentManager>().getSentence();


        Debug.Log("strEngSentence: " + myList[0].strEngSentence);
        Debug.Log("strKorSentence: " + myList[0].strKorSentence);

        
        ksManager.GetComponent<KsManager>().setttingKs(myList[0].strKorSentence);

    }

}
