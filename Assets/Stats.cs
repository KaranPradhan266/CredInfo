using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public GameObject stats_body;
    public GameObject profile_body;
    public GameObject Trans_body;
    public GameObject Tm_body;
    
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
         profile_body.SetActive(false);
         Trans_body.SetActive(false);
         Tm_body.SetActive(false); 
         stats_body.SetActive(true);
        // if(a==0){
        // stats_body.SetActive(true);
        // a=1;
        // }
        // else{
        // stats_body.SetActive(false);
        // a=0;
        // }
    }
}
