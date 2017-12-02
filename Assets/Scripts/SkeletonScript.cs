using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SkeletonScript : LifeScript {

	private NavMeshAgent agent;
	public Transform Destination;
	private Animator animator;
	private bool onAttack;

	void Start(){
		agent = GetComponent<NavMeshAgent>();
		onAttack = false;
	}

	public override void Damage(int d)
	{
		base.Damage(d);
		GetComponent<Animator>().SetInteger("Pv", Pv);
		Debug.Log(Pv);
		if (Pv <= 0) 
		{
			GetComponent<BoxCollider>().enabled = false;
			Destroy (this);
		}
	}

	void OnTriggerEnter(Collider c)
	{
		onAttack = true;
        animator.SetBool("onAttack", onAttack);
        agent.isStopped = true;
	}

	void OnTriggerStay(Collider c)
	{
		if (c.tag == "Player")
        {
            if (c.gameObject.GetComponent<LifeScript>())
            {
                c.gameObject.GetComponent<LifeScript>().Damage(5);
            }
        }
	}

	void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            onAttack = false;
            animator.SetBool("onAttack", onAttack);
            agent.isStopped = false;
        }
    }

	void Update(){
		agent.destination = Destination.position;
	}
}
