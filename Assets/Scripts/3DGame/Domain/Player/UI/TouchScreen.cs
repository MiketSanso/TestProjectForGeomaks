using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider != null)
            {
                if (hit.transform.GetComponent<Teleport>())
                    hit.transform.GetComponent<Teleport>().TouchTeleport();
            }
        }
    }
}
