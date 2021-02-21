
namespace Linq_GameInfo
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
            this.dgGameInfo = new System.Windows.Forms.DataGridView();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnAttribute = new System.Windows.Forms.Button();
            this.cboxAttribute = new System.Windows.Forms.ComboBox();
            this.numLevelMin = new System.Windows.Forms.NumericUpDown();
            this.numLevelMax = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGameInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGameInfo
            // 
            this.dgGameInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGameInfo.Location = new System.Drawing.Point(13, 13);
            this.dgGameInfo.Name = "dgGameInfo";
            this.dgGameInfo.RowHeadersWidth = 51;
            this.dgGameInfo.RowTemplate.Height = 27;
            this.dgGameInfo.Size = new System.Drawing.Size(453, 517);
            this.dgGameInfo.TabIndex = 0;
            // 
            // btnLevel
            // 
            this.btnLevel.Location = new System.Drawing.Point(485, 13);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(213, 49);
            this.btnLevel.TabIndex = 1;
            this.btnLevel.Text = "레벨 순으로";
            this.btnLevel.UseVisualStyleBackColor = true;
            this.btnLevel.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(485, 78);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(213, 49);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "이름 순으로";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAttribute
            // 
            this.btnAttribute.Location = new System.Drawing.Point(485, 142);
            this.btnAttribute.Name = "btnAttribute";
            this.btnAttribute.Size = new System.Drawing.Size(213, 49);
            this.btnAttribute.TabIndex = 3;
            this.btnAttribute.Text = "속성별로";
            this.btnAttribute.UseVisualStyleBackColor = true;
            this.btnAttribute.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cboxAttribute
            // 
            this.cboxAttribute.FormattingEnabled = true;
            this.cboxAttribute.Location = new System.Drawing.Point(485, 242);
            this.cboxAttribute.Name = "cboxAttribute";
            this.cboxAttribute.Size = new System.Drawing.Size(213, 23);
            this.cboxAttribute.TabIndex = 4;
            // 
            // numLevelMin
            // 
            this.numLevelMin.Location = new System.Drawing.Point(485, 289);
            this.numLevelMin.Name = "numLevelMin";
            this.numLevelMin.Size = new System.Drawing.Size(85, 25);
            this.numLevelMin.TabIndex = 5;
            // 
            // numLevelMax
            // 
            this.numLevelMax.Location = new System.Drawing.Point(613, 289);
            this.numLevelMax.Name = "numLevelMax";
            this.numLevelMax.Size = new System.Drawing.Size(85, 25);
            this.numLevelMax.TabIndex = 6;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(485, 363);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(213, 49);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(213, 49);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.numLevelMax);
            this.Controls.Add(this.numLevelMin);
            this.Controls.Add(this.cboxAttribute);
            this.Controls.Add(this.btnAttribute);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.dgGameInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGameInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevelMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGameInfo;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnAttribute;
        private System.Windows.Forms.ComboBox cboxAttribute;
        private System.Windows.Forms.NumericUpDown numLevelMin;
        private System.Windows.Forms.NumericUpDown numLevelMax;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}

