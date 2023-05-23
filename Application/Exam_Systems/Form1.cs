using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Systems
{
    public partial class Form1 : Form
    {
        Examination_SystemEntities1 entity;
        int ExamID;
        int SSN;
        string Course;
        public Form1(int SSN1,string Course1)
        {
            InitializeComponent();
            this.SSN = SSN1;
            this.Course = Course1;
             entity = new Examination_SystemEntities1();
            entity.Exam_Generation(SSN, Course, 5, 5);
            ExamID = (from c in entity.Exams select c.id).Max();
            var question = entity.Exam_student_question.Where(d => d.ex_id == ExamID).Select(d => d.quest_id);
            List<Question> questionList = new List<Question>();
            foreach (int d1 in question)
            {
                Question question1 = entity.Questions.Where(d => d.id == d1).Select(d => d).First();
                questionList.Add(question1);
            }

            GroupBox[] groupBoxes = new GroupBox[]
            {
                groupBox1,groupBox2,groupBox3,groupBox4,groupBox5,groupBox6,groupBox7,groupBox8,groupBox9,
                groupBox10
            };
            var questions = questionList.ToArray();
            for (int i = 0; i < questions.Length; i++)
            {
                groupBoxes[i].Text = questions[i].title;
                Question_Choices[] choices = questions[i].Question_Choices.ToArray();
                groupBoxes[i].Controls[3].Visible = false;
                groupBoxes[i].Controls[2].Visible = false;
                groupBoxes[i].Controls[1].Visible = false;
                groupBoxes[i].Controls[0].Visible = false;
                for (int j = 0; j < choices.Length; j++)
                {
                    groupBoxes[i].Controls[j].Visible = true;
                    groupBoxes[i].Controls[j].Text = choices[j].choice;

                }

            }
        }
          public string ans1
        {
            get
            {
                string ans = string.Empty;
                if (radioButton1.Checked == true)
                {
                    ans = "d";
                }
                else if (radioButton2.Checked == true)
                {
                    ans = "c";

                }
                else if (radioButton3.Checked == true)
                {
                    ans = "b";
                }
                else if (radioButton4.Checked == true)
                {
                    ans = "a";
                }
                return ans;
            }

        }
        public string ans2
        {
            get
            {
                string ans = string.Empty;
                if (radioButton5.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton6.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton7.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton8.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }

        }
        public string ans3
        {
            get
            {
                string ans = string.Empty;
                if (radioButton9.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton10.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton11.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton12.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }
        }
        public string ans4
        {
            get
            {
                string ans = string.Empty;
                if (radioButton13.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton14.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton15.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton16.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }
        }
        public string ans5
        {
            get
            {
                string ans = string.Empty;
                if (radioButton17.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton18.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton19.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton20.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }

        }
        public string ans6
        {
            get
            {
                string ans = string.Empty;
                if (radioButton21.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton22.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton23.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton24.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }

        }
        public string ans7
        {
            get
            {
                string ans = string.Empty;
                if (radioButton25.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton26.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton27.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton28.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }

        }
        public string ans8
        {
            get
            {
                string ans = string.Empty;
                if (radioButton29.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton30.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton31.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton32.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }

        }
        public string ans9
        {
            get
            {
                string ans = string.Empty;
                if (radioButton33.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton34.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton35.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton36.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }

        }
        public string ans10
        {
            get
            {
                string ans = string.Empty;
                if (radioButton37.Checked == true)
                {
                    ans = "a";
                }
                else if (radioButton38.Checked == true)
                {
                    ans = "b";

                }
                else if (radioButton39.Checked == true)
                {
                    ans = "c";
                }
                else if (radioButton40.Checked == true)
                {
                    ans = "d";
                }
                return ans;
            }
         }

        private void Submit_Click(object sender, EventArgs e)
        {
            var crsID = (from c in entity.Courses where c.name==Course select c.Id).FirstOrDefault();
            entity.insert_Student_Course(crsID, SSN);
            string[]Answers= {ans1,ans2, ans3, ans4, ans5, ans6,ans7,ans8,ans9,ans10};
            entity.Enter_Answers(ExamID, SSN, Answers[0], Answers[1], Answers[2], Answers[3], Answers[4], Answers[5], Answers[6], Answers[7], Answers[8], Answers[9]);
            entity.SaveChanges();
            var grade = entity.Exam_Correction(ExamID, SSN);
            string grade1= grade.ToList().First().ToString();
            MessageBox.Show("your grade is = "+grade1 );
            entity.SaveChanges();
            this.Close();   
        }


    }
}
