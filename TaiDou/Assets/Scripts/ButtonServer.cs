using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonServer : MonoBehaviour
{

    private Transform btnSelect;
    private Text textSelect;
    private Image imgSelect;

	// Use this for initialization
	void Start ()
    {
        btnSelect = transform.parent.Find("Button_select");
        textSelect = btnSelect.Find("Text").GetComponent<Text>();
        imgSelect = btnSelect.GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void OnClick()
    {
        imgSelect.sprite = transform.GetComponent<Image>().sprite;
        textSelect.text = transform.Find("Text").GetComponent<Text>().text;
        textSelect.color = transform.Find("Text").GetComponent<Text>().color;
    }
}
