using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponConfig : ScriptableObject
{
    public UnityAction weaponFireAction;
    public UnityAction collectWeaponAction;
    public GameAction damageAction;
    public float firePower = 0.1f;
    public Color weaponColor = Color.red;
    public GameObject weaponArt;
    public GameObject ammoObj;
    public FloatData playerHealth;

    public void RaiseFireAction()
    {
        weaponFireAction?.Invoke();
    }

    public void RaiseCollectionAction()
    {
        collectWeaponAction?.Invoke();
    }

    public void DoDamage()
    {
        playerHealth.UpdateValue(firePower);
        damageAction.Raise();
    }


}
