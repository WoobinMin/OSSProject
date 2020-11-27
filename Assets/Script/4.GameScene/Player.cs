using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rigi;
    private CapsuleCollider2D coll;
    private SpriteRenderer sr;
    private Delay hpdelay;
    private Delay hitdelay;

    public LayerMask groundLayer;
    public AudioSource[] sounds;


    private bool canMove = true;
    private bool canJump = true;
    private bool canHit = true;
    private bool checkGround = true;

    public float speed;
    public float jumppower;

    private int hp;
    public int HP { set => hp = value; get => hp; }


    void Start()
    {
        hp = 100 + CharacterMgr.Instance.HPUpgrade * 10;
        hpdelay.curTime = 0f;
        hpdelay.lastTime = 1f;
        hitdelay.curTime = 0f;
        hitdelay.lastTime = 2f;

        anim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (canMove) MoveMent();
        if (hp > 0) Delays();
        else if(hp <= 0)
        {
            GameMgr.Instance.GameEnd();
        }
    }

    private void MoveMent()
    {
        this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (Physics2D.Raycast(this.transform.position, Vector2.down, 1f, groundLayer.value) && checkGround)
        {
            anim.SetBool("isJump", false);
            canJump = true;

        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && canJump)
        {
            anim.SetBool("isJump", true);
            canJump = false;
            checkGround = false;
            rigi.velocity = new Vector2(0, jumppower);
            sounds[0].Play();
        }

        if (Input.GetKey(KeyCode.DownArrow) && !anim.GetBool("isJump"))
        {
            if(!anim.GetBool("isSlide"))
                sounds[1].Play();
            anim.SetBool("isSlide", true);
            coll.direction = CapsuleDirection2D.Horizontal;
            coll.offset = new Vector2(0.04f, -0.05f);
            coll.size = new Vector2(1.44f, 0.9f);
        }
        else
        {
            anim.SetBool("isSlide", false);
            coll.direction = CapsuleDirection2D.Vertical;
            coll.offset = new Vector2(0f, 0f);
            coll.size = new Vector2(1.06f, 1.62f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle" && canHit) {
            if (this.gameObject.name == "CatPrefab(Clone)")
                hp -= 5;
            else
                hp -= 10;

            canHit = false;
            sr.color = new Color(1, 1, 1, 0.5f);
            sounds[2].Play();
        }
        else if(collision.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            if(this.gameObject.name == "BoyPrefab(Clone)")
                GameMgr.Instance.GameCoin += 2;
            else
                GameMgr.Instance.GameCoin += 1;
        }
        else if (collision.tag == "Star")
        {
            collision.gameObject.SetActive(false);
            GameMgr.Instance.GameEnd();
        }
        else if (collision.tag == "Water")
        {
            hp = 0;
        }

    }

    private void Delays()
    {
        if(hpdelay.curTime > hpdelay.lastTime)
        {
            hp -= 1;
            hpdelay.curTime = 0f;
        }
        else
            hpdelay.curTime += Time.deltaTime;

        if(hitdelay.curTime > hitdelay.lastTime)
        {
            sr.color = new Color(1, 1, 1, 1f);
            hitdelay.curTime = 0f;
            canHit = true;
        }
        else if(!canHit)
            hitdelay.curTime += Time.deltaTime;
    }

    

    // animation fuction

    private void JumpFalse()
    {
        checkGround = true;
    }
}
