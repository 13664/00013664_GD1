using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsCharacterController : MonoBehaviour
{
    CharacterController2D character;
    Rigidbody2D rigidbody2D;
    [SerializeField] float offesetDistance = 1f;
    [SerializeField] float sizeOfInteractableArea = 1.2f;


    private void Awake()
    {
        character = GetComponent<CharacterController2D>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            UseTool();
        }

         
    }
    private void UseTool()
    {
        Vector2 position = rigidbody2D.position +character.lastMotionVector * offesetDistance;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders)
        {
            ToolKit hit = c.GetComponent<ToolKit>();
            if (hit != null)
            {
                hit.Hit();
                break;
            }
        }
    }
}
