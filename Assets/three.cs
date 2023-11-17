using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class three : MonoBehaviour
{
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
        string v1 = textmeshPro_one.GetParsedText();
        string v2 = textmeshPro_two.GetParsedText();
        string v3 = textmeshPro_three.GetParsedText();
        string v4 = textmeshPro_four.GetParsedText();
        
        if(v1 == "-"){
         textmeshPro_one.SetText("3");

        }
        else if(v2 == "-"){
         textmeshPro_two.SetText("3");
        }
        else if(v3 == "-"){
         textmeshPro_three.SetText("3");
        }
        else{
        textmeshPro_four.SetText("3");
        }
    }
}
