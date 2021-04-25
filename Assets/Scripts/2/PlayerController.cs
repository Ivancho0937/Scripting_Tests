using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2.0f;
    private float moveInputX;
    private float moveInputZ;
    public float jumpForce = 50.0f;
    public Animator anim;
    public LayerMask groundLayerMask;
    public bool grounded = false;


    private Vector3 initialposition;
    private Vector3 initialVelocity;

    static PlayerController Playerinstance;

    private void Awake()
    {
        //"this" means the object that unity create
        Playerinstance = this;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
        initialposition = rb.position;
        initialVelocity = rb.velocity;


        

    }

    public static PlayerController GetInstance()
    {
        return Playerinstance;
    }

    
    public void StartGame()
    {
      
       // GameManager.GetInstance();
        rb.position = initialposition;
        rb.velocity = initialVelocity;

        
    }

    // Update is called once per frame
    void Update()
    {
        
        GameState currstate = GameManager.GetInstance().currentGameState;

        

        if (currstate == GameState.InGame)
        {
            moveInputX = Input.GetAxis("Horizontal");
            moveInputZ = Input.GetAxis("Vertical");
            movimiento();
        }

        


    }

    private void FixedUpdate()
    {
        bool canJump = GameManager.GetInstance().currentGameState == GameState.InGame;
        // GameState currstate = GameManager.GetInstance().currentGameState;
        grounded = isOntheground();
        
        if (canJump && Input.GetButton("Jump") && isOntheground() )
        {
            jump();
        }
    }
    void movimiento()
    {

        rb.velocity = new Vector3(moveInputX * speed, rb.velocity.y, moveInputZ * speed);
        
    }

    bool isOntheground()
    {
        return Physics.Raycast(this.transform.position, Vector3.down, 1.0f, groundLayerMask.value);
    }
    void jump()
    {
        rb.AddForce(transform.up * jumpForce);
    }
    public void KillPlayer()
    {
        //  anim.SetBool("isAlive", false);
        GameManager.GetInstance().GameOver();


    }
    

    public void salud(int numero)
    {
        

        GameManager.GetInstance().vida -= numero;
        anim.SetTrigger("damage");
        if (GameManager.GetInstance().vida <= 0)
        {
            GameManager.GetInstance().GameOver();

        }
        

    }
    
}
