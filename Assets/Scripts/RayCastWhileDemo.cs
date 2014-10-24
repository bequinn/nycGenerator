using UnityEngine;
using System.Collections;

public class RayCastWhileDemo : MonoBehaviour {
	
	public Transform originalBlueprint;
	int howManyCopies =0;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit = new RaycastHit ();
		
		if (Physics.Raycast (ray, out rayHit, 1000f) && Input.GetMouseButtonDown(0)) {

				while(howManyCopies < 1){ //make sure it's a bounded loop
					//Instantiate(originalBlueprint, new Vector3 (0, 0, howManyCopies * 2.0F), Random.rotation);
//					Instantiate(originalBlueprint, rayHit.point + rayHit.normal, Random.rotation);
//					howManyCopies++;
				transform.LookAt(rayHit.point);
				Instantiate(originalBlueprint, rayHit.point + rayHit.normal, Quaternion.identity);
				howManyCopies++;
//				yield return new WaitForSeconds(0.1f); //tells unity to take a break
			}
		}
	}
}
