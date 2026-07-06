using UnityEngine;

public class DogFollowCamera : MonoBehaviour
{
    public float speed = 2f;
    public float stopDistance = 5f;

    private Transform cam;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (animator == null)
            Debug.LogError("Animator NICHT gefunden");
        else
            Debug.Log("Animator gefunden: " + animator.name);

        cam = Camera.main.transform;
    }

    void Update()
    {
        Vector3 target = cam.position;
        target.y = transform.position.y;

        float distance = Vector3.Distance(transform.position, target);

        if (distance > stopDistance)
        {
            transform.LookAt(target);

            transform.position = Vector3.MoveTowards(
                transform.position,
                target,
                speed * Time.deltaTime
            );

            // Laufanimation direkt starten
            animator.Play("Walking01");
        }
        else
        {
            // Atemanimation
            animator.Play("Breathing");
        }
    }
}