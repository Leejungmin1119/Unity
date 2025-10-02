using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Argument : MonoBehaviour
{
    public ArgumentData argumentData; // ���� �Ŵ��� ��ũ��Ʈ ����
    public TextMeshProUGUI textLevel; // ���� ǥ�ÿ� �ؽ�Ʈ
    protected TextMeshProUGUI textName; // �̸� ǥ�ÿ� �ؽ�Ʈ
    protected TextMeshProUGUI textInformation; // ���� ǥ�ÿ� �ؽ�Ʈ
    
    Compensation compensation; // ���� ��ũ��Ʈ ����
    SkillActive skill; // ��ų Ȱ��ȭ ��ũ��Ʈ ����

    public void Awake()
    {
        // ���� ���� �ؽ�Ʈ ������Ʈ �ʱ�ȭ
        TextMeshProUGUI[] texts = GetComponentsInChildren<TextMeshProUGUI>();
        textName = texts[0];
        textLevel = texts[1];
        textInformation = texts[2];
    }

    void OnEnable()
    {
        // �ش� ������ � ���������� ���� ��� �ؽ�Ʈ �����ϱ�
        switch (argumentData.textType)
        {
            // �� ���� Ÿ�Կ� ���� ��µǴ� ������ �ٸ��� ����

            // �̸� ���ǵ� �ؽ�Ʈ Ÿ���� �ش� ������ �����Ͽ� ��¿� ���
            case ArgumentData.TextType.����:
                textName.text = argumentData.AugmentName;// ���� �̸�
                textLevel.text = "a"; // ���� ����(���� ���� x)
                textInformation.text = argumentData.ArgumentImformation; // ���� ����
                break;
            case ArgumentData.TextType.Ư������:
                textName.text = argumentData.AugmentName;
                textLevel.text = "lv." + (argumentData.Level + 2).ToString();
                textInformation.text = argumentData.ArgumentImformation;
                break;
            case ArgumentData.TextType.��Ÿ��:
                textName.text = argumentData.AugmentName;
                textLevel.text = "lv." + (argumentData.Level + 2).ToString();
                textInformation.text = string.Format(argumentData.ArgumentImformation, argumentData.SkillCoolTime[argumentData.Level]);
                break;
            case ArgumentData.TextType.����:
                textName.text = argumentData.AugmentName;
                textLevel.text = "lv."+ (argumentData.Level+2).ToString();
                textInformation.text = string.Format(argumentData.ArgumentImformation, argumentData.Skillduration[argumentData.Level]);
                break;

            // ������ Ư�� �ؽ�Ʈ Ÿ���� ���� �־�� �ϴ� �������� ó��
            case ArgumentData.TextType.��Ÿ:
                break;
        }
        if (argumentData.argumentType.Equals("�⺻"))
            return;
        else
        {
            textLevel.text = "Lv." + (argumentData.Level + 1).ToString();
        }

            
    }

    public void ApplyArgument()
    {
        // ���� ���� ����
        // ��: �÷��̾��� �ɷ�ġ ����, ��ų �߰� ��
        // �� �κ��� ������ ��ü���� ������ ���� �ٸ��� ������ �� �ֽ��ϴ�.
        if(argumentData.argumentType.Equals("����"))
        {
            // ���� ��ũ��Ʈ ����
            compensation.Aplyment(); // ���� Ȱ��ȭ
            return;
        }
        argumentData.Level += 1; // ���� ���� ����
        if (argumentData.argumentType.Equals("��ų"))
        {
            skill.GetComponent<SkillActive>();
            skill.Aplyment(); // ��ų Ȱ��ȭ
        }
        else if(argumentData.argumentType.Equals("Ű�ٿų"))
        {
            skill.GetComponent<SkillActive>();
            skill.Aplyment(); // ��ų Ȱ��ȭ 
            


        }

    }

}
