using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        Movement();

    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
    }

    public void MoveUp()
    {
        transform.localEulerAngles = new Vector3(0, 0, 0);
    }

    public void MoveDown()
    {
        transform.localEulerAngles = new Vector3(0, 180, 0);
    }

    public void MoveRight()
    {
        transform.localEulerAngles = new Vector3(0, 90, 0);
    }

    public void MoveLeft()
    {
        transform.localEulerAngles = new Vector3(0, 270, 0);
    }
}
