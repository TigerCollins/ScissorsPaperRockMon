using UnityEngine;
using System.Collections;

public class UpperRotaterScript : MonoBehaviour {
    
    void Start ()
    {
	
	}

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveDown();
        }
    }

    public void MoveUp()
    {
        transform.localEulerAngles = new Vector3(0, 180, 0);
    }

    public void MoveDown()
    {
        transform.localEulerAngles = new Vector3(0, 0, 0);
    }

    public void MoveRight()
    {
        transform.localEulerAngles = new Vector3(0, 270, 0);
    }

    public void MoveLeft()
    {
        transform.localEulerAngles = new Vector3(0, 90, 0);
    }
}
