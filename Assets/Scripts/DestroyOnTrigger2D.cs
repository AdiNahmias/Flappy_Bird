using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTagEnemy;
   // [SerializeField] string triggeringTagNotEnemy;
    public float deadBird;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTagEnemy)
        {
            Destroy(this.gameObject);
        }


    }

    private void Update()
    {
        if (transform.position.y < deadBird)
        {
            Destroy(this.gameObject);
        }
        /* Just to show the enabled checkbox in Editor */
    }
}