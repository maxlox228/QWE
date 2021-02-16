using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GG : MonoBehaviour
{
    public GameObject Left1;
    public GameObject Left2;
    public GameObject Right1;
    public GameObject Right2;
    public float gg;
    public float dd;
    public GameObject DarkEggs;
    public float loosSchet;
    public int Schet;
    public float GameTime;
    public GameObject Eggs;
    public Text SchetText;
    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public GameObject Panel;



    void Start()
    {
        GameTime = 1;
        gg = Random.Range(1, 4);
    }
    void Update()
    {
        SchetText.text = "—чет €иц: " + Schet.ToString();
        GameTime -= Time.deltaTime;

        if (GameTime < 0 && gg == 1)
        {
            Instantiate(Eggs, Left1.transform.position, Quaternion.identity);
            GameTime = 2;
            gg = Random.Range(1, 4);
        }   
        if (GameTime < 0 && gg == 2)
        {
            Instantiate(Eggs, Left2.transform.position, Quaternion.identity);
            GameTime = 2;
            gg = Random.Range(1, 4);
        }
        if (GameTime < 0 && gg == 3)
        {
            Instantiate(Eggs, Right1.transform.position, Quaternion.identity);
            GameTime = 2;
            gg = Random.Range(1, 4);
        }
        if (GameTime < 0 && gg == 4)
        {
            Instantiate(Eggs, Right2.transform.position, Quaternion.identity);
            GameTime = 2;
            gg = Random.Range(1, 4);
        }

        if (loosSchet == 3 )
        {
            Panel.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Eggs"))
        {
            Destroy(other.gameObject);
            loosSchet += 1;

            switch (loosSchet)
            {
                case 1:
                    L1.SetActive(true);
                    break;
                case 2:
                    L2.SetActive(true);
                    break;
                case 3:
                    L3.SetActive(true);
                    break;
            }
        }
    }
    public void qwe()
    {
        Schet += 1;
    }
}
