using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
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
                Debug.Log(hit.collider.gameObject.tag);
                GameController.Instance.PickObject(hit.collider.gameObject.tag);
                Debug.Log(hit.collider.gameObject.tag);
            }

            Debug.DrawRay(ray.origin, ray.direction * 2f, Color.blue);
        }

        if (hit.transform == null)
        {
            Debug.DrawRay(ray.origin, ray.direction * 2f, Color.red);           
        }
    }
}
