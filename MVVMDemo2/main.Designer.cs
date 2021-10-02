namespace MVVMDemo2
{
   partial class frmMain
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
         System.Windows.Forms.Label data1Label;
         System.Windows.Forms.Label data2Label;
         System.Windows.Forms.Label data3Label;
         System.Windows.Forms.Label mVVMTestIDLabel;
         this.mydataBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.data1TextBox = new System.Windows.Forms.TextBox();
         this.data2TextBox = new System.Windows.Forms.TextBox();
         this.data3TextBox = new System.Windows.Forms.TextBox();
         this.mVVMTestIDTextBox = new System.Windows.Forms.TextBox();
         this.cmdNew = new System.Windows.Forms.Button();
         this.lblDBInstructions = new System.Windows.Forms.Label();
         this.dgMyData = new System.Windows.Forms.DataGridView();
         this.mVVMTestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.data1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.data2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.data3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.cmdDelete = new System.Windows.Forms.Button();
         this.cmdSave = new System.Windows.Forms.Button();
         data1Label = new System.Windows.Forms.Label();
         data2Label = new System.Windows.Forms.Label();
         data3Label = new System.Windows.Forms.Label();
         mVVMTestIDLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.mydataBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgMyData)).BeginInit();
         this.SuspendLayout();
         // 
         // data1Label
         // 
         data1Label.AutoSize = true;
         data1Label.Location = new System.Drawing.Point(65, 150);
         data1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         data1Label.Name = "data1Label";
         data1Label.Size = new System.Drawing.Size(82, 23);
         data1Label.TabIndex = 1;
         data1Label.Text = "Data1:";
         // 
         // data2Label
         // 
         data2Label.AutoSize = true;
         data2Label.Location = new System.Drawing.Point(65, 190);
         data2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         data2Label.Name = "data2Label";
         data2Label.Size = new System.Drawing.Size(82, 23);
         data2Label.TabIndex = 3;
         data2Label.Text = "Data2:";
         // 
         // data3Label
         // 
         data3Label.AutoSize = true;
         data3Label.Location = new System.Drawing.Point(65, 231);
         data3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         data3Label.Name = "data3Label";
         data3Label.Size = new System.Drawing.Size(82, 23);
         data3Label.TabIndex = 5;
         data3Label.Text = "Data3:";
         // 
         // mVVMTestIDLabel
         // 
         mVVMTestIDLabel.AutoSize = true;
         mVVMTestIDLabel.Location = new System.Drawing.Point(65, 91);
         mVVMTestIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         mVVMTestIDLabel.Name = "mVVMTestIDLabel";
         mVVMTestIDLabel.Size = new System.Drawing.Size(154, 23);
         mVVMTestIDLabel.TabIndex = 7;
         mVVMTestIDLabel.Text = "MVVMTest ID:";
         // 
         // mydataBindingSource
         // 
         this.mydataBindingSource.DataSource = typeof(MVVMDemo2.tblMVVMTest);
         // 
         // data1TextBox
         // 
         this.data1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mydataBindingSource, "Data1", true));
         this.data1TextBox.Location = new System.Drawing.Point(219, 146);
         this.data1TextBox.Margin = new System.Windows.Forms.Padding(4);
         this.data1TextBox.Name = "data1TextBox";
         this.data1TextBox.Size = new System.Drawing.Size(387, 30);
         this.data1TextBox.TabIndex = 2;
         // 
         // data2TextBox
         // 
         this.data2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mydataBindingSource, "Data2", true));
         this.data2TextBox.Location = new System.Drawing.Point(219, 186);
         this.data2TextBox.Margin = new System.Windows.Forms.Padding(4);
         this.data2TextBox.Name = "data2TextBox";
         this.data2TextBox.Size = new System.Drawing.Size(387, 30);
         this.data2TextBox.TabIndex = 4;
         // 
         // data3TextBox
         // 
         this.data3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mydataBindingSource, "Data3", true));
         this.data3TextBox.Location = new System.Drawing.Point(219, 226);
         this.data3TextBox.Margin = new System.Windows.Forms.Padding(4);
         this.data3TextBox.Name = "data3TextBox";
         this.data3TextBox.Size = new System.Drawing.Size(387, 30);
         this.data3TextBox.TabIndex = 6;
         // 
         // mVVMTestIDTextBox
         // 
         this.mVVMTestIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mydataBindingSource, "MVVMTestID", true));
         this.mVVMTestIDTextBox.Location = new System.Drawing.Point(219, 87);
         this.mVVMTestIDTextBox.Margin = new System.Windows.Forms.Padding(4);
         this.mVVMTestIDTextBox.Name = "mVVMTestIDTextBox";
         this.mVVMTestIDTextBox.Size = new System.Drawing.Size(148, 30);
         this.mVVMTestIDTextBox.TabIndex = 8;
         // 
         // cmdNew
         // 
         this.cmdNew.Location = new System.Drawing.Point(65, 524);
         this.cmdNew.Margin = new System.Windows.Forms.Padding(4);
         this.cmdNew.Name = "cmdNew";
         this.cmdNew.Size = new System.Drawing.Size(150, 42);
         this.cmdNew.TabIndex = 9;
         this.cmdNew.Text = "New";
         this.cmdNew.UseVisualStyleBackColor = true;
         // 
         // lblDBInstructions
         // 
         this.lblDBInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblDBInstructions.Location = new System.Drawing.Point(65, 27);
         this.lblDBInstructions.Name = "lblDBInstructions";
         this.lblDBInstructions.Size = new System.Drawing.Size(743, 56);
         this.lblDBInstructions.TabIndex = 10;
         this.lblDBInstructions.Text = "DB Instructions: Create a table <tblMVVMTest> with columns: MVVMTestID (PK Identi" +
    "ty), Data1-Data3 (nvarchar(50))";
         // 
         // dgMyData
         // 
         this.dgMyData.AutoGenerateColumns = false;
         this.dgMyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgMyData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mVVMTestIDDataGridViewTextBoxColumn,
            this.data1DataGridViewTextBoxColumn,
            this.data2DataGridViewTextBoxColumn,
            this.data3DataGridViewTextBoxColumn});
         this.dgMyData.DataSource = this.mydataBindingSource;
         this.dgMyData.Location = new System.Drawing.Point(65, 291);
         this.dgMyData.Name = "dgMyData";
         this.dgMyData.RowTemplate.Height = 24;
         this.dgMyData.Size = new System.Drawing.Size(743, 226);
         this.dgMyData.TabIndex = 11;
         // 
         // mVVMTestIDDataGridViewTextBoxColumn
         // 
         this.mVVMTestIDDataGridViewTextBoxColumn.DataPropertyName = "MVVMTestID";
         this.mVVMTestIDDataGridViewTextBoxColumn.HeaderText = "MVVMTestID";
         this.mVVMTestIDDataGridViewTextBoxColumn.Name = "mVVMTestIDDataGridViewTextBoxColumn";
         // 
         // data1DataGridViewTextBoxColumn
         // 
         this.data1DataGridViewTextBoxColumn.DataPropertyName = "Data1";
         this.data1DataGridViewTextBoxColumn.HeaderText = "Data1";
         this.data1DataGridViewTextBoxColumn.Name = "data1DataGridViewTextBoxColumn";
         // 
         // data2DataGridViewTextBoxColumn
         // 
         this.data2DataGridViewTextBoxColumn.DataPropertyName = "Data2";
         this.data2DataGridViewTextBoxColumn.HeaderText = "Data2";
         this.data2DataGridViewTextBoxColumn.Name = "data2DataGridViewTextBoxColumn";
         // 
         // data3DataGridViewTextBoxColumn
         // 
         this.data3DataGridViewTextBoxColumn.DataPropertyName = "Data3";
         this.data3DataGridViewTextBoxColumn.HeaderText = "Data3";
         this.data3DataGridViewTextBoxColumn.Name = "data3DataGridViewTextBoxColumn";
         // 
         // cmdDelete
         // 
         this.cmdDelete.Location = new System.Drawing.Point(223, 524);
         this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
         this.cmdDelete.Name = "cmdDelete";
         this.cmdDelete.Size = new System.Drawing.Size(150, 42);
         this.cmdDelete.TabIndex = 12;
         this.cmdDelete.Text = "Delete";
         this.cmdDelete.UseVisualStyleBackColor = true;
         // 
         // cmdSave
         // 
         this.cmdSave.Location = new System.Drawing.Point(381, 524);
         this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.Size = new System.Drawing.Size(150, 42);
         this.cmdSave.TabIndex = 13;
         this.cmdSave.Text = "Save";
         this.cmdSave.UseVisualStyleBackColor = true;
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 647);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.cmdDelete);
         this.Controls.Add(this.dgMyData);
         this.Controls.Add(this.lblDBInstructions);
         this.Controls.Add(this.cmdNew);
         this.Controls.Add(data1Label);
         this.Controls.Add(this.data1TextBox);
         this.Controls.Add(data2Label);
         this.Controls.Add(this.data2TextBox);
         this.Controls.Add(data3Label);
         this.Controls.Add(this.data3TextBox);
         this.Controls.Add(mVVMTestIDLabel);
         this.Controls.Add(this.mVVMTestIDTextBox);
         this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmMain";
         this.Text = "MVVM Demo with EF";
         ((System.ComponentModel.ISupportInitialize)(this.mydataBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgMyData)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.BindingSource mydataBindingSource;
      private System.Windows.Forms.TextBox data1TextBox;
      private System.Windows.Forms.TextBox data2TextBox;
      private System.Windows.Forms.TextBox data3TextBox;
      private System.Windows.Forms.TextBox mVVMTestIDTextBox;
      private System.Windows.Forms.Button cmdNew;
      private System.Windows.Forms.Label lblDBInstructions;
      private System.Windows.Forms.DataGridView dgMyData;
      private System.Windows.Forms.DataGridViewTextBoxColumn mVVMTestIDDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn data1DataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn data2DataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn data3DataGridViewTextBoxColumn;
      private System.Windows.Forms.Button cmdDelete;
      private System.Windows.Forms.Button cmdSave;
   }
}

