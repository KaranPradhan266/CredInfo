using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class cancel : MonoBehaviour
{
    
    public GameObject security;
    public TextMeshPro textmeshPro_one;
    public TextMeshPro textmeshPro_two;
    public TextMeshPro textmeshPro_three;
    public TextMeshPro textmeshPro_four;

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
    }
}
