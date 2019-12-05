using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    // Use this for initialization
    public GameObject gameController;
    void Start()
    {

    }
    /// <summary>
    /// khi Trigger kiểm tra đúng tăng giá trị đẩy hộp đúng
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //gameController.GetComponent<GameController>().Point();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
