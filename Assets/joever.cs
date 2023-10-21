    using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class joever : MonoBehaviour

{
    public GameObject die;
    public static joever main;
    private void Awake()
    {
        main = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        die.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activeJoever()
    {
        die.SetActive(true);
    }
}
