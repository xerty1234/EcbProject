using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class KsManager : MonoBehaviour
{

    public GameObject ksObject;
    TextMeshProUGUI resourceText;
    // Start is called before the first frame update
    void Start()
    {      
       

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
       // width 값을 변경
       currentSize.x = 300;
       // 변경된 값을 넣어줌
       rectTransform.sizeDelta = currentSize;
    }

}
