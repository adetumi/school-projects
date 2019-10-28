using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineExamination
{
    public partial class examOnline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                String mainConnection = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlcon = new SqlConnection(mainConnection);
                string sqlQuery = "select * from onlineExam ";
                sqlcon.Open();

                SqlCommand sqlcomm = new SqlCommand(sqlQuery, sqlcon);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlcomm);
                DataTable dTable = new DataTable();
                sqlData.Fill(dTable);

                Repeater1.DataSource = dTable;
                Repeater1.DataBind();


                sqlcon.Close();
            }





        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton radioButton1 = (RadioButton)ri.FindControl("RadOption1");
                Label CorrectAns = (Label)ri.FindControl("CorrectAns");
                CorrectAns.Visible = true;

                if (radioButton1.Checked == true)
                {
                    if (radioButton1.Text.Equals(CorrectAns.Text))
                    {
                        Label selectedAnswer = (Label)ri.FindControl("SelectedOption");
                        selectedAnswer.Text = "the selected answer is <b>" + radioButton1.Text.ToString() + "</b>";
                        selectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label wrongAnswer = (Label)ri.FindControl("SelectedOption");
                        wrongAnswer.Text = "the selected answer is <b>" + radioButton1.Text.ToString() + "</b> is wrong !";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton radioButton2 = (RadioButton)ri.FindControl("RadOption2");
                Label CorrectAns = (Label)ri.FindControl("CorrectAns");
                CorrectAns.Visible = true;

                if (radioButton2.Checked == true)
                {
                    if (radioButton2.Text.Equals(CorrectAns.Text))
                    {
                        Label selectedAnswer = (Label)ri.FindControl("SelectedOption");
                        selectedAnswer.Text = "the selected answer is <b>" + radioButton2.Text.ToString() + "</b>";
                        selectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label wrongAnswer = (Label)ri.FindControl("SelectedOption");
                        wrongAnswer.Text = "the selected answer is <b>" + radioButton2.Text.ToString() + "</b> is wrong !";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton radioButton3 = (RadioButton)ri.FindControl("RadOption3");
                Label CorrectAns = (Label)ri.FindControl("CorrectAns");
                CorrectAns.Visible = true;

                if (radioButton3.Checked == true)
                {
                    if (radioButton3.Text.Equals(CorrectAns.Text))
                    {
                        Label selectedAnswer = (Label)ri.FindControl("SelectedOption");
                        selectedAnswer.Text = "the selected answer is <b>" + radioButton3.Text.ToString() + "</b>";
                        selectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label wrongAnswer = (Label)ri.FindControl("SelectedOption");
                        wrongAnswer.Text = "the selected answer is <b>" + radioButton3.Text.ToString() + "</b> is wrong !";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton radioButton4 = (RadioButton)ri.FindControl("RadOption4");
                Label CorrectAns = (Label)ri.FindControl("CorrectAns");
                CorrectAns.Visible = true;

                if (radioButton4.Checked == true)
                {
                    if (radioButton4.Text.Equals(CorrectAns.Text))
                    {
                        Label selectedAnswer = (Label)ri.FindControl("SelectedOption");
                        selectedAnswer.Text = "the selected answer is <b>" + radioButton4.Text.ToString() + "</b>";
                        selectedAnswer.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label wrongAnswer = (Label)ri.FindControl("SelectedOption");
                        wrongAnswer.Text = "the selected answer is <b>" + radioButton4.Text.ToString() + "</b> is wrong !";
                        wrongAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
    }
}