using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class enter : MonoBehaviour
{
    public TextMeshPro textmeshPro_one;
    public TextMeshPro textmeshPro_two;
    public TextMeshPro textmeshPro_three;
    public TextMeshPro textmeshPro_four;
    public GameObject security;
    public GameObject denied;
    public GameObject balance_body;
    public GameObject profile;
    public GameObject trans;
    public GameObject tm;
    public GameObject stats;
    public GameObject logo;
    public GameObject lck;
    public GameObject logout;
    int count = 0;
    

    


    
  
    // Start is called before the first frame update
    void Start()
    {
    void Awake(){
      textmeshPro_one = GetComponent<TextMeshPro>();
      textmeshPro_two = GetComponent<TextMeshPro>();
      textmeshPro_three = GetComponent<TextMeshPro>();
      textmeshPro_four = GetComponent<TextMeshPro>();
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        string v1 = textmeshPro_one.GetParsedText();
        string v2 = textmeshPro_two.GetParsedText();
        string v3 = textmeshPro_three.GetParsedText();
        string v4 = textmeshPro_four.GetParsedText();
        
        if(v1 == "4" && v2 == "1" && v3 == "3" && v4 == "2")
        {
         security.SetActive(false);
         profile.SetActive(true);
         trans.SetActive(true);
         tm.SetActive(true);
         stats.SetActive(true);
         logo.SetActive(true);
         logout.SetActive(true);
         balance_body.SetActive(true);
                 }
       
        else{
            if(count==2){
            lck.SetActive(true);
            security.SetActive(false);
            }
            else{
            denied.SetActive(true);
            security.SetActive(false);
            count++;
            }
        }
        
    }
}
