using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public int money;
    public Text amount;
    // Start is called before the first frame update
    void Start()
    {
        money = 100;

    }

    // Update is called once per frame
    void Update()
    {
        amount.text = money.ToString();
    }

    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
    }

    public void subtractMoney(int moneyToSubtract)
    {
        if(money - moneyToSubtract < 0)
        {
            Debug.Log("Insufficient");
        }
        else
        {
            money -= moneyToSubtract;
        }

    }
}
