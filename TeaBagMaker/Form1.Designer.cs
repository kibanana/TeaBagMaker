namespace TeaBagMaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Combo = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResultText = new System.Windows.Forms.TextBox();
            this.TeaNameLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Combo
            // 
            this.Combo.FormattingEnabled = true;
            this.Combo.Location = new System.Drawing.Point(13, 13);
            this.Combo.Name = "Combo";
            this.Combo.Size = new System.Drawing.Size(121, 20);
            this.Combo.TabIndex = 0;
            this.Combo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(13, 89);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(121, 21);
            this.ResultText.TabIndex = 1;
            // 
            // TeaNameLabel
            // 
            this.TeaNameLabel.Location = new System.Drawing.Point(13, 40);
            this.TeaNameLabel.Name = "TeaNameLabel";
            this.TeaNameLabel.Size = new System.Drawing.Size(121, 21);
            this.TeaNameLabel.TabIndex = 2;
            this.TeaNameLabel.TextChanged += new System.EventHandler(this.TeaNameLabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 122);
            this.Controls.Add(this.TeaNameLabel);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.Combo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.TextBox TeaNameLabel;
    }
}

