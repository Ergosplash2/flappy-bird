using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class flyscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicscript logic;
    public bool flyIsAlive = true;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && flyIsAlive) 
        {
           
        myRigidbody.velocity = Vector2.up * flapStrength; 
            animator.SetBool("isjumping", true);
        }
       
        if(transform.position.y > 5.51 || transform.position.y < -5.51 ) 
            {
            logic.gameover();
        }

    }

   
    

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.gameover();
        flyIsAlive = false;
    }
}
