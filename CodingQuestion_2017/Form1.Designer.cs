namespace CodingQuestion_2017
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
      this.btnDrawTiangles = new System.Windows.Forms.Button();
      this.cboRows = new System.Windows.Forms.ComboBox();
      this.cboColumns = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPixelCount = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnClearTriangles = new System.Windows.Forms.Button();
      this.gbDrawTriangles = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.gbFindTriangles = new System.Windows.Forms.GroupBox();
      this.lblImageLocation = new System.Windows.Forms.Label();
      this.btnLocateImage = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cboX3Y3Values = new System.Windows.Forms.ComboBox();
      this.cboX2Y2Values = new System.Windows.Forms.ComboBox();
      this.cboX1Y1Values = new System.Windows.Forms.ComboBox();
      this.gbDrawTriangles.SuspendLayout();
      this.gbFindTriangles.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnDrawTiangles
      // 
      this.btnDrawTiangles.Location = new System.Drawing.Point(64, 73);
      this.btnDrawTiangles.Name = "btnDrawTiangles";
      this.btnDrawTiangles.Size = new System.Drawing.Size(121, 23);
      this.btnDrawTiangles.TabIndex = 0;
      this.btnDrawTiangles.Text = "Draw Triangles";
      this.btnDrawTiangles.UseVisualStyleBackColor = true;
      this.btnDrawTiangles.Click += new System.EventHandler(this.btnDrawTiangles_Click);
      // 
      // cboRows
      // 
      this.cboRows.FormattingEnabled = true;
      this.cboRows.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
      this.cboRows.Location = new System.Drawing.Point(64, 19);
      this.cboRows.Name = "cboRows";
      this.cboRows.Size = new System.Drawing.Size(121, 21);
      this.cboRows.TabIndex = 1;
      // 
      // cboColumns
      // 
      this.cboColumns.FormattingEnabled = true;
      this.cboColumns.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
      this.cboColumns.Location = new System.Drawing.Point(64, 46);
      this.cboColumns.Name = "cboColumns";
      this.cboColumns.Size = new System.Drawing.Size(121, 21);
      this.cboColumns.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Rows:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Columns:";
      // 
      // txtPixelCount
      // 
      this.txtPixelCount.Location = new System.Drawing.Point(64, 102);
      this.txtPixelCount.Name = "txtPixelCount";
      this.txtPixelCount.Size = new System.Drawing.Size(121, 20);
      this.txtPixelCount.TabIndex = 7;
      this.txtPixelCount.Text = "10";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 105);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "# Pixels:";
      // 
      // btnClearTriangles
      // 
      this.btnClearTriangles.Location = new System.Drawing.Point(11, 203);
      this.btnClearTriangles.Name = "btnClearTriangles";
      this.btnClearTriangles.Size = new System.Drawing.Size(174, 23);
      this.btnClearTriangles.TabIndex = 11;
      this.btnClearTriangles.Text = "Clear Triangles";
      this.btnClearTriangles.UseVisualStyleBackColor = true;
      this.btnClearTriangles.Click += new System.EventHandler(this.btnClearTriangles_Click);
      // 
      // gbDrawTriangles
      // 
      this.gbDrawTriangles.Controls.Add(this.label7);
      this.gbDrawTriangles.Controls.Add(this.cboRows);
      this.gbDrawTriangles.Controls.Add(this.btnDrawTiangles);
      this.gbDrawTriangles.Controls.Add(this.btnClearTriangles);
      this.gbDrawTriangles.Controls.Add(this.cboColumns);
      this.gbDrawTriangles.Controls.Add(this.label1);
      this.gbDrawTriangles.Controls.Add(this.label3);
      this.gbDrawTriangles.Controls.Add(this.label2);
      this.gbDrawTriangles.Controls.Add(this.txtPixelCount);
      this.gbDrawTriangles.Location = new System.Drawing.Point(1272, 12);
      this.gbDrawTriangles.Name = "gbDrawTriangles";
      this.gbDrawTriangles.Size = new System.Drawing.Size(200, 240);
      this.gbDrawTriangles.TabIndex = 12;
      this.gbDrawTriangles.TabStop = false;
      this.gbDrawTriangles.Text = "Draw Triangles";
      // 
      // label7
      // 
      this.label7.Location = new System.Drawing.Point(6, 125);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(179, 47);
      this.label7.TabIndex = 14;
      this.label7.Text = "Please Note: Please enter a number no larger than 90 to ensure proper display.";
      // 
      // gbFindTriangles
      // 
      this.gbFindTriangles.Controls.Add(this.lblImageLocation);
      this.gbFindTriangles.Controls.Add(this.btnLocateImage);
      this.gbFindTriangles.Controls.Add(this.label6);
      this.gbFindTriangles.Controls.Add(this.label5);
      this.gbFindTriangles.Controls.Add(this.label4);
      this.gbFindTriangles.Controls.Add(this.cboX3Y3Values);
      this.gbFindTriangles.Controls.Add(this.cboX2Y2Values);
      this.gbFindTriangles.Controls.Add(this.cboX1Y1Values);
      this.gbFindTriangles.Location = new System.Drawing.Point(1272, 258);
      this.gbFindTriangles.Name = "gbFindTriangles";
      this.gbFindTriangles.Size = new System.Drawing.Size(200, 209);
      this.gbFindTriangles.TabIndex = 13;
      this.gbFindTriangles.TabStop = false;
      this.gbFindTriangles.Text = "Find Triangles";
      // 
      // lblImageLocation
      // 
      this.lblImageLocation.Location = new System.Drawing.Point(14, 156);
      this.lblImageLocation.Name = "lblImageLocation";
      this.lblImageLocation.Size = new System.Drawing.Size(171, 47);
      this.lblImageLocation.TabIndex = 7;
      // 
      // btnLocateImage
      // 
      this.btnLocateImage.Enabled = false;
      this.btnLocateImage.Location = new System.Drawing.Point(64, 114);
      this.btnLocateImage.Name = "btnLocateImage";
      this.btnLocateImage.Size = new System.Drawing.Size(121, 23);
      this.btnLocateImage.TabIndex = 6;
      this.btnLocateImage.Text = "Locate Image";
      this.btnLocateImage.UseVisualStyleBackColor = true;
      this.btnLocateImage.Click += new System.EventHandler(this.btnLocateImage_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(22, 90);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(36, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "X3Y3:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(22, 63);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(36, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "X2Y2:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 36);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(36, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "X1Y1:";
      // 
      // cboX3Y3Values
      // 
      this.cboX3Y3Values.Enabled = false;
      this.cboX3Y3Values.FormattingEnabled = true;
      this.cboX3Y3Values.Location = new System.Drawing.Point(64, 87);
      this.cboX3Y3Values.Name = "cboX3Y3Values";
      this.cboX3Y3Values.Size = new System.Drawing.Size(121, 21);
      this.cboX3Y3Values.TabIndex = 2;
      this.cboX3Y3Values.SelectedIndexChanged += new System.EventHandler(this.cboX3Y3Values_SelectedIndexChanged);
      // 
      // cboX2Y2Values
      // 
      this.cboX2Y2Values.Enabled = false;
      this.cboX2Y2Values.FormattingEnabled = true;
      this.cboX2Y2Values.Location = new System.Drawing.Point(64, 60);
      this.cboX2Y2Values.Name = "cboX2Y2Values";
      this.cboX2Y2Values.Size = new System.Drawing.Size(121, 21);
      this.cboX2Y2Values.TabIndex = 1;
      this.cboX2Y2Values.SelectedIndexChanged += new System.EventHandler(this.cboX2Y2Values_SelectedIndexChanged);
      // 
      // cboX1Y1Values
      // 
      this.cboX1Y1Values.Enabled = false;
      this.cboX1Y1Values.FormattingEnabled = true;
      this.cboX1Y1Values.Location = new System.Drawing.Point(64, 33);
      this.cboX1Y1Values.Name = "cboX1Y1Values";
      this.cboX1Y1Values.Size = new System.Drawing.Size(121, 21);
      this.cboX1Y1Values.TabIndex = 0;
      this.cboX1Y1Values.SelectedIndexChanged += new System.EventHandler(this.cboX1Y1Values_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1484, 962);
      this.Controls.Add(this.gbFindTriangles);
      this.Controls.Add(this.gbDrawTriangles);
      this.Name = "Form1";
      this.Text = "Cherwell (CodingQuestion-2017)";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.gbDrawTriangles.ResumeLayout(false);
      this.gbDrawTriangles.PerformLayout();
      this.gbFindTriangles.ResumeLayout(false);
      this.gbFindTriangles.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnDrawTiangles;
    private System.Windows.Forms.ComboBox cboRows;
    private System.Windows.Forms.ComboBox cboColumns;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPixelCount;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnClearTriangles;
    private System.Windows.Forms.GroupBox gbDrawTriangles;
    private System.Windows.Forms.GroupBox gbFindTriangles;
    private System.Windows.Forms.Button btnLocateImage;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cboX3Y3Values;
    private System.Windows.Forms.ComboBox cboX2Y2Values;
    private System.Windows.Forms.ComboBox cboX1Y1Values;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblImageLocation;
  }
}

