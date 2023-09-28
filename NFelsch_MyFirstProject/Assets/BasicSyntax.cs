
using UnityEngine;

public class BasicSyntax : MonoBehaviour

{
    void Start()
    {
        //this line is there to tell me the x position of my object
        
        /* Hi there!
         * this is two lines
         * */
        Debug.Log(Transform.position.x);

        if (Transform.position.y <= 5f)
        {
            Debug.Log(message: "I'm about to hit the ground!");
        }
    }
}