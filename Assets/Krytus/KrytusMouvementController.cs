using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class KrytusMouvementController : MonoBehaviour
{
    public float MaxYOffset;
    public float MaxXOffset;
    public int delayTP;
    public Transform spawnPosition;
    public Animator animator;

    public GameObject projectileToInstantiate;

    private void Start()
    {
        StartCoroutine(Teleportation());
    }

    IEnumerator Teleportation()
    {
        while (true)
        {
            ProjectileInstantiate();
            yield return new WaitForSeconds(delayTP);

            animator.SetTrigger("Invisible");
            gameObject.GetComponent<Rigidbody2D>().simulated = false;
            yield return new WaitForSeconds(0.5f);
            
            var yOffset = Random.Range(-MaxYOffset, MaxYOffset);
            var xOffset = Random.Range(-MaxXOffset, MaxXOffset);

            Vector3 spawnOrigin = spawnPosition.position;

            gameObject.transform.position = spawnOrigin + new Vector3(xOffset, yOffset, 0);

            animator.SetTrigger("Visible");
            gameObject.GetComponent<Rigidbody2D>().simulated = true;
            yield return new WaitForSeconds(0.31f);
            animator.SetTrigger("Active");
            


        }
       
    }

    public void ProjectileInstantiate()
    {
        Instantiate(projectileToInstantiate, gameObject.transform.position, Quaternion.identity);
        
    }

}
