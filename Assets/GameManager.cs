using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager main;
    public int canes;
    public TextMeshProUGUI canetxt;
    public TextMeshProUGUI timer;
    public GameObject[] canearray;

    public GameObject findclosestcane(Vector2 position)
    {
        GameObject closest = canearray[0];

        foreach (GameObject cane in canearray)
        {
            if (Vector2.Distance(position, cane.transform.position) > Vector2.Distance(closest.transform.position, position))
            {
                closest = cane;
            }
        }
        return closest;
    }
    public void changecanes(int amount)
    {
        canearray = GameObject.FindGameObjectsWithTag("canes");
        canes += amount;
        canetxt.text = "kains saus: " + canes;
    }
    public void countdown(int time)
    {
        timer.text = "angerys: " + time + "/120";
    }


    // Start is called before the first frame update
    void Start()
    {
        canearray = GameObject.FindGameObjectsWithTag("canes");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        main = this;
    }
}
