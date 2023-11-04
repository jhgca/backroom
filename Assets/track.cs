using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            GameObject instance = Instantiate(arrow, transform.position, Quaternion.identity); 
            instance.transform.right = GameManager.main.findclosestcane(transform.position).transform.position - transform.position;
        }
    }
}
