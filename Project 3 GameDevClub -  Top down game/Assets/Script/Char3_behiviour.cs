using UnityEngine;

public class Char3_behiviour : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rigit;
    float hor;
    float ver;
    [SerializeField] float speed;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        rigit = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");
        anim.SetBool("isMoving", hor != 0 || ver != 0);
        if (hor != 0 || ver != 0) Moving();
    }

    void Moving()
    {
        anim.SetFloat("dirX", hor);
        anim.SetFloat("dirY", ver);
        Vector2 newPos = new Vector2(hor, ver);
        if (newPos.magnitude > 1) newPos.Normalize();
        newPos *= speed * Time.deltaTime;
        rigit.position += newPos;
    }
}
