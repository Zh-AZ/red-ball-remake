using System;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class LockPikingGame : MonoBehaviour
{
    float pickPosition;

    public float PickPosition
    {
        get { return pickPosition; }
        set 
        { 
            pickPosition = value; 
            pickPosition = Mathf.Clamp(pickPosition, 0f, 1f);
        }
    }

    [SerializeField] private float pickSpeed = 3f;

    float cylinderPosition;
    public float CylinderPosition
    {
        get { return cylinderPosition; }
        set 
        { 
            cylinderPosition = value; 
            cylinderPosition = Mathf.Clamp(cylinderPosition, 0f, MaxRotationDistance);
        }
    }

    [SerializeField] private float cylinderRotationSpeed = 0.4f;
    [SerializeField] float cylinderRetentionSpeed = 0.2f;

    Animator animator;
    bool paused = false;

    float targetPosition = 0;

    [SerializeField] float leanency = 0.1f;
    float MaxRotationDistance
    {
        get
        {
            return 1f - Mathf.Abs(targetPosition - PickPosition) + leanency;
        }
    }

    bool shaking;
    float tension = 0f;
    [SerializeField] float tensionMultiplicator = 1f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        Reset();

        targetPosition = UnityEngine.Random.value;
    }

    public void Reset()
    {
        CylinderPosition = 0f;
        PickPosition = 0.5f;
        tension = 0f;
        paused = false;
    }

    private void Update()
    {
        if (paused) { return; } 

        if (Input.GetAxisRaw("Vertical") == 0)
        { 
            Pick();
        }

        Shaking();
        Cyllinder();
        UpdateAnimator();
    }

    private void Shaking()
    {
        shaking = MaxRotationDistance - CylinderPosition < 0.03f;

        if (shaking)
        {
            tension += Time.deltaTime * tensionMultiplicator; 
            
            if (tension > 1f)
            {
                PickBreack();
            }
        }
    }

    private void PickBreack()
    {
        Debug.Log("Pick broke!");
        Reset();
    }

    private void Cyllinder()
    {
        CylinderPosition -= cylinderRetentionSpeed * Time.deltaTime;
        CylinderPosition += Mathf.Abs(Input.GetAxisRaw("Vertical")) * Time.deltaTime * cylinderRotationSpeed;
        
        if (CylinderPosition > 0.98f)
        {
            Win();
        }
    }

    private void Win()
    {
        paused = true;
        Debug.Log("You picked the lock!");
    }

    private void Pick()
    {
        PickPosition += Input.GetAxisRaw("Horizontal") * Time.deltaTime * pickSpeed;
    }
    
    private void UpdateAnimator()
    {
        animator.SetFloat("PickPosition", pickPosition);
        animator.SetFloat("LockOpen", cylinderPosition);
        animator.SetBool("Shake", shaking);
    }
}

