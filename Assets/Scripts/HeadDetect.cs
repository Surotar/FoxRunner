using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDetect : MonoBehaviour
{
    public GameObject enemy;
    public Animator animator;

    private void Start()
    {
        enemy = gameObject.transform.parent.gameObject;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Killed", true);
        AudioManager.instance.PlaySFX("enemy");
        StartCoroutine(ExecuteAfterTime(.5f));
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        Destroy(enemy);
    }
}
