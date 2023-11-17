using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject balance_body;
    public VirtualButtonBehaviour Vb;
    int a=0;
    // Start is called before the first frame update
    void Start()
    {
        balance_body.SetActive(false);
        Vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(a==0){
        balance_body.SetActive(true);
        a=1;
        }
        else{
            balance_body.SetActive(false);
            a=0;
        }
    }
}
