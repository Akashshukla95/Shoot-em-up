using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyWalk : MonoBehaviour
{
    public AIPath aiPath;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            animator.SetBool("isWalkingLeft",true);
        }
        else if(aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            animator.SetBool("isWalkingRight", true);
        }
        else if(aiPath.desiredVelocity.y >= 0.01f)
        {
            transform.localScale = new Vector3(1f, -1f, 1f);
            animator.SetBool("isWalkingDown", true);
        }
         else if(aiPath.desiredVelocity.y <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            animator.SetBool("isWalkingUp", true);
        }
    }
}
