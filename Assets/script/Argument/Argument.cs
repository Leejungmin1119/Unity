using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*
public class Argument : MonoBehaviour
{
    //public ArgumentData argumentData; // 게임 매니저 스크립트 참조
    public TextMeshProUGUI textLevel; // 레벨 표시용 텍스트
    protected TextMeshProUGUI textName; // 이름 표시용 텍스트
    protected TextMeshProUGUI textInformation; // 설명 표시용 텍스트
    
    Compensation compensation; // 보상 스크립트 참조

    //SkillActive skill; // 스킬 활성화 스크립트 참조

    
    public void Awake()
    {
        // 증강 관련 텍스트 컴포넌트 초기화
        TextMeshProUGUI[] texts = GetComponentsInChildren<TextMeshProUGUI>();
        textName = texts[0];
        textLevel = texts[1];
        textInformation = texts[2];
    }

    void OnEnable()
    {
        // 해당 증강이 어떤 증강인지에 따라 출력 텍스트 설정하기
        switch (argumentData.textType)
        {
            // 각 증강 타입에 따라서 출력되는 정보를 다르게 설정

            // 미리 정의된 텍스트 타입을 해당 변수로 저장하여 출력에 사용
            case ArgumentData.TextType.지원:
                textName.text = argumentData.AugmentName;// 증강 이름
                textLevel.text = "a"; // 증강 레벨(지원 증강 x)
                textInformation.text = argumentData.ArgumentImformation; // 증강 설명
                break;
            case ArgumentData.TextType.특수지원:
                textName.text = argumentData.AugmentName;
                textLevel.text = "lv." + (argumentData.Level + 2).ToString();
                textInformation.text = argumentData.ArgumentImformation;
                break;
            case ArgumentData.TextType.쿨타임:
                textName.text = argumentData.AugmentName;
                textLevel.text = "lv." + (argumentData.Level + 2).ToString();
                textInformation.text = string.Format(argumentData.ArgumentImformation, argumentData.SkillCoolTime[argumentData.Level]);
                break;
            case ArgumentData.TextType.지속:
                textName.text = argumentData.AugmentName;
                textLevel.text = "lv."+ (argumentData.Level+2).ToString();
                textInformation.text = string.Format(argumentData.ArgumentImformation, argumentData.Skillduration[argumentData.Level]);
                break;

            // 나머지 특정 텍스트 타입의 값을 넣어야 하는 증강들을 처리
            case ArgumentData.TextType.기타:
                break;
        }
        if (argumentData.argumentType.Equals("기본"))
            return;
        else
        {
            textLevel.text = "Lv." + (argumentData.Level + 1).ToString();
        }

            
    }

    public void ApplyArgument()
    {
        // 증강 적용 로직
        // 예: 플레이어의 능력치 증가, 스킬 추가 등
        // 이 부분은 게임의 구체적인 로직에 따라 다르게 구현될 수 있습니다.
        if(argumentData.argumentType.Equals("지원"))
        {
            // 지원 스크립트 적용
            compensation.Aplyment(); // 보상 활성화
            return;
        }
        argumentData.Level += 1; // 증강 레벨 증가
        if (argumentData.argumentType.Equals("스킬"))
        {
            skill.GetComponent<SkillActive>();
            skill.Aplyment(); // 스킬 활성화
        }
        else if(argumentData.argumentType.Equals("키다운스킬"))
        {
            skill.GetComponent<SkillActive>();
            skill.Aplyment(); // 스킬 활성화 
            
            
        }

    }

}

*/

