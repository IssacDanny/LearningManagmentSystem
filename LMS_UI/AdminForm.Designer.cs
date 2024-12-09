namespace LMS_UI
{
    partial class AdminForm
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.teacherButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.allocateCourseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewStudentsButton = new System.Windows.Forms.Button();
            this.viewAllocatedCoursesButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.ViewTeacherButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(262, 65);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(901, 496);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.teacherButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.allocateCourseButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 561);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // teacherButton
            // 
            this.teacherButton.BackColor = System.Drawing.Color.Blue;
            this.teacherButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherButton.Location = new System.Drawing.Point(5, 4);
            this.teacherButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(253, 59);
            this.teacherButton.TabIndex = 0;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = false;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(5, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Student";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(5, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Courses";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(5, 194);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Class";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // allocateCourseButton
            // 
            this.allocateCourseButton.BackColor = System.Drawing.Color.Blue;
            this.allocateCourseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.allocateCourseButton.Location = new System.Drawing.Point(5, 255);
            this.allocateCourseButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.allocateCourseButton.Name = "allocateCourseButton";
            this.allocateCourseButton.Size = new System.Drawing.Size(253, 54);
            this.allocateCourseButton.TabIndex = 4;
            this.allocateCourseButton.Text = "Allocate Course";
            this.allocateCourseButton.UseVisualStyleBackColor = false;
            this.allocateCourseButton.Click += new System.EventHandler(this.allocateCourseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewStudentsButton);
            this.panel1.Controls.Add(this.viewAllocatedCoursesButton);
            this.panel1.Controls.Add(this.addTeacherButton);
            this.panel1.Controls.Add(this.ViewTeacherButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(262, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 64);
            this.panel1.TabIndex = 4;
            // 
            // ViewStudentsButton
            // 
            this.ViewStudentsButton.BackColor = System.Drawing.Color.Blue;
            this.ViewStudentsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentsButton.Location = new System.Drawing.Point(336, 0);
            this.ViewStudentsButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ViewStudentsButton.Name = "ViewStudentsButton";
            this.ViewStudentsButton.Size = new System.Drawing.Size(150, 64);
            this.ViewStudentsButton.TabIndex = 5;
            this.ViewStudentsButton.Text = "View Students";
            this.ViewStudentsButton.UseVisualStyleBackColor = false;
            this.ViewStudentsButton.Visible = false;
            this.ViewStudentsButton.Click += new System.EventHandler(this.ViewStudentsButton_Click);
            // 
            // viewAllocatedCoursesButton
            // 
            this.viewAllocatedCoursesButton.BackColor = System.Drawing.Color.Blue;
            this.viewAllocatedCoursesButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewAllocatedCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllocatedCoursesButton.Location = new System.Drawing.Point(486, 0);
            this.viewAllocatedCoursesButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.viewAllocatedCoursesButton.Name = "viewAllocatedCoursesButton";
            this.viewAllocatedCoursesButton.Size = new System.Drawing.Size(150, 64);
            this.viewAllocatedCoursesButton.TabIndex = 4;
            this.viewAllocatedCoursesButton.Text = "View Allocated Courses";
            this.viewAllocatedCoursesButton.UseVisualStyleBackColor = false;
            this.viewAllocatedCoursesButton.Visible = false;
            this.viewAllocatedCoursesButton.Click += new System.EventHandler(this.viewAllocatedCoursesButton_Click);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.BackColor = System.Drawing.Color.Blue;
            this.addTeacherButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.addTeacherButton.Location = new System.Drawing.Point(636, 0);
            this.addTeacherButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(125, 64);
            this.addTeacherButton.TabIndex = 3;
            this.addTeacherButton.Text = "Add Teacher";
            this.addTeacherButton.UseVisualStyleBackColor = false;
            this.addTeacherButton.Visible = false;
            // 
            // ViewTeacherButton
            // 
            this.ViewTeacherButton.BackColor = System.Drawing.Color.Blue;
            this.ViewTeacherButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ViewTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.ViewTeacherButton.Location = new System.Drawing.Point(761, 0);
            this.ViewTeacherButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ViewTeacherButton.Name = "ViewTeacherButton";
            this.ViewTeacherButton.Size = new System.Drawing.Size(140, 64);
            this.ViewTeacherButton.TabIndex = 2;
            this.ViewTeacherButton.Text = "View Teachers";
            this.ViewTeacherButton.UseVisualStyleBackColor = false;
            this.ViewTeacherButton.Visible = false;
            this.ViewTeacherButton.Click += new System.EventHandler(this.ViewTeacherButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1163, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button allocateCourseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewStudentsButton;
        private System.Windows.Forms.Button viewAllocatedCoursesButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button ViewTeacherButton;
    }
}