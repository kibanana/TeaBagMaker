using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
        string[] TeaNameList = new string[]{"홍차", "녹차", "루이보스차", "국화차"};
        string[] TeaTimeList = new string[] {"120","180","300","120"};

        string Selected = ""; // 선택 결과 저장

        int CountOrgNum = 0;
        string CountStr = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected = TeaTimeList[this.Combo.SelectedIndex];

            if (this.Combo.Text != "")
            {
                this.TeaNameLabel.Text = Selected;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TeaNameList.Length; i++)
            {
                this.Combo.Items.Add(TeaNameList[i]);
            }

            if (Combo.Items.Count > 0)
            {
                this.Combo.SelectedIndex = 0;
            }
        }


        private void ProcessTimer()
        {
            this.CountOrgNum = Convert.ToInt32(Selected);
            this.Timer.Enabled = true;
        }

        private void TeaNameLabel_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ProcessTimer();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Combo.Focus();
            }
            else
            {
                this.CountOrgNum--;

                if (CountOrgNum > 60)
                {
                    CountStr = (CountOrgNum/60)+"분" + (CountOrgNum%60)+"초";
                    this.ResultText.Text = CountStr;
                    this.ResultText.ReadOnly = true;
                }
                else
                {
                    CountStr = CountOrgNum + "초";
                    this.ResultText.Text = CountStr;
                    this.ResultText.ReadOnly = true;
                }
                
            }
        }

        private void ResultText_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
