using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trans : MonoBehaviour
{
    public GameObject stats_body;
    public GameObject profile_body;
    public GameObject Trans_body;
    public GameObject Tm_body;
    
    int c= 0;
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
        stats_body.SetActive(false);
        profile_body.SetActive(false);
        Tm_body.SetActive(false);
        Trans_body.SetActive(true);
        // if(c==0){
        // Trans_body.SetActive(true);
        // c=1;
        // }
        // else{
        // Trans_body.SetActive(false);
        // c=0;
        // }
    }
}
