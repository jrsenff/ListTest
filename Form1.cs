using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListTest
{
    public partial class Form1 : Form
    {
        List<Test> submittedTests = new List<Test>();
        List<Test> checkedOutTests = new List<Test>();

        public Form1()
        {
            InitializeComponent();
            AcceptButton = btnSubmitTest;
            txtStudentName.Focus();
            listSubmittedTests.MouseDoubleClick += new MouseEventHandler(ListSubmittedTests_DoubleClick);
            listCheckedOutTests.MouseDoubleClick += new MouseEventHandler(ListCheckedOutTests_DoubleClick);
        }

        private void BtnSubmitTest_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            Test dupTest = null;

            if (txtStudentName.Text != "" && txtTestNumber.Text != "")
            {
                dupTest = submittedTests.Find(item => item.StudentName == txtStudentName.Text && item.TestNumber == txtTestNumber.Text);
                
                if (dupTest != null)
                {
                    MessageBox.Show("Test already submitted...");
                }
                else
                {
                    test.StudentName = txtStudentName.Text;
                    test.TestNumber = txtTestNumber.Text;
                    submittedTests.Add(test);

                    UpdateListBoxes();
                    ResetTextBoxes();
                    txtStudentName.Focus();
                }
            }
            else
            {
                CheckTextboxes();
            }
        }

        private void BtnCheckOutTest_Click(object sender, EventArgs e)
        {
            Test result = null;
            Test checkedOutTest = null;

            if (txtStudentName.Text != "" && txtTestNumber.Text != "")
            {
                result = submittedTests.Find(item => item.StudentName == txtStudentName.Text && item.TestNumber == txtTestNumber.Text);
                
                if (result != null)
                {
                    checkedOutTests.Add(result);
                    submittedTests.Remove(result);
                }
                else
                {
                    checkedOutTest = checkedOutTests.Find(item => item.StudentName == txtStudentName.Text && item.TestNumber == txtTestNumber.Text);

                    if (checkedOutTest != null)
                    {
                        MessageBox.Show("Test already checked out for review...");
                    }
                    else
                        MessageBox.Show("Cannot find test record...");
                }

                UpdateListBoxes();
                ResetTextBoxes();
                txtStudentName.Focus();
            }
            else
            {
                CheckTextboxes();
            }
        }

        private void BtnReturnTest_Click(object sender, EventArgs e)
        {
            Test result = null;
            Test alreadyReturned = null;

            if (txtStudentName.Text != "" && txtTestNumber.Text != "")
            {
                result = checkedOutTests.Find(item => item.StudentName == txtStudentName.Text && item.TestNumber == txtTestNumber.Text);

                if (result != null)
                {
                    submittedTests.Add(result);
                    checkedOutTests.Remove(result);
                }
                else
                {
                    alreadyReturned = submittedTests.Find(item => item.StudentName == txtStudentName.Text && item.TestNumber == txtTestNumber.Text);

                    if (alreadyReturned != null)
                    {
                        MessageBox.Show("Test already returned...");
                    }
                    else
                        MessageBox.Show("Cannot find test record...");
                }

                UpdateListBoxes();
                ResetTextBoxes();
                txtStudentName.Focus();
            }
            else
            {
                CheckTextboxes();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedOutTests.Count; ++i)
            {
                submittedTests.Add(checkedOutTests[i]);
            }

            checkedOutTests.Clear();

            UpdateListBoxes();
            ResetTextBoxes();

            Close();
        }

        private void ResetTextBoxes()
        {
            txtStudentName.ResetText();
            txtTestNumber.ResetText();
        }

        private void UpdateListBoxes()
        {
            listSubmittedTests.DataSource = null;
            listSubmittedTests.DataSource = submittedTests;

            listCheckedOutTests.DataSource = null;
            listCheckedOutTests.DataSource = checkedOutTests;
        }

        private void ListSubmittedTests_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = listSubmittedTests.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                Test result = submittedTests[index];

                DialogResult dialogResult = MessageBox.Show("Move to Checked Out Tests?", "Move Test?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    checkedOutTests.Add(result);
                    submittedTests.Remove(result);

                    UpdateListBoxes();
                    ResetTextBoxes();
                }

                txtStudentName.Focus();
            }
        }

        private void ListCheckedOutTests_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = listCheckedOutTests.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                Test result = checkedOutTests[index];

                DialogResult dialogResult = MessageBox.Show("Move to Submitted Tests?", "Move Test?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    submittedTests.Add(result);
                    checkedOutTests.Remove(result);

                    UpdateListBoxes();
                    ResetTextBoxes();
                }

                txtStudentName.Focus();
            }
        }

        private void CheckTextboxes()
        {
            if (txtStudentName.Text == "" && txtTestNumber.Text != "")
            {
                MessageBox.Show("Please enter a Student Name...");
                txtStudentName.Focus();
            }
            else if (txtStudentName.Text != "" && txtTestNumber.Text == "")
            {
                MessageBox.Show("Please enter a Test Number...");
                txtTestNumber.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a Student Name and Test Number...");
                txtStudentName.Focus();
            }
        }
    }
}
