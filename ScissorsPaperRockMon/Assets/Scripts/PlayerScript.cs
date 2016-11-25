using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
    public GridCell curCell;
    public float speed = 5;
    public bool m_isAxisInUse = false;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, curCell.transform.position, speed * Time.deltaTime);
        Movement();
	}

    void Movement()
    {
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            InvokeRepeating("MoveUp", 1, 1);
        }

        if (Input.GetAxisRaw("Vertical") == 0)
        {
            CancelInvoke();
        }
    }

    public void MoveUp()
    {
        //find the cell that is up from where we are?
        var newy = curCell.y + 1;

        var potentialUpCell = curCell.myGrid.GetCellAtIndex(curCell.x, newy);

        if (potentialUpCell != null)
        {
            curCell = potentialUpCell;
        }
    }
}


