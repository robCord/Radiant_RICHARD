using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platformer : MonoBehaviour
{
    //variables for functions
    public int maxJump;
    private int currentJumps = 0;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;

    public float distanceToGround;
    private AudioSource source;

    public float jumpForce;
    public float speed;
    Rigidbody2D rb;
    public Transform spawnPoint;

    public int lives;
    public Text livesCounter;

    public MainMenu menu;


    // Start is called before the first frame update
    void Start()
    {//condenses code
        rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();

        livesCounter.text = "x " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //calls function for gameplay, jump, move and can jump
        if (canJump() == true)
        {
            currentJumps = 0;
        }
        move();
        Jump();
    }
    //allows player to move sideways
    void move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }
    //allows player to jump
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentJumps < maxJump)
            {
                currentJumps++;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
            //plays sound effect for jumping
            source.Play();
        }
    }
    //detects if player is grounded to allow jump
    private bool canJump()
    {
        Debug.DrawRay(transform.position, Vector2.down * distanceToGround, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distanceToGround);
        if (hit == false)
        {

            return false;
        }
        else
        {

            return true;
        }
    }
    //when the player dies spawn is moved function also switches scenes for dead scene
    public void Die()
    {
        if (lives > 0)
        {
            transform.position = spawnPoint.position;
            lives--;
            livesCounter.text = "x " + lives.ToString();
        }
        else
        {
            menu.playGame("DeadScene");
        }
    }
    // calls win scene for condition meet
    public void Victory()
    {
        menu.playGame("WinScene");
    }
}
