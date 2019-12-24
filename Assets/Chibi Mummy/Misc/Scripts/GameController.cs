using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{

    public Camera one;
    public Camera two;
    public AudioSource aud;
    public Text txtLV;
    /// <summary>
    /// thay đổi camera góc nhìn
    /// </summary>
    public void SwapCamera()
    {
        if (two.enabled == true)
        {
            one.enabled = true;
            two.enabled = false;
        }
        else
        {
            one.enabled = false;
            two.enabled = true;
        }
    }
    /// <summary>
    /// bắt đầu 
    /// </summary>
    void Start()
    {
        txtLV.text = "Level: " + SceneManager.GetActiveScene().buildIndex;

    }
    /// <summary>
    /// tăng giá trị khi đẩy hộp đúng
    /// </summary>
    public void Point()
    {
        GameObject[] box = GameObject.FindGameObjectsWithTag("Box") as GameObject[];
        GameObject[] trap = GameObject.FindGameObjectsWithTag("Trap") as GameObject[];
        int kq = 0;
        for (int i = 0; i < box.Length; i++)
            for (int j = 0; j < trap.Length; j++)
            {
                if ((box[i].transform.position.x == trap[j].transform.position.x)
                    && box[i].transform.position.z == trap[j].transform.position.z) kq++;
            }
        if (kq == box.Length)
        {
            Debug.Log("------------------------");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    /// <summary>
    /// tắt tiếng trong game
    /// </summary>
    public void Mute()
    {
        aud.enabled = false;
    }
    /// <summary>
    /// mở lại tiếng
    /// </summary>
    public void Vol()
    {
        aud.enabled = true;
    }
    /// <summary>
    /// reset lại màn chơi
    /// </summary>
    public void Reset_Scene()
    {
        Debug.Log("1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
