using UnityEngine;

public class CooldownPickup : MonoBehaviour
{
    [Header("Parameters")]
    [Tooltip("Number of seocnds the cooldown effect will last")]
    public float cooldownTime;

    Pickup m_Pickup;

    void Start()
    {
        m_Pickup = GetComponent<Pickup>();
        DebugUtility.HandleErrorIfNullGetComponent<Pickup, CooldownPickup>(m_Pickup, this, gameObject);

        // Subscribe to pickup action
        m_Pickup.onPick += OnPicked;
    }

    void OnPicked(PlayerCharacterController player)
    {
        StatusEffect playerStatus = player.GetComponent<StatusEffect>();
        if (playerStatus && playerStatus.canInstantCooldown){
            playerStatus.StartInstantCooldown(cooldownTime);
            m_Pickup.PlayPickupFeedback();
            Destroy(gameObject);
        }
        else {
            print(playerStatus == null);
        }
    }
}