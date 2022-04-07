using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{
  private const float ROTATION_CALCULATION_OFFSET = 1f/9f;
  public bool IsTeamA;
  public GameObject DirectionalArrow;
  public GameObject PushMeter;
  public Image PushMeterImage;
  public TextMeshProUGUI RotationText;

  private Rigidbody rb;
  private Collider collider;

  private PhysicMaterial mat;

  private float cachedStartTime = 0f;
  private float initialSpeed;
  private int rotationAmount = 0;
  private bool hoglineCrossed = false;

  public bool IsMoving {
    get {
      return rb.velocity.sqrMagnitude > 0.01f;
    }
  }

  private void Awake()
  {
    rb = GetComponent<Rigidbody>();
    collider = GetComponent<Collider>();
    mat = collider.material;

    DirectionalArrow.SetActive(true);
    PushMeter.gameObject.SetActive(false);
    RotationText.gameObject.SetActive(false);
  }

  private void Update()
  {
    if (transform.position.y < 0f) {
      Destroy(gameObject);
    }

    if (PushMeter.gameObject.activeSelf && !RotationText.gameObject.activeSelf) {
      PushMeterImage.fillAmount = 1 - Mathf.Abs(Mathf.Cos(Time.time - cachedStartTime));
    }
  }

  private void FixedUpdate()
  {
    if (!IsMoving) return;
    mat.dynamicFriction = 0.011f + (0.0019f / rb.velocity.magnitude);
    if (!hoglineCrossed) return;
    rb.velocity = Quaternion.Euler(0, rotationAmount / (rb.velocity.magnitude + ROTATION_CALCULATION_OFFSET), 0f) * (transform.forward * rb.velocity.magnitude);  
  }  

  public void StartPush()
  {
    DirectionalArrow.SetActive(false);
    PushMeter.gameObject.SetActive(true);
    cachedStartTime = Time.time;
  }

  public void ReleasePush()
  {
    float userForce = PushMeterImage.fillAmount;
    initialSpeed = 2f + userForce * 1.5f;
    rb.velocity = transform.forward * initialSpeed;
    RotationText.gameObject.SetActive(true);
  }

  public void AddToRotation(int change)
  {
    if (!hoglineCrossed) rotationAmount = Mathf.Clamp(rotationAmount + change, -5, 5);
    RotationText.text = rotationAmount.ToString();
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Hogline")) {
      hoglineCrossed = true;
      PushMeter.gameObject.SetActive(false);
    }
  }
}
