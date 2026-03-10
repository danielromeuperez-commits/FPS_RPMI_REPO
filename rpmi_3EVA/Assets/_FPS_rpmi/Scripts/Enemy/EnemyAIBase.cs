using UnityEngine;
using UnityEngine.AI; //Libreria de comp. NavMesh

public class EnemyAIBase : MonoBehaviour
{
    #region General Variables
    [Header("AI config")]
    [SerializeField] NavMeshAgent agent; //ref al cerebro del agente
    [SerializeField] Transform target; // ref al target
    [SerializeField] LayerMask targetLayer;
    [SerializeField] LayerMask groundLayer;
    [Header("Patroling stats")]
    [SerializeField] float walkpointRange = 10f; //radio max para determinar puntos a perseguir
    Vector3 walkPoint; //posición del punto random a perseguir
    bool walkPointSet; //Hay punto a perseguir generado? si es faslse genera uno

    [Header("Patroling stats")]
    [SerializeField] float timeBetweenAttacks = 1f;
    [SerializeField] GameObject projectile; //ref a la bala q dispara el enemigo
    [SerializeField] Transform shootPoint; //posicion desde la q se dispara la bala
    [SerializeField] float shootSpeedY; //Fuerza de disparo arriba (catapulta)
    [SerializeField] float shootSpeedZ; //Fuerza de disparo hacia alante
    bool alreadyAttacked;

    [Header("States & detection")]
    [SerializeField] float sightRange = 8f; //Radio del detector de persecución
    [SerializeField] float attackRange = 2f; //Radio del detector de ataque
    [SerializeField] bool targetInSightRange; //Determina si es verdadero q podemos perseguir al target
    [SerializeField] bool targetInAttackRange; //Determian si es verdadero q ataquemos al target

    [Header("stuck Detection")]
    [SerializeField] float stuckCheckTime = 2f; //tiempo q el agente espera estando quieto antes de darse cuenta q está stuck
    [SerializeField] float stuckThreshold = 0.1f; //margen de detección de stuck
    [SerializeField] float maxStuckDuration = 3f; //Tiempo max de estar stuck

    float stuckTimer; //reloj q cuenta el tiempo de estar stuck
    float lastCheckTime; //Tiempo de chequeo previo de stuck
    Vector3 lastPosition; //posición del ultimo walkpoint
    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
