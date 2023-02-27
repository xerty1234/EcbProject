using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{

    public GameObject objGamePlay;
    public GameObject objGameOver;
    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        objGamePlay.SetActive(false);
        objGameOver.SetActive(true);
    }

    public void GameStart()
    {
        objGamePlay.SetActive(true);
        objGameOver.SetActive(false);

        GameObject.Find("EmpHpBar").GetComponent<HpBar>().Heal(100);
        GameObject.Find("MyHpBar").GetComponent<HpBar>().Heal(100);

        GameObject.Find("TestButton").GetComponent<TestButton>().initGamePlay();
     
    }


}
