using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST8256Lab2
{
    public partial class StudentRecords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {

                Course course_num = Session["course"] as Course;
                if (course_num == null)
                {
                    Response.Redirect("Default.aspx");

                }
                else
                {
                    //Page.Title = course_num.CourseNumber.ToString() +" " + course_num.CourseName.ToString();
                    DynamicTitle.Text = course_num.ToString();

                }
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;


            }


        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            List<Student> students_list = Session["student_info"] as List<Student>;
            if (students_list == null)
            {
                students_list = new List<Student>();
                Session["student_info"] = students_list;
            }
            string student_id = txtStudentID.Text;
            string student_name = txtStudentName.Text;
            int student_grade = int.Parse(txtGrade.Text);

            Student studentsInfo = new Student(student_id, student_name, student_grade);
            students_list.Add(studentsInfo);

            if (students_list.Count == 0)
            {
                TableRow lastRow = new TableRow();
                TableCell lastRowCell = new TableCell();
                lastRowCell.Text = "No student Record Exist";
                lastRowCell.ForeColor = System.Drawing.Color.Red;
                lastRowCell.ColumnSpan = 3;
                lastRowCell.HorizontalAlign = HorizontalAlign.Center;
                lastRow.Cells.Add(lastRowCell);
                tble.Rows.Add(lastRow);
            }
            else
            {
                foreach (Student student_show in students_list)
                {
                    TableRow newrow = new TableRow();

                    TableCell cell = new TableCell();
                    cell.Text = student_show.ID;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Name;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Grade.ToString();
                    newrow.Cells.Add(cell);

                    tble.Rows.Add(newrow);
                }
            }


        }

        protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            List<Student> students_list = Session["student_info"] as List<Student>;
            if (students_list == null)
            {
                students_list = new List<Student>();
                Session["student_info"] = students_list;
            }
            if (RadioButtonList1.SelectedValue == "ID")
            {
                students_list.Sort((x, y) => x.ID.CompareTo(y.ID));
                foreach (Student student_show in students_list)
                {
                    TableRow newrow = new TableRow();

                    TableCell cell = new TableCell();
                    cell.Text = student_show.ID;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Name;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Grade.ToString();
                    newrow.Cells.Add(cell);

                    tble.Rows.Add(newrow);
                }
            }
            if (RadioButtonList1.SelectedValue == "Name")
            {
                var sort_by_name = students_list.OrderBy(n => n.Name.Split(' ')[1]).ThenBy(n => n.Name.Split(' ')[0]).ThenBy(n => n.ID).ToList();
                foreach (Student student_show in sort_by_name)
                {
                    TableRow newrow = new TableRow();

                    TableCell cell = new TableCell();
                    cell.Text = student_show.ID;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Name;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Grade.ToString();
                    newrow.Cells.Add(cell);

                    tble.Rows.Add(newrow);
                }

            }
            if (RadioButtonList1.SelectedValue == "Grade")
            {
                var sort_by_grade = students_list.OrderBy(g => g.Grade).ToList();
                foreach (Student student_show in sort_by_grade)
                {
                    TableRow newrow = new TableRow();

                    TableCell cell = new TableCell();
                    cell.Text = student_show.ID;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Name;
                    newrow.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = student_show.Grade.ToString();
                    newrow.Cells.Add(cell);

                    tble.Rows.Add(newrow);
                }
            }
            }
    }
}