using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class send_money : MonoBehaviour


{
    public GameObject send_mon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown(){
        Application.OpenURL("https://paytm.com/");
    }
}
