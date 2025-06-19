using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
    [SerializeField] Text moneyAmt;
    public int money = 0;
    int currentMoney;
    void Start()
    {
        moneyAmt.text = "Money: " + money; 
    } 

    // Update is called once per frame
    void Update()
    {
       
    }

    int MoneyUpdate(int money)
    {
        currentMoney = currentMoney + money;
        moneyAmt.text = "Money: " + currentMoney;
        return money;
    }
}
