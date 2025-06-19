using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject cust1;
    public GameObject cust2;
    public GameObject cust3;
    public GameObject cust4;
    public int cusNum;
    public bool cus1 = false;
    public bool cus2 = false;
    public bool cus3 = false;
    public bool cus4 = false;
    

    public float timer = 2f;
    public int cusRan;

    // Start is called before the first frame update
    void Start()
    {
        cusNum = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (cusNum != 4)
        {
            CusSpawner();
        }else if(cusNum >= 4){
            Debug.Log("NO MORE CUSTOMERS");
        }
    }

    void CusSpawner()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            cusRan = Random.Range(0, 4);

            if (cusRan == 0 && cus1 == false)
            {
                Instantiate(cust1, new Vector3(11.79f, 1.8f, -4.46f), Quaternion.identity);
                timer = 7f;
                cusNum++;
                cus1 = true;

            } 
            else if (cusRan == 1 && cus2 == false)
            {
                Instantiate(cust2, new Vector3(11.79f, 1.8f, -4.46f), Quaternion.identity);
                timer = 7f;
                cusNum++;
                cus2 = true;
            }
            else if (cusRan == 2 && cus3 == false)
            {
                Instantiate(cust3, new Vector3(11.79f, 1.8f, -4.46f), Quaternion.identity);
                timer = 7f;
                cusNum++;
                cus3 = true;
            }
            else if (cusRan == 3 && cus4 == false)
            {
                Instantiate(cust4, new Vector3(11.79f, 1.8f, -4.46f), Quaternion.identity);
                timer = 7f;
                cusNum++;
                cus4 = true;

            } 
        }
    }

    void Custom1()
    {
        cus1 = false;
        cusNum--;
    }
    void Custom2()
    {
        cus2 = false;
        cusNum--;
    }
    void Custom3()
    {
        cus3 = false;
        cusNum--;
    }
    void Custom4()
    {
        cus4 = false;
        cusNum--;
    }
}
