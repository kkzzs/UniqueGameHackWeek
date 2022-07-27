using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float slowRate;
    public Animator anim;

    void Start()
    {
        
    }

    void Update()
    {
        PlayerMovement();
        

    }
    /// Movement control, called once per frame.along with animation transition
    private void PlayerMovement()
     {
        //Handle Input
         float _horizontal,_vertical,_slowMode;
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
        _slowMode = Input.GetAxis("SlowMode");
        
        //Refresh the position
        Vector3 _direction = new Vector3(_horizontal, _vertical, 0).normalized;
        if(_slowMode > 0.5f)
          {
            transform.position=transform.position+(speed* slowRate) * Time.deltaTime * _direction;
          }
          else
          {
            transform.position=transform.position+speed * Time.deltaTime * _direction;
          }
          //animation transiton
          anim.SetFloat("Moving",_horizontal);
      }
}
