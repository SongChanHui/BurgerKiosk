namespace BurgerKiosk
{
    public partial class frmKiosk : Form
    {
        public frmKiosk()
        {
            InitializeComponent();
            // 시작 시 라디오 버튼이 모두 선택되지 않도록 초기화
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            lblTotalCost.Text = "총 금액 : 0원";
        }
        int totalCost = 0; // 주문 총 금액을 저장할 변수

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 1 . 주문 시작 시 스타일 및 변수 초기화
            lblTotalCost.ForeColor = System.Drawing.Color.Blue; // 기본 색상 ( 파란색 )
            totalCost = 0;         // 금액 리셋
            lstOrder.Items.Clear(); // 리스트 박스 리셋

            // 2 . [ 중요 ] 메뉴 미선택 예외 처리 ( 맨 위로 이동 )
            // 아무 버거도 선택하지 않았다면 빨간색 경고를 띄우고 즉시 종료합니다 .
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 골라주세요";
                lblTotalCost.ForeColor = System.Drawing.Color.Red; // 빨간색 경고
                return; // 여기서 함수를 끝내버림 ( 아래 계산 코드로 안 내려감 )
            }

            // 3 . 버거 메뉴 선택 판별 ( 하나만 선택되도록 if - else if 사용 )
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // 4 . 추가 옵션 선택 판별 ( 여러 개 선택 가능하도록 독립적 if 사용 )
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            // 5 . 최종 결과 출력 ( 천 단위 콤마 추가 )
            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("#,##0") + "원";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액 : 0원";
        }
    }
}
