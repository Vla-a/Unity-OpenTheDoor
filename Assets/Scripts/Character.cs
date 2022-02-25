using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private bool isActive;
    private Ray ray;
    private RaycastHit hit;   
    [SerializeField] private Camera playerCamera;
    [SerializeField] private LayerMask layerMask;
    void Update()
    {
        MyRay();
        DrawRay();
    }
    private void MyRay()
    {
        ray = playerCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    private void DrawRay()
    {
        if (Physics.Raycast(ray, out hit, 2f, layerMask))
        {          
            if (Input.GetMouseButtonDown(0))
            {                           
                
                if (hit.transform.TryGetComponent<Pickable>(out var obj))
                {
                    isActive = true;
                    obj.PickUp();
                }

                if (hit.transform.TryGetComponent(out Interaction interaction))
                {
                    interaction.Interract();
                }
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                //if(hit.transform.TryGetComponent(out  Interaction interaction))
                //{
                //    interaction.Interract();
                //}    
            }

            Debug.DrawRay(ray.origin, ray.direction * 2f, Color.blue);
        }

        if (hit.transform == null)
        {
            Debug.DrawRay(ray.origin, ray.direction * 2f, Color.red);
            if (Input.GetMouseButtonDown(0))
            {
                if (isActive)
                {                    
                    isActive = false;
                }
                   
            }                           
        }
    }
}
