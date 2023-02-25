using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentManager : MonoBehaviour
{
    public class Sentence
    {
        public string strEngSentence;
        public string strKorSentence; 
    }

      public List<Sentence> myDict = new List<Sentence>();

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
        temp.strEngSentence = "How have ypu been?"; temp.strKorSentence = "그동안 어떻게 지냈어?";
        myDict.Add(temp);

        temp.strEngSentence = "Can not complain"; temp.strKorSentence = "그럭저럭 지냈어";
        myDict.Add(temp);

        temp.strEngSentence = "Same as usual"; temp.strKorSentence = "늘 똑같지 뭐";    
        myDict.Add(temp);

        temp.strEngSentence = "have not changed a bit"; temp.strKorSentence = "하나도 안 변했다";    
        myDict.Add(temp);

        temp.strEngSentence = "Really? You have changed a lot"; temp.strKorSentence = "정말? 넌 정말 많이 변했는데";
        myDict.Add(temp);

        temp.strEngSentence = "I have to go now"; temp.strKorSentence = "이제 가 봐야겠어요";
        myDict.Add(temp);

        temp.strEngSentence = "Say hello to your father."; temp.strKorSentence = "아버지께 안부 전해주세요";
        myDict.Add(temp);

        temp.strEngSentence = "See you around"; temp.strKorSentence = "나중에 봐요";
        myDict.Add(temp);

        temp.strEngSentence = "Nice meeting you"; temp.strKorSentence = "만나서 반가웠어";
        myDict.Add(temp);

        temp.strEngSentence = "Hope to see you again"; temp.strKorSentence = "또 봤으면 좋겠다.";
        myDict.Add(temp);
    }


}
