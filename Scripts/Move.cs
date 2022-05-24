using System.Collections;
using System.Collections.Generic;
using Redcode.Extensions;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Move : MonoBehaviour
{
    int x = 0, z = 0, y = 0;
    float speed = 2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
            z = 1;
        else 
            if (Input.GetKeyDown(KeyCode.D))
                z = -1;
        if (Input.GetKeyDown(KeyCode.W)) 
            x = 1;
        else 
            if (Input.GetKeyDown(KeyCode.S))
                x = -1;
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
        if (Input.GetKeyUp(KeyCode.A) && z == 1 || Input.GetKeyUp(KeyCode.D) && z == -1) 
            z = 0;
        if (Input.GetKeyUp(KeyCode.S) && x == -1 || Input.GetKeyUp(KeyCode.W) && x == 1) 
            x = 0;
        if (Input.GetKeyUp(KeyCode.Space) && this.transform.position.y <= 0.5f)
            y = 1;
        if (this.transform.position.y > 1)
            y = -1;
        if (y == -1 && this.transform.position.y < 0.5f)
            y = 0;
        this.transform.SetLocalPositionXZ(this.transform.position.x + x * Time.deltaTime * speed, this.transform.position.z + z * Time.deltaTime * speed);
        this.transform.SetLocalPositionY(this.transform.position.y + y * Time.deltaTime * 2);
    }
}
