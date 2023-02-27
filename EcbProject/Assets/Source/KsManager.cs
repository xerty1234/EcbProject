using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KsManager : MonoBehaviour
{

    public GameObject ksObject;
    TextMeshProUGUI resourceText;

     public GameObject buttonPrefab;

     public GameObject button1;
     public GameObject button2;
     public GameObject button3;

     public GameObject EmpHpBar; 


     string [] arrStrs;

     int iStrIndex;

    // Start is called before the first frame update
    void Start()
    {      
       buttonPrefab.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
           
    }

    public void setttingKs(string text) 
    {
        //게임 오브젝트인 KsText를 가져오는 부분
        GameObject KsText = GameObject.Find("KsText");
       // KsText에 텍스트를 변경하기 위한 컴보넌트를 가져오는 부분
       resourceText = KsText.GetComponent<TextMeshProUGUI>();
       // 텍스트를 변경
       resourceText.text = text;

        // 게임 오브젝트의 크기를 변경하기 위한 RectTransform 객체를 가져오는 부분
       RectTransform rectTransform = KsText.GetComponent<RectTransform>();
       
       // 크기 변경을 위힌 Vector2 선언
       Vector2  currentSize;
       // 게임 오브젝트의 현재 크기 값을 가져옴 (x:width,y:height)
       currentSize = rectTransform.sizeDelta;
       int length = text.Length;
       // width 값을 변경
       currentSize.x =  (100 * length);
       // 변경된 값을 넣어줌
       rectTransform.sizeDelta = currentSize;
    }

    
    public void settingWord (string text)
    {
        arrStrs = text.Split(' ');
        iStrIndex = 0;
        
        for(int i= 0; i<arrStrs.Length; i++)
        {
            Debug.Log("arrStrs["+i+"] " + arrStrs[i]);
        }

        settingWordBuutonText(arrStrs[0]);
        iStrIndex++;
        
    }

    public void nextWord()
    {
        Debug.Log("arrStrs.Length: " + arrStrs.Length);
        Debug.Log("iStrIndex: " + iStrIndex);

        if(arrStrs.Length == iStrIndex) 
        {
            EmpHpBar.GetComponent<HpBar>().TakeDamage(10);
            GameObject.Find("TestButton").GetComponent<TestButton>().clickButton();
        }
        else 
        {
            settingWordBuutonText(arrStrs[iStrIndex]);
            iStrIndex++;
        }
    }


    public void settingWordBuutonText(string correctText)
    {
        // 버튼 함수 활성화
        buttonPrefab.SetActive(true);
        // 랜덤함수  (정답을 찾기 위해 사용)
        int iCorrectIndex = Random.Range(0, 3);

        List<TextMeshProUGUI> arrbuttonTextMeshs = new List<TextMeshProUGUI>();

        List<GameObject> arrGameObject = new List<GameObject>();
        
        arrbuttonTextMeshs.Add(button1.transform.Find("WordText").GetComponent<TextMeshProUGUI>());
        arrbuttonTextMeshs.Add(button2.transform.Find("WordText").GetComponent<TextMeshProUGUI>());
        arrbuttonTextMeshs.Add(button3.transform.Find("WordText").GetComponent<TextMeshProUGUI>());

        arrGameObject.Add(button1);
        arrGameObject.Add(button2);
        arrGameObject.Add(button3);
       
        

        string [] strWrong = {"I","have","usual","changed","now"};

        for (int i=0; i<arrbuttonTextMeshs.Count; i++)
        {
            if(i == iCorrectIndex) 
            {
                arrbuttonTextMeshs[i].text = "" + (i+1) + "." + correctText;
                arrGameObject[i].GetComponent<WordButton>().setQuestion("정답");
            }
            else 
            {
                int iRandomIndex = Random.Range(0, strWrong.Length );

                if(correctText == strWrong[iRandomIndex]) 
                {
                    if(iRandomIndex < strWrong.Length)
                    {
                        arrbuttonTextMeshs[i].text = "" + (i+1) + "." + strWrong[iRandomIndex+1];
                        arrGameObject[i].GetComponent<WordButton>().setQuestion("오답");
                    }
                    else 
                    {
                        arrbuttonTextMeshs[i].text = "" + (i+1) + "." + strWrong[iRandomIndex-1];
                        arrGameObject[i].GetComponent<WordButton>().setQuestion("오답");
                    }                        
                }
                else
                {
                    arrbuttonTextMeshs[i].text = "" + (i+1) + "." + strWrong[iRandomIndex];
                    arrGameObject[i].GetComponent<WordButton>().setQuestion("오답");
                }
                
            }

        }

      

    }


    public void createWordButton(int x, int y, string word) 
    {
        /*
          // 버튼 생성
        GameObject buttonObject = Instantiate(buttonPrefab,Vector3.zero, Quaternion.identity);
        
        //캔버스를 부모로 설정해주는 부분 이 문장을 넣어야 canvars 위치값으로 설정이 가능하다.
        buttonObject.transform.SetParent(transform);

        RectTransform rectTransform = buttonObject.GetComponent<RectTransform>();
         // 크기 변경을 위힌 Vector2 선언
        Vector2  currentSize;
        currentSize = rectTransform.sizeDelta;
        currentSize.x = 860;
        currentSize.y = 100;
        //currentSize.x = x;
        //currentSize.y = y;

       rectTransform.sizeDelta = currentSize;

        // 버튼 위치, 크기, 텍스트 등 설정
        buttonObject.transform.localPosition = new Vector3(x, y, 0);
        buttonObject.transform.localScale = new Vector3(1, 1, 1);

       //GameObject wordText = buttonObject.Find("WordText");
        // KsText에 텍스트를 변경하기 위한 컴보넌트를 가져오는 부분

        Debug.Log("word: " + word);

       TextMeshProUGUI resourceText =  buttonObject.transform.Find("wordText").GetComponent<TextMeshProUGUI>();       
       //TextMeshProUGUI resourceText = buttonObject.GetComponent<TextMeshProUGUI>();
       // 텍스트를 변경
       resourceText.text = word;
       */

    }


}
