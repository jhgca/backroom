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
    public void changecanes(int amount)
    {
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
