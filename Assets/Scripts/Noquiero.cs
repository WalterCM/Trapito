using UnityEngine;
using System.Collections;

public class Noquiero : MonoBehaviour {
    private Animator animator;
    private float elapsedTime = 0;
    private bool animationRunning = false;
    private bool collides = false;
    void Update()
    {
        if (!animator)
            return;
   
        if (animationRunning)
        {
            elapsedTime += Time.deltaTime;

            foreach (AnimationClip clip in animator.runtimeAnimatorController.animationClips)
            {
                if (clip.name == "noquieroAnimation")
                {
                    if (elapsedTime > clip.length)
                    {
                        elapsedTime = 0;
                        animationRunning = false;
                        animator.SetBool("bedBorder", false);
                    }
                }
            }
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            //print("collides: " + collides.ToString());
            animator.SetBool("bedBorder", collides);
            animationRunning = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        animator = other.GetComponent<Animator>();
        collides = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        animator = other.GetComponent<Animator>();
        animator.SetBool("bedBorder", false);
        collides = false;
    }
}
