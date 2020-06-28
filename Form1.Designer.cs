namespace IntegralCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FunctionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RectangleMethodFlag = new System.Windows.Forms.RadioButton();
            this.TrapetionMethodFlag = new System.Windows.Forms.RadioButton();
            this.SimpsonMethodFlag = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpperLimitTextBox = new System.Windows.Forms.TextBox();
            this.LowerLimitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KnotQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            resources.ApplyResources(this.CalculateButton, "CalculateButton");
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FunctionText
            // 
            resources.ApplyResources(this.FunctionText, "FunctionText");
            this.FunctionText.Name = "FunctionText";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // RectangleMethodFlag
            // 
            resources.ApplyResources(this.RectangleMethodFlag, "RectangleMethodFlag");
            this.RectangleMethodFlag.Name = "RectangleMethodFlag";
            this.RectangleMethodFlag.TabStop = true;
            this.RectangleMethodFlag.UseVisualStyleBackColor = true;
            // 
            // TrapetionMethodFlag
            // 
            resources.ApplyResources(this.TrapetionMethodFlag, "TrapetionMethodFlag");
            this.TrapetionMethodFlag.Name = "TrapetionMethodFlag";
            this.TrapetionMethodFlag.TabStop = true;
            this.TrapetionMethodFlag.UseVisualStyleBackColor = true;
            // 
            // SimpsonMethodFlag
            // 
            resources.ApplyResources(this.SimpsonMethodFlag, "SimpsonMethodFlag");
            this.SimpsonMethodFlag.Name = "SimpsonMethodFlag";
            this.SimpsonMethodFlag.TabStop = true;
            this.SimpsonMethodFlag.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // UpperLimitTextBox
            // 
            resources.ApplyResources(this.UpperLimitTextBox, "UpperLimitTextBox");
            this.UpperLimitTextBox.Name = "UpperLimitTextBox";
            // 
            // LowerLimitTextBox
            // 
            resources.ApplyResources(this.LowerLimitTextBox, "LowerLimitTextBox");
            this.LowerLimitTextBox.Name = "LowerLimitTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // KnotQuantityTextBox
            // 
            resources.ApplyResources(this.KnotQuantityTextBox, "KnotQuantityTextBox");
            this.KnotQuantityTextBox.Name = "KnotQuantityTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ResultTextBox
            // 
            resources.ApplyResources(this.ResultTextBox, "ResultTextBox");
            this.ResultTextBox.Name = "ResultTextBox";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KnotQuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LowerLimitTextBox);
            this.Controls.Add(this.UpperLimitTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SimpsonMethodFlag);
            this.Controls.Add(this.TrapetionMethodFlag);
            this.Controls.Add(this.RectangleMethodFlag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FunctionText);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FunctionTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox FunctionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RectangleMethodFlag;
        private System.Windows.Forms.RadioButton TrapetionMethodFlag;
        private System.Windows.Forms.RadioButton SimpsonMethodFlag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UpperLimitTextBox;
        private System.Windows.Forms.TextBox LowerLimitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KnotQuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

