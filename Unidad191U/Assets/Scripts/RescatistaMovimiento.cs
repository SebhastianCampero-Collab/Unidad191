using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class RescatistaMovimiento : MonoBehaviour
{
    private NavMeshAgent agente;

    private void Start()
    {
        agente = GetComponent<NavMeshAgent>();

        if (agente != null)
        {
            agente.enabled = false;
            transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
            agente.enabled = true;
        }
    }
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit choque;

            if (Physics.Raycast(rayo, out choque)) 
            {
                agente.SetDestination(choque.point);
            }
        }
    }
}   
