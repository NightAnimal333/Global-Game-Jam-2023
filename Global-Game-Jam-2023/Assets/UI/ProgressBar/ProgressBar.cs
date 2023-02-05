using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image knowledge;

    public Slider slider;
    public float maxKnow = 0;
    
    void Awake()
    {
        slider = GameObject.FindObjectOfType<Slider>();     
    }

    // Update is called once per frame
    void Update()
    {
        if (maxKnow < 100)
        {
            
            if (Input.GetKeyDown("down"))
            {
                print("update");
                IncreaseKnowledge(20);
            }
        }
       
    }
    
    void IncreaseKnowledge(int val)
    {
        //print("increase");
        print("slider val " + slider.value);
        slider.value += (float)val;
        //knowledge.fillAmount = (float)(100);
        maxKnow += val;
        print(maxKnow);
    }

}
