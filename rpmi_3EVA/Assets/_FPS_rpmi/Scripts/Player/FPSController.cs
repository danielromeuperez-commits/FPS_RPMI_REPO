using UnityEngine;
using UnityEngine.InputSystem;

public class FPSController : MonoBehaviour
{
    #region General Variables
    [Header("Movimiento & Mirar")]
    [SerializeField] GameObject camHolder; //ref al obj q tiene como hijo la cámara (rota por la cámara)
    [SerializeField] float speed = 5;
    [SerializeField] float sprintSpeed = 8;
    [SerializeField] float crounchSpeed = 3;
    [SerializeField] float maxForce = 1; //Fuerza max de aceleración
    [SerializeField] float sesitivity = 0.1f; //Sensibilidad para input

    [Header("Player State Bools")]
    [SerializeField] bool isSprinting;
    [SerializeField] bool isCrouching;
    #endregion

    //Variables de ref privadas:
    Rigidbody rb; //ref al rb del PL

    //Variables para input:
    Vector2 MoveInput;
    Vector2 lookInput;
    float lookRotation;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //lock cursor ratón
        Cursor.lockState = CursorLockMode.Locked; //Mueve curson a centro
        Cursor.visible = false; //Oculta cursor
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region INPUT METHODS
    public void OnMove(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {

    }
    public void OnCrouch(InputAction.CallbackContext context)
    {

    }
    public void OnSprint(InputAction.CallbackContext context)
    {

    }
    #endregion
}
