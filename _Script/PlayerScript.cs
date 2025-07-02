using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Player Movement")]
    public float playerSpeed = 5f; // Speed of the player movement  

    [Header("Player Animation and Gravity")]
    public CharacterController cC;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    void playerMove()
    {
        // Get the input from the user
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if(direction.magnitude > 0.1f )
        {
            cC.Move(direction * playerSpeed * Time.deltaTime);
        }

    }
}
