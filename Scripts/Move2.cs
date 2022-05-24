using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Vertical") * 0.1f;
        float dz = -Input.GetAxis("Horizontal") * 0.1f;
        float dy = 0;
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.Space) && (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 0.5f)))
        {
            dy = 5;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
        Rigidbody rg = this.GetComponent<Rigidbody>();
        rg.AddForce(new Vector3(dx, dy, dz), ForceMode.VelocityChange);
    }
}
