namespace JorawarVideoRentalSystem
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
            this.JCopies = new System.Windows.Forms.NumericUpDown();
            this.JCost = new System.Windows.Forms.NumericUpDown();
            this.JYear = new System.Windows.Forms.NumericUpDown();
            this.JMobileNo = new System.Windows.Forms.NumericUpDown();
            this.JGenre = new System.Windows.Forms.TextBox();
            this.JPlot = new System.Windows.Forms.TextBox();
            this.JRatting = new System.Windows.Forms.TextBox();
            this.Jtitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.JMovieID = new System.Windows.Forms.TextBox();
            this.JCustomerID = new System.Windows.Forms.TextBox();
            this.JDelete = new System.Windows.Forms.Button();
            this.JReturn = new System.Windows.Forms.Button();
            this.JBooking = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.JdelCustomer = new System.Windows.Forms.Button();
            this.JupdateCustomer = new System.Windows.Forms.Button();
            this.JaddCustomer = new System.Windows.Forms.Button();
            this.JAddress = new System.Windows.Forms.TextBox();
            this.JLName = new System.Windows.Forms.TextBox();
            this.JName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.jIssueDate = new System.Windows.Forms.TextBox();
            this.JReturnDate = new System.Windows.Forms.TextBox();
            this.JdelVideoCD = new System.Windows.Forms.Button();
            this.JupdateVideoCD = new System.Windows.Forms.Button();
            this.JAddVideo = new System.Windows.Forms.Button();
            this.database = new System.Windows.Forms.DataGridView();
            this.JVideo = new System.Windows.Forms.Button();
            this.JCustomer = new System.Windows.Forms.Button();
            this.JRent = new System.Windows.Forms.Button();
            this.JTopMovie = new System.Windows.Forms.Button();
            this.JTopCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JMobileNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            this.SuspendLayout();
            // 
            // JCopies
            // 
            this.JCopies.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JCopies.Location = new System.Drawing.Point(139, 160);
            this.JCopies.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.JCopies.Name = "JCopies";
            this.JCopies.Size = new System.Drawing.Size(154, 29);
            this.JCopies.TabIndex = 145;
            this.JCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JCopies_KeyPress);
            // 
            // JCost
            // 
            this.JCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JCost.Location = new System.Drawing.Point(139, 196);
            this.JCost.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.JCost.Name = "JCost";
            this.JCost.Size = new System.Drawing.Size(154, 29);
            this.JCost.TabIndex = 144;
            // 
            // JYear
            // 
            this.JYear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JYear.Location = new System.Drawing.Point(139, 125);
            this.JYear.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.JYear.Name = "JYear";
            this.JYear.Size = new System.Drawing.Size(154, 29);
            this.JYear.TabIndex = 143;
            // 
            // JMobileNo
            // 
            this.JMobileNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMobileNo.Location = new System.Drawing.Point(429, 126);
            this.JMobileNo.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.JMobileNo.Name = "JMobileNo";
            this.JMobileNo.Size = new System.Drawing.Size(154, 29);
            this.JMobileNo.TabIndex = 142;
            // 
            // JGenre
            // 
            this.JGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JGenre.Location = new System.Drawing.Point(139, 269);
            this.JGenre.Name = "JGenre";
            this.JGenre.Size = new System.Drawing.Size(154, 32);
            this.JGenre.TabIndex = 141;
            // 
            // JPlot
            // 
            this.JPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPlot.Location = new System.Drawing.Point(139, 231);
            this.JPlot.Name = "JPlot";
            this.JPlot.Size = new System.Drawing.Size(154, 32);
            this.JPlot.TabIndex = 140;
            // 
            // JRatting
            // 
            this.JRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JRatting.Location = new System.Drawing.Point(139, 83);
            this.JRatting.Name = "JRatting";
            this.JRatting.Size = new System.Drawing.Size(154, 32);
            this.JRatting.TabIndex = 139;
            // 
            // Jtitle
            // 
            this.Jtitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jtitle.Location = new System.Drawing.Point(139, 45);
            this.Jtitle.Name = "Jtitle";
            this.Jtitle.Size = new System.Drawing.Size(154, 32);
            this.Jtitle.TabIndex = 138;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 137;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 136;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 135;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 134;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 133;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 132;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 131;
            this.label16.Text = "Title";
            // 
            // JMovieID
            // 
            this.JMovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMovieID.Location = new System.Drawing.Point(764, 89);
            this.JMovieID.Name = "JMovieID";
            this.JMovieID.Size = new System.Drawing.Size(154, 32);
            this.JMovieID.TabIndex = 130;
            // 
            // JCustomerID
            // 
            this.JCustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JCustomerID.Location = new System.Drawing.Point(764, 48);
            this.JCustomerID.Name = "JCustomerID";
            this.JCustomerID.Size = new System.Drawing.Size(154, 32);
            this.JCustomerID.TabIndex = 129;
            // 
            // JDelete
            // 
            this.JDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JDelete.Location = new System.Drawing.Point(608, 247);
            this.JDelete.Name = "JDelete";
            this.JDelete.Size = new System.Drawing.Size(274, 37);
            this.JDelete.TabIndex = 126;
            this.JDelete.Text = "Delete";
            this.JDelete.UseVisualStyleBackColor = true;
            this.JDelete.Click += new System.EventHandler(this.JDelete_Click);
            // 
            // JReturn
            // 
            this.JReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JReturn.Location = new System.Drawing.Point(728, 209);
            this.JReturn.Name = "JReturn";
            this.JReturn.Size = new System.Drawing.Size(154, 32);
            this.JReturn.TabIndex = 125;
            this.JReturn.Text = "Return";
            this.JReturn.UseVisualStyleBackColor = true;
            this.JReturn.Click += new System.EventHandler(this.JReturn_Click);
            // 
            // JBooking
            // 
            this.JBooking.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JBooking.Location = new System.Drawing.Point(606, 209);
            this.JBooking.Name = "JBooking";
            this.JBooking.Size = new System.Drawing.Size(101, 32);
            this.JBooking.TabIndex = 124;
            this.JBooking.Text = "Issue";
            this.JBooking.UseVisualStyleBackColor = true;
            this.JBooking.Click += new System.EventHandler(this.JBooking_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(603, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 123;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(603, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 122;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(602, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 121;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(602, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 120;
            this.label15.Text = "Customer ID";
            // 
            // JdelCustomer
            // 
            this.JdelCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JdelCustomer.Location = new System.Drawing.Point(309, 244);
            this.JdelCustomer.Name = "JdelCustomer";
            this.JdelCustomer.Size = new System.Drawing.Size(274, 37);
            this.JdelCustomer.TabIndex = 119;
            this.JdelCustomer.Text = "Delete";
            this.JdelCustomer.UseVisualStyleBackColor = true;
            this.JdelCustomer.Click += new System.EventHandler(this.JdelCustomer_Click);
            // 
            // JupdateCustomer
            // 
            this.JupdateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JupdateCustomer.Location = new System.Drawing.Point(429, 206);
            this.JupdateCustomer.Name = "JupdateCustomer";
            this.JupdateCustomer.Size = new System.Drawing.Size(154, 32);
            this.JupdateCustomer.TabIndex = 118;
            this.JupdateCustomer.Text = "Update";
            this.JupdateCustomer.UseVisualStyleBackColor = true;
            this.JupdateCustomer.Click += new System.EventHandler(this.JupdateCustomer_Click);
            // 
            // JaddCustomer
            // 
            this.JaddCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JaddCustomer.Location = new System.Drawing.Point(307, 206);
            this.JaddCustomer.Name = "JaddCustomer";
            this.JaddCustomer.Size = new System.Drawing.Size(101, 32);
            this.JaddCustomer.TabIndex = 116;
            this.JaddCustomer.Text = "Add";
            this.JaddCustomer.UseVisualStyleBackColor = true;
            this.JaddCustomer.Click += new System.EventHandler(this.JaddCustomer_Click);
            // 
            // JAddress
            // 
            this.JAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JAddress.Location = new System.Drawing.Point(429, 162);
            this.JAddress.Name = "JAddress";
            this.JAddress.Size = new System.Drawing.Size(154, 32);
            this.JAddress.TabIndex = 117;
            // 
            // JLName
            // 
            this.JLName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JLName.Location = new System.Drawing.Point(429, 86);
            this.JLName.Name = "JLName";
            this.JLName.Size = new System.Drawing.Size(154, 32);
            this.JLName.TabIndex = 115;
            // 
            // JName
            // 
            this.JName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JName.Location = new System.Drawing.Point(429, 48);
            this.JName.Name = "JName";
            this.JName.Size = new System.Drawing.Size(154, 32);
            this.JName.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 113;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 112;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(303, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 24);
            this.label10.TabIndex = 111;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 24);
            this.label11.TabIndex = 110;
            this.label11.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 146;
            this.label1.Text = "Video Data";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(370, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 24);
            this.label17.TabIndex = 147;
            this.label17.Text = "Customer";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(689, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 24);
            this.label18.TabIndex = 148;
            this.label18.Text = "Rental System";
            // 
            // jIssueDate
            // 
            this.jIssueDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jIssueDate.Location = new System.Drawing.Point(766, 130);
            this.jIssueDate.Name = "jIssueDate";
            this.jIssueDate.Size = new System.Drawing.Size(154, 32);
            this.jIssueDate.TabIndex = 149;
            // 
            // JReturnDate
            // 
            this.JReturnDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JReturnDate.Location = new System.Drawing.Point(766, 168);
            this.JReturnDate.Name = "JReturnDate";
            this.JReturnDate.Size = new System.Drawing.Size(154, 32);
            this.JReturnDate.TabIndex = 150;
            // 
            // JdelVideoCD
            // 
            this.JdelVideoCD.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JdelVideoCD.Location = new System.Drawing.Point(203, 316);
            this.JdelVideoCD.Name = "JdelVideoCD";
            this.JdelVideoCD.Size = new System.Drawing.Size(85, 32);
            this.JdelVideoCD.TabIndex = 153;
            this.JdelVideoCD.Text = "Delete";
            this.JdelVideoCD.UseVisualStyleBackColor = true;
            this.JdelVideoCD.Click += new System.EventHandler(this.JdelVideoCD_Click);
            // 
            // JupdateVideoCD
            // 
            this.JupdateVideoCD.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JupdateVideoCD.Location = new System.Drawing.Point(112, 316);
            this.JupdateVideoCD.Name = "JupdateVideoCD";
            this.JupdateVideoCD.Size = new System.Drawing.Size(85, 32);
            this.JupdateVideoCD.TabIndex = 152;
            this.JupdateVideoCD.Text = "Update";
            this.JupdateVideoCD.UseVisualStyleBackColor = true;
            this.JupdateVideoCD.Click += new System.EventHandler(this.JupdateVideoCD_Click);
            // 
            // JAddVideo
            // 
            this.JAddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JAddVideo.Location = new System.Drawing.Point(21, 316);
            this.JAddVideo.Name = "JAddVideo";
            this.JAddVideo.Size = new System.Drawing.Size(85, 32);
            this.JAddVideo.TabIndex = 151;
            this.JAddVideo.Text = "Add";
            this.JAddVideo.UseVisualStyleBackColor = true;
            this.JAddVideo.Click += new System.EventHandler(this.JAddVideo_Click);
            // 
            // database
            // 
            this.database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database.Location = new System.Drawing.Point(294, 316);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(613, 276);
            this.database.TabIndex = 154;
            this.database.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_CellContentClick);
            // 
            // JVideo
            // 
            this.JVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JVideo.Location = new System.Drawing.Point(52, 354);
            this.JVideo.Name = "JVideo";
            this.JVideo.Size = new System.Drawing.Size(200, 37);
            this.JVideo.TabIndex = 155;
            this.JVideo.Text = "Video";
            this.JVideo.UseVisualStyleBackColor = true;
            this.JVideo.Click += new System.EventHandler(this.JVideo_Click);
            // 
            // JCustomer
            // 
            this.JCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JCustomer.Location = new System.Drawing.Point(52, 397);
            this.JCustomer.Name = "JCustomer";
            this.JCustomer.Size = new System.Drawing.Size(200, 37);
            this.JCustomer.TabIndex = 156;
            this.JCustomer.Text = "Customer";
            this.JCustomer.UseVisualStyleBackColor = true;
            this.JCustomer.Click += new System.EventHandler(this.JCustomer_Click);
            // 
            // JRent
            // 
            this.JRent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JRent.Location = new System.Drawing.Point(52, 440);
            this.JRent.Name = "JRent";
            this.JRent.Size = new System.Drawing.Size(200, 37);
            this.JRent.TabIndex = 157;
            this.JRent.Text = "Rent";
            this.JRent.UseVisualStyleBackColor = true;
            this.JRent.Click += new System.EventHandler(this.JRent_Click);
            // 
            // JTopMovie
            // 
            this.JTopMovie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTopMovie.Location = new System.Drawing.Point(52, 483);
            this.JTopMovie.Name = "JTopMovie";
            this.JTopMovie.Size = new System.Drawing.Size(200, 37);
            this.JTopMovie.TabIndex = 158;
            this.JTopMovie.Text = "Top Movie";
            this.JTopMovie.UseVisualStyleBackColor = true;
            this.JTopMovie.Click += new System.EventHandler(this.JTopMovie_Click);
            // 
            // JTopCustomer
            // 
            this.JTopCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTopCustomer.Location = new System.Drawing.Point(52, 526);
            this.JTopCustomer.Name = "JTopCustomer";
            this.JTopCustomer.Size = new System.Drawing.Size(200, 37);
            this.JTopCustomer.TabIndex = 159;
            this.JTopCustomer.Text = "Top Customer";
            this.JTopCustomer.UseVisualStyleBackColor = true;
            this.JTopCustomer.Click += new System.EventHandler(this.JTopCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(949, 626);
            this.Controls.Add(this.JTopCustomer);
            this.Controls.Add(this.JTopMovie);
            this.Controls.Add(this.JRent);
            this.Controls.Add(this.JCustomer);
            this.Controls.Add(this.JVideo);
            this.Controls.Add(this.database);
            this.Controls.Add(this.JdelVideoCD);
            this.Controls.Add(this.JupdateVideoCD);
            this.Controls.Add(this.JAddVideo);
            this.Controls.Add(this.JReturnDate);
            this.Controls.Add(this.jIssueDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JCopies);
            this.Controls.Add(this.JCost);
            this.Controls.Add(this.JYear);
            this.Controls.Add(this.JMobileNo);
            this.Controls.Add(this.JGenre);
            this.Controls.Add(this.JPlot);
            this.Controls.Add(this.JRatting);
            this.Controls.Add(this.Jtitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.JMovieID);
            this.Controls.Add(this.JCustomerID);
            this.Controls.Add(this.JDelete);
            this.Controls.Add(this.JReturn);
            this.Controls.Add(this.JBooking);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.JdelCustomer);
            this.Controls.Add(this.JupdateCustomer);
            this.Controls.Add(this.JaddCustomer);
            this.Controls.Add(this.JAddress);
            this.Controls.Add(this.JLName);
            this.Controls.Add(this.JName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.JCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JMobileNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown JCopies;
        private System.Windows.Forms.NumericUpDown JCost;
        private System.Windows.Forms.NumericUpDown JYear;
        private System.Windows.Forms.NumericUpDown JMobileNo;
        private System.Windows.Forms.TextBox JGenre;
        private System.Windows.Forms.TextBox JPlot;
        private System.Windows.Forms.TextBox JRatting;
        private System.Windows.Forms.TextBox Jtitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox JMovieID;
        private System.Windows.Forms.TextBox JCustomerID;
        private System.Windows.Forms.Button JDelete;
        private System.Windows.Forms.Button JReturn;
        private System.Windows.Forms.Button JBooking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button JdelCustomer;
        private System.Windows.Forms.Button JupdateCustomer;
        private System.Windows.Forms.Button JaddCustomer;
        private System.Windows.Forms.TextBox JAddress;
        private System.Windows.Forms.TextBox JLName;
        private System.Windows.Forms.TextBox JName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox jIssueDate;
        private System.Windows.Forms.TextBox JReturnDate;
        private System.Windows.Forms.Button JdelVideoCD;
        private System.Windows.Forms.Button JupdateVideoCD;
        private System.Windows.Forms.Button JAddVideo;
        private System.Windows.Forms.DataGridView database;
        private System.Windows.Forms.Button JVideo;
        private System.Windows.Forms.Button JCustomer;
        private System.Windows.Forms.Button JRent;
        private System.Windows.Forms.Button JTopMovie;
        private System.Windows.Forms.Button JTopCustomer;
    }
}

