using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour {

	void FixedUpdate () {
		
        if (Input.GetButton("Fire1"))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {

                Debug.DrawRay(transform.position, transform.forward * 100f, Color.red);

                Health enemyHealth = hit.collider.gameObject.GetComponent<Health>();

                if ( enemyHealth != null)
                {
                    enemyHealth.loseHealth(5f);
                }


            }

        }

	}

}
