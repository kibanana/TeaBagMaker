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
        int[] TeaTimeList = new int[] {120,180,300,120};

        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void TeaNameLabel_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
