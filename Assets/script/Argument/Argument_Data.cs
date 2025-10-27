using UnityEngine;


[CreateAssetMenu(fileName = "Argument",menuName = "Scriptble Object/ArgumentData")]
public class Argument_Data : ScriptableObject
{
    // 무기 : 실제 우리가 사용할 무기 (최대 5개 제한)
    // 보상 : 그냥 기본적인 자원증강 (골드 10 , 체력 +1 과 같은 것들)
    // 기술 : 보상과 비슷하지만 전투와 관련된 추가 능력치 제공
    public enum Argument_Type { 무기, 보상, 기술 };

    [Header("Main")]
    public Argument_Type argument_Type;
    public int Argument_Id;
    public int Argument_Level;
    public int Argument_Max_Level;
    [Header("Argument Name")]
    public string Name;
    public Sprite Icon;
    [Header("element")]
    public float baseDaamge;
    public int baseCount;
    public float[] Damages;
    public int[] counts;
    [Header("Weapon")]
    public GameObject projectile;
}
