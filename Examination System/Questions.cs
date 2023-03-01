namespace Exam_System
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void lab_Question_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();
            questions.Show();
            this.Hide();
        }

        private void lab_Subject_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.Show();
            this.Hide();
        }

        private void lab_Student_Click(object sender, EventArgs e)
        {
            Students students = new Students();
           students.Show();
            this.Hide();
        }
    }
}