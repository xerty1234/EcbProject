using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentManager : MonoBehaviour
{

   public GameObject ksManager;


    public class Sentence
    {
        public string strEngSentence;
        public string strKorSentence; 
    }

    int iListSize = 0;

    public List<Sentence> myDict = new List<Sentence>();
    public List<Sentence> myList;

    // Start is called before the first frame update
    void Start()
    {
         settingMyDict();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<Sentence> getSentence() 
    {
        return myDict;
    }


    void settingMyDict() 
    {

        Sentence temp = new Sentence();
        temp.strEngSentence = "How have you been?"; temp.strKorSentence = "그동안 어떻게 지냈어?";
        myDict.Add(temp);
        
        Sentence temp2= new Sentence();
        temp2.strEngSentence = "Can not complain"; temp2.strKorSentence = "그럭저럭 지냈어";
        myDict.Add(temp2);

        Sentence temp3= new Sentence();
        temp3.strEngSentence = "Same as usual"; temp3.strKorSentence = "늘 똑같지 뭐";    
        myDict.Add(temp3);

        Sentence temp4 = new Sentence();
        temp4.strEngSentence = "have not changed a bit"; temp4.strKorSentence = "하나도 안 변했다";    
        myDict.Add(temp4);
     
        Sentence temp5 = new Sentence();
        temp5.strEngSentence = "Really? You have changed a lot"; temp5.strKorSentence = "정말? 넌 정말 많이 변했는데";
        myDict.Add(temp5);

        Sentence temp6 = new Sentence();
        temp6.strEngSentence = "I have to go now"; temp6.strKorSentence = "이제 가 봐야겠어요";
        myDict.Add(temp6);

        Sentence temp7 = new Sentence();
        temp7.strEngSentence = "Say hello to your father."; temp7.strKorSentence = "아버지께 안부 전해주세요";
        myDict.Add(temp7);

        Sentence temp8 = new Sentence();
        temp8.strEngSentence = "See you around"; temp8.strKorSentence = "나중에 봐요";
        myDict.Add(temp8);

        Sentence temp9 = new Sentence();
        temp9.strEngSentence = "Nice meeting you"; temp9.strKorSentence = "만나서 반가웠어";
        myDict.Add(temp9);

        Sentence temp10 = new Sentence();
        temp10.strEngSentence = "Hope to see you again"; temp10.strKorSentence = "또 봤으면 좋겠다.";
        myDict.Add(temp10);

        GameObject.Find("GameState").GetComponent<GameState>().GameStart();
    }


    public void settingSentence () 
    {
        if(iListSize <= 0) 
        {
            myList = new List<Sentence> (getSentence() );
            iListSize = myList.Count;
        }   
    }

     public void initGamePlay()
    {
        iListSize = 0;
        myList = new List<Sentence> (getSentence());
        
        ksManager.GetComponent<KsManager>().setttingKs(myList[0].strKorSentence);
        ksManager.GetComponent<KsManager>().settingWord(myList[0].strEngSentence);

        myList.RemoveAt(0);
        iListSize = myList.Count;
    }

     public void nextSent()
    {
    
        settingSentence(); 

        ksManager.GetComponent<KsManager>().setttingKs(myList[0].strKorSentence);
        ksManager.GetComponent<KsManager>().settingWord(myList[0].strEngSentence);

        myList.RemoveAt(0);
        iListSize = myList.Count;
        
    }


}
