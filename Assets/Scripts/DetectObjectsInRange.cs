using UnityEngine;

public class DetectObjectsInRange : MonoBehaviour
{
    // public Transform player;
    // Collider[] hitColliders = null;

    // Update is called once per frame
    void Update()
    {
        // Collider[] hitColliders = Physics.OverlapSphere(player.position, 10);
        // int noOfObjectsInRange = Physics.OverlapSphereNonAlloc(player.position, 100, hitColliders);

        // Debug.Log(noOfObjectsInRange);

        // Transform nearest = null;
        // float nearDist = float.PositiveInfinity;
        // for (int i = 0; i < hitColliders.Length; i++) {
        //     Vector3 offset = transform.position - hitColliders[i].transform.position;
        //     float thisDist = offset.sqrMagnitude;
        //     if(thisDist < nearDist) {
        //         nearDist = thisDist;
        //         nearest = hitColliders[i].transform;
        //     }
        // }
        // if(nearest != null) {
        //     Destroy(nearest);
        // }
    }
}
