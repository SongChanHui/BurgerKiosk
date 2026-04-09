using System;
using System.Drawing;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class frmKiosk : Form
    {
        private int totalCost = 0;
        private int currentGroupIndex = 0; // 0: 메뉴, 1: 옵션, 2: 주문/초기화 버튼

        public frmKiosk()
        {
            InitializeComponent();

            // 1. 초기 상태 설정
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            lblTotalCost.Text = "총 금액 : 0원";

            // 2. 키보드 전용 조작 설정
            this.KeyPreview = true;
            this.KeyDown += FrmKiosk_KeyDown;
        }

        // [주문하기 버튼] 클릭 이벤트
        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblTotalCost.ForeColor = Color.Blue;
            totalCost = 0;
            lstOrder.Items.Clear();

            // 메뉴 미선택 시 예외 처리
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.Text = "메뉴를 골라주세요";
                lblTotalCost.ForeColor = Color.Red;
                return;
            }

            // 메뉴 계산
            if (rdoHamBurger.Checked) { totalCost += 5000; lstOrder.Items.Add("햄버거 5,000원"); }
            else if (rdoBulgogiBurger.Checked) { totalCost += 4000; lstOrder.Items.Add("불고기버거 4,000원"); }
            else if (rdoChickenBurger.Checked) { totalCost += 3000; lstOrder.Items.Add("치킨버거 3,000원"); }

            // 옵션 계산
            if (chkPotato.Checked) { totalCost += 3500; lstOrder.Items.Add("감자튀김 3,500원"); }
            if (chkCola.Checked) { totalCost += 2500; lstOrder.Items.Add("콜라 2,500원"); }
            if (chkCheese.Checked) { totalCost += 1500; lstOrder.Items.Add("치즈 추가 1,500원"); }
            if (chkSauce.Checked) { totalCost += 500; lstOrder.Items.Add("소스 추가 500원"); }

            lblTotalCost.Text = "총 금액 : " + totalCost.ToString("#,##0") + "원";
        }

        // [초기화 버튼] 클릭 이벤트
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
            lblTotalCost.ForeColor = Color.Blue;
        }

        // 키보드 핸들러
        private void FrmKiosk_KeyDown(object sender, KeyEventArgs e)
        {
            // 1. Tab: 그룹 이동 (메뉴 -> 옵션 -> 주문내역 버튼)
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                currentGroupIndex = (currentGroupIndex + 1) % 3;
                FocusGroup(currentGroupIndex);
                return;
            }

            // 2. 방향키: 현재 그룹 내에서 위/아래 이동
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                bool forward = e.KeyCode == Keys.Down;

                switch (currentGroupIndex)
                {
                    case 0: // 메뉴 그룹
                        MoveAmong(new Control[] { rdoHamBurger, rdoBulgogiBurger, rdoChickenBurger }, forward);
                        break;
                    case 1: // 옵션 그룹
                        MoveAmong(new Control[] { chkPotato, chkCola, chkCheese, chkSauce }, forward);
                        break;
                    case 2: // 버튼 그룹
                        MoveAmong(new Control[] { btnOrder, btnClear }, forward);
                        break;
                }
                return;
            }

            // 3. Space: 선택 / 4. Enter: 버튼 실행
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Control focused = GetFocusedControl();

                if (focused is CheckBox cb) cb.Checked = !cb.Checked;
                else if (focused is RadioButton rb) rb.Checked = true;
                else if (focused is Button btn) btn.PerformClick();
                return;
            }
        }

        // 현재 실제로 포커스를 가진 컨트롤 찾기
        private Control GetFocusedControl()
        {
            Control c = this.ActiveControl;
            while (c is ContainerControl cc && cc.ActiveControl != null)
            {
                c = cc.ActiveControl;
            }
            return c;
        }

        // 그룹으로 포커스 이동 (그룹박스가 아닌 내부 첫 컨트롤에 직접 포커스)
        private void FocusGroup(int groupIndex)
        {
            switch (groupIndex)
            {
                case 0: rdoHamBurger.Focus(); break;
                case 1: chkPotato.Focus(); break;
                case 2: btnOrder.Focus(); break;
            }
        }

        // 그룹 내에서 항목 간 이동
        private void MoveAmong(Control[] items, bool forward)
        {
            Control focused = GetFocusedControl();
            int idx = Array.IndexOf(items, focused);

            if (idx == -1) idx = 0;
            else
            {
                if (forward) idx = (idx + 1) % items.Length;
                else idx = (idx - 1 + items.Length) % items.Length;
            }
            items[idx].Focus();
        }
    }
}