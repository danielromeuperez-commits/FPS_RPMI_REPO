using UnityEngine;
using UnityEngine.InputSystem;

public class GunSystem : MonoBehaviour
{
    #region General Variables
    [Header("General refs")]
    [SerializeField] Camera fpsCam; //Ref si disparamos desde el centro de la camara
    [SerializeField] Transform shootPoint; //Ref si queremos disparar desde la punta del cañon
    [SerializeField] LayerMask impactLayer; //Layer con la que interactua el raycast
    RaycastHit hit; //Almacen de info de objetos a los que el raycast puede interactuar;
    [Header("Weapon parameters")]
    [SerializeField] int damage = 10; //Daño del arma x bala
    [SerializeField] float range = 100f; // Rango de disparo, = longitud del RAYCAST
    [SerializeField] float spread = 0; //dispersion de balas
    [SerializeField] float shootingCooldown = 0.2f; // tiempo entre disparos
    [SerializeField] float reloadTime = 1.5f; //tiempo de recarga
    [SerializeField] bool allowButtonHold = false; //si disparo se ejecuta x click (falso) o mantener (true)
    [Header("Bullet Management")]
    [SerializeField] int ammoSize = 30; // max de balas
    [SerializeField] int bulletPerTap = 1; // Balas disparadas por ejecución
    int bulletsLeft; //Balas en el cargador actual
    [Header("FeedBack REFS")]
    [SerializeField] GameObject impactEffect; //Ref al VFX de impacto de bala
    [Header("Dev-Gun State Bools")]
    [SerializeField] bool shooting; //indica disparo
    [SerializeField] bool canShoot; //indica si podemos disoarar
    [SerializeField] bool reloading; //indica recarga
    #endregion
    private void Awake()
    {
        bulletsLeft=ammoSize; //cargador lleno al inicio de partida
        canShoot = true; //poder disparar al empezar partida
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot()
    {
        //METODO MAS IMPORTANTE
        //SE DEFINE DISPARO POR RAYCAST = UTILIZABLE CON CUALQUIER MECANICA

        //Almacenar direccion de disparo y modificar en caso de spread
        Vector3 direction = fpsCam.transform.forward;
        //dispaersion aleatoria segun valor spread
        direction.x += Random.Range(-spread, spread);
        direction.y += Random.Range(-spread, spread);

        //DECLARACION DE RAYCAST
        //Anatomia: Physics.Raycast(Origen del rayo, dirección, almacen de la info de inpacto, longitud del rayo, layer con la q impacta el rayo
        if (Physics.Raycast(fpsCam.transform.position, direction, out hit, range, impactLayer))
        {
            //Aqui puedo codear todos los efectos q quiero en mi interaccion
            Debug.Log(hit.collider.name);
        }
    }

    #region Input Methods
    public void OnShoot(InputAction.CallbackContext context)
    {

    }
    public void OnReload(InputAction.CallbackContext context)
    {

    }
    #endregion

}
