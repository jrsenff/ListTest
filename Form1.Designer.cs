namespace ListTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtTestNumber = new System.Windows.Forms.TextBox();
            this.btnSubmitTest = new System.Windows.Forms.Button();
            this.btnCheckOutTest = new System.Windows.Forms.Button();
            this.btnReturnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listSubmittedTests = new System.Windows.Forms.ListBox();
            this.listCheckedOutTests = new System.Windows.Forms.ListBox();
            this.collectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Number";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(117, 26);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(318, 20);
            this.txtStudentName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtStudentName, "Student Name");
            // 
            // txtTestNumber
            // 
            this.txtTestNumber.Location = new System.Drawing.Point(117, 104);
            this.txtTestNumber.Name = "txtTestNumber";
            this.txtTestNumber.Size = new System.Drawing.Size(318, 20);
            this.txtTestNumber.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtTestNumber, "Test Number");
            // 
            // btnSubmitTest
            // 
            this.btnSubmitTest.Location = new System.Drawing.Point(463, 26);
            this.btnSubmitTest.Name = "btnSubmitTest";
            this.btnSubmitTest.Size = new System.Drawing.Size(93, 23);
            this.btnSubmitTest.TabIndex = 4;
            this.btnSubmitTest.Text = "&Submit Test";
            this.toolTip1.SetToolTip(this.btnSubmitTest, "Submit Test");
            this.btnSubmitTest.UseVisualStyleBackColor = true;
            this.btnSubmitTest.Click += new System.EventHandler(this.BtnSubmitTest_Click);
            // 
            // btnCheckOutTest
            // 
            this.btnCheckOutTest.Location = new System.Drawing.Point(463, 64);
            this.btnCheckOutTest.Name = "btnCheckOutTest";
            this.btnCheckOutTest.Size = new System.Drawing.Size(93, 23);
            this.btnCheckOutTest.TabIndex = 5;
            this.btnCheckOutTest.Text = "&Check Out Test";
            this.toolTip1.SetToolTip(this.btnCheckOutTest, "Check Out Test");
            this.btnCheckOutTest.UseVisualStyleBackColor = true;
            this.btnCheckOutTest.Click += new System.EventHandler(this.BtnCheckOutTest_Click);
            // 
            // btnReturnTest
            // 
            this.btnReturnTest.Location = new System.Drawing.Point(463, 102);
            this.btnReturnTest.Name = "btnReturnTest";
            this.btnReturnTest.Size = new System.Drawing.Size(93, 23);
            this.btnReturnTest.TabIndex = 6;
            this.btnReturnTest.Text = "&Return Test";
            this.toolTip1.SetToolTip(this.btnReturnTest, "Return to Submitted Tests");
            this.btnReturnTest.UseVisualStyleBackColor = true;
            this.btnReturnTest.Click += new System.EventHandler(this.BtnReturnTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(463, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit Form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Submitted Tests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Checked Out Tests";
            // 
            // listSubmittedTests
            // 
            this.listSubmittedTests.FormattingEnabled = true;
            this.listSubmittedTests.Location = new System.Drawing.Point(51, 199);
            this.listSubmittedTests.Name = "listSubmittedTests";
            this.listSubmittedTests.Size = new System.Drawing.Size(519, 95);
            this.listSubmittedTests.Sorted = true;
            this.listSubmittedTests.TabIndex = 12;
            this.toolTip1.SetToolTip(this.listSubmittedTests, "Submitted Test List");
            // 
            // listCheckedOutTests
            // 
            this.listCheckedOutTests.FormattingEnabled = true;
            this.listCheckedOutTests.Location = new System.Drawing.Point(51, 339);
            this.listCheckedOutTests.Name = "listCheckedOutTests";
            this.listCheckedOutTests.Size = new System.Drawing.Size(519, 95);
            this.listCheckedOutTests.Sorted = true;
            this.listCheckedOutTests.TabIndex = 13;
            this.toolTip1.SetToolTip(this.listCheckedOutTests, "Checked Out Test List");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(ListTest.Test);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmitTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 490);
            this.Controls.Add(this.listCheckedOutTests);
            this.Controls.Add(this.listSubmittedTests);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturnTest);
            this.Controls.Add(this.btnCheckOutTest);
            this.Controls.Add(this.btnSubmitTest);
            this.Controls.Add(this.txtTestNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Tests";
            ((System.ComponentModel.ISupportInitialize)(this.collectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtTestNumber;
        private System.Windows.Forms.Button btnSubmitTest;
        private System.Windows.Forms.Button btnCheckOutTest;
        private System.Windows.Forms.Button btnReturnTest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.BindingSource collectionBindingSource;
        private System.Windows.Forms.ListBox listSubmittedTests;
        private System.Windows.Forms.ListBox listCheckedOutTests;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

