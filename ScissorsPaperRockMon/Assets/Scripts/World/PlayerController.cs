using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    //PLAYER ROTATION IS IN THE ROTATION SCRIPT
    //Movement
    public GridCell curCell;
    public float speed = 150;

    //Player Feedback
    public AudioSource WallHit;

    //Animation
    public Animator anim;
    public GameObject UnityChan; //Finds unity chan


    // Use this for initialization

    //Lower Player
    public GameObject LowerPlayer;
    public GameObject UpperPlayer;

    // Use this for initialization
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "CaveBottom")
        {
            LowerPlayer.SetActive(false);
            UpperPlayer.SetActive(true);
        }
    }
    void Start()
    {
        InvokeRepeating("Movement", .8f, .20f); //Calls movement only every so often
        WallHit = GetComponent<AudioSource>(); //Grabs audio file attached to object
        anim = UnityChan.GetComponent<Animator>(); //Grabs the animator
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, curCell.transform.position, speed * Time.deltaTime);
        if (transform.position == curCell.transform.position)//If the players position is the same as its curCell
        {
            anim.SetFloat("Speed", .0f);//Play the animation for no movement
        }
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

        if (Input.GetKey(KeyCode.Slash))
        {
            anim.SetBool("Rest", true);//Plays rest animation
        }
        else
        {
            anim.SetBool("Rest", false);//stops rest animation if nothing is pressed
        }
    }

    public void MoveUp()
    {
        //animation
        anim.SetFloat("Speed", .5f);

        //find the cell that is up from where we are?
        var newy = curCell.y + 1;

        var potentialUpCell = curCell.myGrid.GetCellAtIndex(curCell.x, newy);

        if (potentialUpCell != null)
        {

            curCell = potentialUpCell;
        }
        else
        {
            WallHit.Play(); //plays wall hit sound if the player cant go there
        }
    }

    public void MoveDown()
    {
        //animation
        anim.SetFloat("Speed", .5f);

        //find the cell that is up from where we are?
        var newy = curCell.y - 1;

        var potentialUpCell = curCell.myGrid.GetCellAtIndex(curCell.x, newy);

        if (potentialUpCell != null)
        {
            curCell = potentialUpCell;
        }
        else
        {
            WallHit.Play();//Plays audio file when a wall or non movable area is encountered
        }
    }

    public void MoveRight()
    {
        //animation
        anim.SetFloat("Speed", .5f);

        //find the cell that is up from where we are?
        var newx = curCell.x + 1;

        var potentialHorizontalCell = curCell.myGrid.GetCellAtIndex(newx, curCell.y);

        if (potentialHorizontalCell != null)
        {
            curCell = potentialHorizontalCell;
        }
        else
        {
            WallHit.Play();//Plays audio file when a wall or non movable area is encountered
        }
    }

    public void MoveLeft()
    {
        //animation
        anim.SetFloat("Speed", .5f);

        var newx = curCell.x - 1;

        var potentialHorizontalCell = curCell.myGrid.GetCellAtIndex(newx, curCell.y);

        if (potentialHorizontalCell != null)
        {
            curCell = potentialHorizontalCell;
        }
        else
        {
            WallHit.Play();//Plays audio file when a wall or non movable area is encountered
        }
    }
}
