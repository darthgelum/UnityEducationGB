using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesFollow : MonoBehaviour
{
    public float speed = 5;
    public HeroController hero;
    private bool m_FacingRight = true;
    public int degreesToFlip = 80;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = hero.eyesSlot.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = hero.eyesSlot.position;
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (Mathf.Abs(angle) > degreesToFlip && m_FacingRight || Mathf.Abs(angle) < degreesToFlip && !m_FacingRight)
        {
            Flip();
        }
        //if (Mathf.Abs(angle) < 60)
        {
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        }
    }
    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.y *= -1;
        transform.localScale = theScale;
    }
}
