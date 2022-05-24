using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
    private AssetBundle bundle;
    private string[] paths;
    // Start is called before the first frame update
    void Start () {
        print(this.transform.GetChild(0));
		Button btn = this.transform.GetChild(0).GetComponent<Button>();
		Button btn1 = this.transform.GetChild(1).GetComponent<Button>();
		btn.onClick.AddListener(OnClickFirst);
		btn1.onClick.AddListener(OnClickSecond);
	}

	void OnClickFirst(){
        SceneManager.LoadScene("lab1");
	}
    void OnClickSecond(){
        SceneManager.LoadScene("lab2");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
