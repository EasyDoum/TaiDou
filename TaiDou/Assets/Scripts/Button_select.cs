using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button_select : MonoBehaviour
{
    private Text btn_server;
    private GameObject bg_server;

	// Use this for initialization
	void Start ()
    {
        btn_server = GameObject.Find("btn_server").transform.Find("Button").Find("Text").GetComponent<Text>();
        bg_server = GameObject.Find("bg_server");
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnClick()
    {
        bg_server.SetActive(false);
        btn_server.text = transform.Find("Text").GetComponent<Text>().text;
        btn_server.color = transform.Find("Text").GetComponent<Text>().color;

    }
}
