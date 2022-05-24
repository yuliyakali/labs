using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject text;
    [SerializeField]
    GameObject inputfield;
    [SerializeField]
    GameObject button;
    [SerializeField]
    string txt;
    bool flag = false;
    void Start()
    {
		button.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update() 
    {
        if (flag) 
        {
            if (Input.GetKeyDown(KeyCode.E) && !inputfield.GetComponent<TMP_InputField>().isFocused)
                if (!text.activeSelf) {
                    text.SetActive(true);
                    button.SetActive(true);
                    inputfield.SetActive(true);
                    text.GetComponent<TextMeshProUGUI>().text = txt;
                    inputfield.GetComponent<TMP_InputField>().text = "";
                } else {
                    text.SetActive(false);
                    button.SetActive(false);
                    inputfield.SetActive(false);
                }
        } 
    }
    void OnTriggerEnter() 
    {
        flag = true;
    }
    void OnTriggerExit() 
    {
        flag = false;
        text.SetActive(false);
        button.SetActive(false);
        inputfield.SetActive(false);
    }
    void OnClick() 
    {
        txt = inputfield.GetComponent<TMP_InputField>().text;
        text.GetComponent<TextMeshProUGUI>().text = txt;
    }
}
