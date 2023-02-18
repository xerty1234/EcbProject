using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{

   public GameObject Hpbar;

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
        Debug.Log("테스트 버튼 클릭 이벤트");
        Hpbar.GetComponent<HpBar>().TakeDamage(10);
        

    }

}
