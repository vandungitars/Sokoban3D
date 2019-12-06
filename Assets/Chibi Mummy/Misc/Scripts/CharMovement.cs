using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CharMovement : MonoBehaviour
{
    private Animator anim;
    public Rigidbody rb;
    private int huong;
    GameObject[] wall;
    GameObject[] box;
    List<GameObject> all;
    public float moveSpeed;
    /// <summary>
    /// Set thuộc tính animation
    /// </summary>
	void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
        anim.SetBool("isRun", true);
    }
    /// <summary>
    /// bắt đầu game
    /// </summary>
	void Start()
    {
        wall = GameObject.FindGameObjectsWithTag("Wall") as GameObject[];
        box = GameObject.FindGameObjectsWithTag("Box") as GameObject[];
        all = new List<GameObject>();
        foreach (GameObject w in wall)
        {
            GameObject tmp = w;
            all.Add(tmp);
        }
        foreach (GameObject b in box)
        {
            GameObject tmp = b;
            all.Add(tmp);
        }

    }
    void FixedUpdate()
    {
    }

    /// <summary>
    /// kiểm tra Trap tính điểm 
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        Rigidbody box_ = other.GetComponent<Rigidbody>();
        Vector3 movement;
        if (huong == 1)
        {
            movement = new Vector3(0, 0, 1f);
        }
        else if (huong == 3)
        {
            movement = new Vector3(0, 0, -1f);
        }
        else if (huong == 2)
        {
            movement = new Vector3(1f, 0, 0);
        }
        else
        {
            movement = new Vector3(-1f, 0, 0);
        }
        bool kiemtra = true;
        Vector3 next = box_.transform.position + movement;
        foreach (GameObject w in wall)
        {
            if (w.transform.position.x == next.x && w.transform.position.z == next.z) kiemtra = false;
        }
        foreach (GameObject w in box)
        {
            if (w.transform.position.x == next.x && w.transform.position.z == next.z) kiemtra = false;
        }
        if (kiemtra)
        {
            box_.MovePosition(box_.transform.position + movement);
        }
    }

    /// <summary>
    /// Di chuyển nhân vật
    /// </summary>
	void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
        if (Input.GetKeyDown("up"))
        {
            Vector3 movement = new Vector3(0, 0, 1f);
            bool kiemtra = true;
            Vector3 next = transform.position + movement;
            Vector3 next2 = transform.position + movement * 2;
            foreach (GameObject w in wall)
            {
                if (w.transform.position.x == next.x && w.transform.position.z == next.z) kiemtra = false;
            }
            foreach (GameObject a in all)
            {
                if (a.transform.position.x == next.x && a.transform.position.z == next.z)
                {
                    foreach (GameObject b in all)
                    {
                        if (b.transform.position.x == next2.x && b.transform.position.z == next2.z) kiemtra = false;
                    }
                }
            }
            if (kiemtra)
            {
                //rb.MovePosition(transform.position + movement);
                if (huong != 1)
                {
                    Vector3 tmp = transform.rotation.eulerAngles;
                    tmp.y = 0f;
                    transform.rotation = Quaternion.Euler(tmp);
                    huong = 1;
                }
            }
        }
        if (Input.GetKeyDown("down"))
        {
            Vector3 movement = new Vector3(0, 0, -1f);
            bool kiemtra = true;
            Vector3 next = transform.position + movement;
            Vector3 next2 = transform.position + movement * 2;
            foreach (GameObject w in wall)
            {
                if (w.transform.position.x == next.x && w.transform.position.z == next.z) kiemtra = false;
            }
            foreach (GameObject a in all)
            {
                if (a.transform.position.x == next.x && a.transform.position.z == next.z)
                {
                    foreach (GameObject b in all)
                    {
                        if (b.transform.position.x == next2.x && b.transform.position.z == next2.z) kiemtra = false;
                    }
                }
            }
            if (kiemtra)
            {
                //rb.MovePosition(transform.position + movement);
                if (huong != 3)
                {
                    Vector3 tmp = transform.rotation.eulerAngles;
                    tmp.y = 180f;
                    transform.rotation = Quaternion.Euler(tmp);
                    huong = 3;
                }
            }
        }
        if (Input.GetKeyDown("left"))
        {
            Vector3 movement = new Vector3(-1f, 0, 0);
            bool kiemtra = true;
            Vector3 next = transform.position + movement;
            Vector3 next2 = transform.position + movement * 2;
            foreach (GameObject w in wall)
            {
                if (w.transform.position.x == next.x && w.transform.position.z == next.z) kiemtra = false;
            }
            foreach (GameObject a in all)
            {
                if (a.transform.position.x == next.x && a.transform.position.z == next.z)
                {
                    foreach (GameObject b in all)
                    {
                        if (b.transform.position.x == next2.x && b.transform.position.z == next2.z) kiemtra = false;
                    }
                }
            }
            if (kiemtra)
            {
                //rb.MovePosition(transform.position + movement);
                if (huong != 4)
                {
                    Vector3 tmp = transform.rotation.eulerAngles;
                    tmp.y = -90f;
                    transform.rotation = Quaternion.Euler(tmp);
                    huong = 4;
                }
            }
        }
        if (Input.GetKeyDown("right"))
        {
            Vector3 movement = new Vector3(1f, 0, 0);
            bool kiemtra = true;
            Vector3 next = transform.position + movement;
            Vector3 next2 = transform.position + movement * 2;
            foreach (GameObject w in wall)
            {
                if (w.transform.position.x == next.x && w.transform.position.z == next.z) kiemtra = false;
            }
            foreach (GameObject a in all)
            {
                if (a.transform.position.x == next.x && a.transform.position.z == next.z)
                {
                    foreach (GameObject b in all)
                    {
                        if (b.transform.position.x == next2.x && b.transform.position.z == next2.z) kiemtra = false;
                    }
                }
            }
            if (kiemtra)
            {
                //rb.MovePosition(transform.position + movement);
                if (huong != 2)
                {
                    Vector3 tmp = transform.rotation.eulerAngles;
                    tmp.y = 90f;
                    transform.rotation = Quaternion.Euler(tmp);
                    huong = 2;
                }
            }
        }
    }
}
