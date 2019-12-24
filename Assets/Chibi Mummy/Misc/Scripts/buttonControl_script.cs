using UnityEngine;
using System.Collections;

public class buttonControl_script : MonoBehaviour 
{
    /// <summary>
    /// bắt đầu main Menu
    /// </summary>
	Animator anim;

	void Awake ()
	{
		anim = GetComponentInChildren<Animator>();
	}
    /// <summary>
    /// set CrippledWalk
    /// </summary>
	public void CrippledWalk ()
	{
		anim.SetBool("crippled", !(anim.GetBool("crippled")));
		anim.SetBool("isIdle", false);
	}
    /// <summary>
    /// set Idle
    /// </summary>
	public void Idle ()
	{
		anim.SetBool("isIdle", true);
		anim.SetBool("isRun", false);
		anim.SetBool("crippled", false);
		anim.SetBool("dancing", false);
	}
    /// <summary>
    /// set Run
    /// </summary>
	public void Run ()
	{
		anim.SetBool("isRun",!(anim.GetBool("isRun")));
		anim.SetBool("isIdle", false);

	}
    /// <summary>
    /// set Dance
    /// </summary>
	public void Dance()
	{
		anim.SetBool ("dancing", !(anim.GetBool("dancing")));
	}
}
