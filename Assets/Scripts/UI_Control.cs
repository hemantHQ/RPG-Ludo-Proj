using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Control : MonoBehaviour
{
    [SerializeField] GameObject Logo;
    [SerializeField] GameObject Button_1;
    [SerializeField] GameObject Button_2;
    [SerializeField] GameObject Single_Panel;
    [SerializeField] GameObject Multi_Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Single_Button()
    {
        Logo.SetActive(false);
        Button_1.SetActive(false);
        Button_2.SetActive(false);
        Multi_Panel.SetActive(false);
        Single_Panel.SetActive(true);
    }
    public void Multi_Button()
    {
        Logo.SetActive(false);
        Button_1.SetActive(false);
        Button_2.SetActive(false);
        Single_Panel.SetActive(false);
        Multi_Panel.SetActive(true);
    }

    public void Back_Button()
    {
        Single_Panel.SetActive(false);
        Multi_Panel.SetActive(false);
        Logo.SetActive(true);
        Button_1.SetActive(true);
        Button_2.SetActive(true);
    }
}
