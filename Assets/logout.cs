using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class logout : MonoBehaviour
{
    
    public GameObject security;
    public TextMeshPro textmeshPro_one;
    public TextMeshPro textmeshPro_two;
    public TextMeshPro textmeshPro_three;
    public TextMeshPro textmeshPro_four;
    public GameObject logout_btn;
     public GameObject profile;
    public GameObject trans;
    public GameObject tm;
    public GameObject stats;
     public GameObject profile_b;
     public GameObject balance_body;
    public GameObject trans_b;
    public GameObject tm_b;
    public GameObject stats_b;
    public GameObject logo;

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
        textmeshPro_one.SetText("-");
        textmeshPro_two.SetText("-");
        textmeshPro_three.SetText("-");
        textmeshPro_four.SetText("-");
        security.SetActive(true);
        logout_btn.SetActive(false);
         profile.SetActive(false);
         trans.SetActive(false);
         tm.SetActive(false);
         stats.SetActive(false);
         profile_b.SetActive(false);
         balance_body.SetActive(false);
         trans_b.SetActive(false);
         tm_b.SetActive(false);
         stats_b.SetActive(false);
         logo.SetActive(false);
    }
}
