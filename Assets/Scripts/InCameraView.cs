using UnityEngine;

public class InCameraView : MonoBehaviour
{

    Camera cam;
    MeshRenderer rend;
    Plane[] cameraFrustum;
    Collider coll;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rend = GetComponent<MeshRenderer>();
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        var bounds = coll.bounds;
        cameraFrustum = GeometryUtility.CalculateFrustumPlanes(cam);   
        if (GeometryUtility.TestPlanesAABB(cameraFrustum, bounds)) {
            rend.sharedMaterial.color = Color.blue;
        } else {
            rend.sharedMaterial.color = Color.red;
        }
    }
}
