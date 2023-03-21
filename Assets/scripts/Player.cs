//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float move_speed;
    public Rigidbody2D rb_2d;
    public float jump_force;
    public SpriteRenderer spr;
    public int score;
    public Ui_ ui_script;
    public Animator anim;
    private float dirX;
    public Button leftButton, rightButton, jumpButton;
    public static Player _instance;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb_2d = GetComponentInParent<Rigidbody2D>();
        Debug.Log(rb_2d);
        
        leftButton.onClick.AddListener(() => { Move(1); });
        rightButton.onClick.AddListener(() => { Move(-1); });
        jumpButton.onClick.AddListener(() =>Jump());
    }
    void Jump()
    {
        if (!Is_grounded())
        {
            return;
        }
        rb_2d.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
    }
    private void FixedUpdate()
    {
        dirX = Input.GetAxis("Horizontal");

        Move((int)dirX);    }
    public  void Move(int dir)
    {
                   rb_2d.velocity = new Vector2(dir * move_speed, rb_2d.velocity.y);
                    

    }
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && Is_grounded())
        {
            rb_2d.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
        }

        if (rb_2d.velocity.x > 0)
        {
            spr.flipX = false;
        }
        if (rb_2d.velocity.x < 0)
        {
            spr.flipX = true;
        }
        UpdateAnimationUpdate();

    }
    private void UpdateAnimationUpdate()
    {
        

        if (dirX > 0f)
        {
            Debug.Log(dirX);
            anim.SetBool("runing", true);

        }
        else if (dirX < 0f)
        {
            Debug.Log(dirX);
            anim.SetBool("runing", true);
        }
        else
        {
            anim.SetBool("runing", false);
        }

    }



    bool Is_grounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, -0.1f, 0), Vector2.down, 0.2f);
        return hit.collider != null;
    }

    //public void GameOver()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}

    public void Add_score(int amount)
    {
        score += amount;
        ui_script.Set_score_text(score);
    }

}

