using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_login : MonoBehaviour
{
    private Text btn_name;
    private Text input_name;

	// Use this for initialization
	void Start ()
    {
        btn_name = GameObject.Find("btn_name").transform.Find("Button").Find("Text").GetComponent<Text>();
        input_name = transform.parent.Find("Input_name").Find("Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    public void OnClick()
    {
        btn_name.text = input_name.text;
    }
}
