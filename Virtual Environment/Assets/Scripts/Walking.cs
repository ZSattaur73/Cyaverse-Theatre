using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float speed;
    public Transform character;
    public Transform waypoint1;
    public Transform waypoint2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        character.position = Vector3.MoveTowards(character.position, waypoint2.transform.position, speed * Time.deltaTime);
        
        if(character.position == waypoint2.position)
        {
            character.position = waypoint1.position;
        }
    }
}
