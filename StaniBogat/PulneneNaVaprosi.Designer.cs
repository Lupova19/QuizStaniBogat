namespace StaniBogat
{
    partial class PulneneNaVaprosi
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label questionLabel;
            System.Windows.Forms.Label ansALabel;
            System.Windows.Forms.Label ansBLabel;
            System.Windows.Forms.Label ansCLabel;
            System.Windows.Forms.Label ansDLabel;
            System.Windows.Forms.Label correctAnswerLabel;
            System.Windows.Forms.Label pointsLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ansDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stani_Bogat_11d_2025DataSet = new StaniBogat.Stani_Bogat_11d_2025DataSet();
            this.questionsTableAdapter = new StaniBogat.Stani_Bogat_11d_2025DataSetTableAdapters.QuestionsTableAdapter();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tableAdapterManager = new StaniBogat.Stani_Bogat_11d_2025DataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.ansATextBox = new System.Windows.Forms.TextBox();
            this.ansBTextBox = new System.Windows.Forms.TextBox();
            this.ansCTextBox = new System.Windows.Forms.TextBox();
            this.ansDTextBox = new System.Windows.Forms.TextBox();
            this.correctAnswerTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            questionLabel = new System.Windows.Forms.Label();
            ansALabel = new System.Windows.Forms.Label();
            ansBLabel = new System.Windows.Forms.Label();
            ansCLabel = new System.Windows.Forms.Label();
            ansDLabel = new System.Windows.Forms.Label();
            correctAnswerLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stani_Bogat_11d_2025DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.ansADataGridViewTextBoxColumn,
            this.ansBDataGridViewTextBoxColumn,
            this.ansCDataGridViewTextBoxColumn,
            this.ansDDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-6, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.Width = 125;
            // 
            // ansADataGridViewTextBoxColumn
            // 
            this.ansADataGridViewTextBoxColumn.DataPropertyName = "AnsA";
            this.ansADataGridViewTextBoxColumn.HeaderText = "AnsA";
            this.ansADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ansADataGridViewTextBoxColumn.Name = "ansADataGridViewTextBoxColumn";
            this.ansADataGridViewTextBoxColumn.Width = 125;
            // 
            // ansBDataGridViewTextBoxColumn
            // 
            this.ansBDataGridViewTextBoxColumn.DataPropertyName = "AnsB";
            this.ansBDataGridViewTextBoxColumn.HeaderText = "AnsB";
            this.ansBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ansBDataGridViewTextBoxColumn.Name = "ansBDataGridViewTextBoxColumn";
            this.ansBDataGridViewTextBoxColumn.Width = 125;
            // 
            // ansCDataGridViewTextBoxColumn
            // 
            this.ansCDataGridViewTextBoxColumn.DataPropertyName = "AnsC";
            this.ansCDataGridViewTextBoxColumn.HeaderText = "AnsC";
            this.ansCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ansCDataGridViewTextBoxColumn.Name = "ansCDataGridViewTextBoxColumn";
            this.ansCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ansDDataGridViewTextBoxColumn
            // 
            this.ansDDataGridViewTextBoxColumn.DataPropertyName = "AnsD";
            this.ansDDataGridViewTextBoxColumn.HeaderText = "AnsD";
            this.ansDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ansDDataGridViewTextBoxColumn.Name = "ansDDataGridViewTextBoxColumn";
            this.ansDDataGridViewTextBoxColumn.Width = 125;
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            this.correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            this.correctAnswerDataGridViewTextBoxColumn.Width = 125;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.stani_Bogat_11d_2025DataSet;
            // 
            // stani_Bogat_11d_2025DataSet
            // 
            this.stani_Bogat_11d_2025DataSet.DataSetName = "Stani_Bogat_11d_2025DataSet";
            this.stani_Bogat_11d_2025DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(833, 171);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(221, 60);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(833, 248);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(221, 70);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Turquoise;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(833, 331);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(221, 65);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QuestionsTableAdapter = this.questionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = StaniBogat.Stani_Bogat_11d_2025DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 162);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 12;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(77, 159);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 13;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(8, 195);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new System.Drawing.Size(63, 16);
            questionLabel.TabIndex = 14;
            questionLabel.Text = "Question:";
            // 
            // questionTextBox
            // 
            this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Question", true));
            this.questionTextBox.Location = new System.Drawing.Point(77, 194);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(100, 22);
            this.questionTextBox.TabIndex = 15;
            // 
            // ansALabel
            // 
            ansALabel.AutoSize = true;
            ansALabel.Location = new System.Drawing.Point(12, 228);
            ansALabel.Name = "ansALabel";
            ansALabel.Size = new System.Drawing.Size(45, 16);
            ansALabel.TabIndex = 16;
            ansALabel.Text = "Ans A:";
            // 
            // ansATextBox
            // 
            this.ansATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsA", true));
            this.ansATextBox.Location = new System.Drawing.Point(77, 231);
            this.ansATextBox.Name = "ansATextBox";
            this.ansATextBox.Size = new System.Drawing.Size(100, 22);
            this.ansATextBox.TabIndex = 17;
            // 
            // ansBLabel
            // 
            ansBLabel.AutoSize = true;
            ansBLabel.Location = new System.Drawing.Point(12, 265);
            ansBLabel.Name = "ansBLabel";
            ansBLabel.Size = new System.Drawing.Size(45, 16);
            ansBLabel.TabIndex = 18;
            ansBLabel.Text = "Ans B:";
            // 
            // ansBTextBox
            // 
            this.ansBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsB", true));
            this.ansBTextBox.Location = new System.Drawing.Point(77, 265);
            this.ansBTextBox.Name = "ansBTextBox";
            this.ansBTextBox.Size = new System.Drawing.Size(100, 22);
            this.ansBTextBox.TabIndex = 19;
            // 
            // ansCLabel
            // 
            ansCLabel.AutoSize = true;
            ansCLabel.Location = new System.Drawing.Point(12, 302);
            ansCLabel.Name = "ansCLabel";
            ansCLabel.Size = new System.Drawing.Size(45, 16);
            ansCLabel.TabIndex = 20;
            ansCLabel.Text = "Ans C:";
            // 
            // ansCTextBox
            // 
            this.ansCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsC", true));
            this.ansCTextBox.Location = new System.Drawing.Point(77, 299);
            this.ansCTextBox.Name = "ansCTextBox";
            this.ansCTextBox.Size = new System.Drawing.Size(100, 22);
            this.ansCTextBox.TabIndex = 21;
            // 
            // ansDLabel
            // 
            ansDLabel.AutoSize = true;
            ansDLabel.Location = new System.Drawing.Point(12, 331);
            ansDLabel.Name = "ansDLabel";
            ansDLabel.Size = new System.Drawing.Size(46, 16);
            ansDLabel.TabIndex = 22;
            ansDLabel.Text = "Ans D:";
            // 
            // ansDTextBox
            // 
            this.ansDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnsD", true));
            this.ansDTextBox.Location = new System.Drawing.Point(77, 328);
            this.ansDTextBox.Name = "ansDTextBox";
            this.ansDTextBox.Size = new System.Drawing.Size(100, 22);
            this.ansDTextBox.TabIndex = 23;
            // 
            // correctAnswerLabel
            // 
            correctAnswerLabel.AutoSize = true;
            correctAnswerLabel.Location = new System.Drawing.Point(10, 363);
            correctAnswerLabel.Name = "correctAnswerLabel";
            correctAnswerLabel.Size = new System.Drawing.Size(100, 16);
            correctAnswerLabel.TabIndex = 24;
            correctAnswerLabel.Text = "Correct Answer:";
            // 
            // correctAnswerTextBox
            // 
            this.correctAnswerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "CorrectAnswer", true));
            this.correctAnswerTextBox.Location = new System.Drawing.Point(116, 357);
            this.correctAnswerTextBox.Name = "correctAnswerTextBox";
            this.correctAnswerTextBox.Size = new System.Drawing.Size(100, 22);
            this.correctAnswerTextBox.TabIndex = 25;
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new System.Drawing.Point(12, 393);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(47, 16);
            pointsLabel.TabIndex = 26;
            pointsLabel.Text = "Points:";
            pointsLabel.Click += new System.EventHandler(this.pointsLabel_Click);
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Points", true));
            this.pointsTextBox.Location = new System.Drawing.Point(77, 393);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(100, 22);
            this.pointsTextBox.TabIndex = 27;
            // 
            // PulneneNaVaprosi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 428);
            this.Controls.Add(pointsLabel);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(correctAnswerLabel);
            this.Controls.Add(this.correctAnswerTextBox);
            this.Controls.Add(ansDLabel);
            this.Controls.Add(this.ansDTextBox);
            this.Controls.Add(ansCLabel);
            this.Controls.Add(this.ansCTextBox);
            this.Controls.Add(ansBLabel);
            this.Controls.Add(this.ansBTextBox);
            this.Controls.Add(ansALabel);
            this.Controls.Add(this.ansATextBox);
            this.Controls.Add(questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PulneneNaVaprosi";
            this.Text = "PulneneNaVaprosi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PulneneNaVaprosi_FormClosing);
            this.Load += new System.EventHandler(this.PulneneNaVaprosi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stani_Bogat_11d_2025DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Stani_Bogat_11d_2025DataSet stani_Bogat_11d_2025DataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private Stani_Bogat_11d_2025DataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ansDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private Stani_Bogat_11d_2025DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox ansATextBox;
        private System.Windows.Forms.TextBox ansBTextBox;
        private System.Windows.Forms.TextBox ansCTextBox;
        private System.Windows.Forms.TextBox ansDTextBox;
        private System.Windows.Forms.TextBox correctAnswerTextBox;
        private System.Windows.Forms.TextBox pointsTextBox;
    }
}