using UnityEngine;
using System.Collections;

public class GridMover : MonoBehaviour {

    public GridCell curCell;
    public float speed = 5;

    public void MoveUp()
    {
        //find the cell that is up from where we are?
        var newy = curCell.y + 1;

        var potentialUpCell = curCell.myGrid.GetCellAtIndex(curCell.x, newy);

          if(potentialUpCell != null)
         {
        curCell = potentialUpCell;
         }
    }

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("MoveUp", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // InvokeRepeating("MoveUp", 1, 1);
        transform.position = Vector3.MoveTowards(transform.position, curCell.transform.position, speed * Time.deltaTime);
    }
}
