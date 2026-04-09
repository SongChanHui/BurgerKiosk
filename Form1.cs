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
            // 주문 시 이전 에러 메시지 스타일 초기화
            lblTotalCost.ForeColor = System.Drawing.Color.Blue;

            totalCost = 0;         // 누적 금액 초기화
            lstOrder.Items.Clear(); // 리스트 박스 비우기

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }

            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                // 라벨을 사용해 빨간색 경고를 표시
                lstOrder.Items.Clear();
                lblTotalCost.Text = "메뉴를 골라주세요";
                lblTotalCost.ForeColor = System.Drawing.Color.Red;
                return;
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
